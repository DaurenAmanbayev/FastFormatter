using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextFastFormat.Editor;
using TextFastFormat.Extractor;

namespace FastFormatter
{
    public partial class Main : Form
    {
        string filename = "browser.xml";
        PatternBrowser browser = new PatternBrowser();
        string[] patterns;
        
        /*MAIN INTERFACE*/
        public Main()
        {
            InitializeComponent();
            browser.Location = filename;
            LoadBrowser();
            LoadStandardPatterns();
        }

        #region COMBO BOX
        private void LoadBrowser()
        {            
            try {
                browser.Read(filename);
            }
            catch (Exception)
            {
               // MessageBox.Show("Browser not saved yet!");
            }
        }
        private void LoadAdvPatterns()
        {
            patterns = browser.GetPatternNamesList().ToArray();
            comboBoxUpdate();
        }
        private void LoadStandardPatterns()
        {
            patterns = new string[]
                    {
                        "IP Address",
                        "Email"                        
                    };
            comboBoxUpdate();
        }
        private void LoadPatterns()
        {
            if (checkBoxAdvPatterns.Checked)
            {
                LoadAdvPatterns();                
            }
            else
            {
                LoadStandardPatterns();
            }
        }
        private void comboBoxUpdate()
        {
            comboBoxPatterns.Items.Clear();
            foreach (var pattern in patterns)
            {
                comboBoxPatterns.Items.Add(pattern);
            }
            if (comboBoxPatterns.Items.Count > 0)
            {
                comboBoxPatterns.SelectedIndex = 0;
            }
        }
        #endregion

        #region MENU

        private void checkBoxAdvPatterns_CheckedChanged(object sender, EventArgs e)
        {
            LoadPatterns();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Document (*.txt)|*.txt";
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    var content = File.ReadAllText(openFileDialog.FileName);
                    richTextBoxContent.Text = content;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveFileAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter= "Text Document (*.txt)|*.txt";
            var result = saveFileDialog.ShowDialog();
            if(result==DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, richTextBoxContent.Text);                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            this.Close();
        }

        private void managePatternsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatternsManager frm = new PatternsManager(browser);
            frm.ShowDialog();
            LoadBrowser();           
            
        }
        #endregion

        #region EXTRACT
        private void buttonExtract_Click(object sender, EventArgs e)
        {
            if (checkBoxUseCustom.Checked && !textBoxSearchPattern.Text.Equals("") && !richTextBoxContent.Text.Equals(""))
            {
                PatternExtract(textBoxSearchPattern.Text);
            }
            else
            {                
                if (comboBoxPatterns.SelectedItem!=null)
                {
                    var patternName = comboBoxPatterns.SelectedItem.ToString();
                   
                    if (checkBoxAdvPatterns.Checked)
                    {
                        var pattern = browser.GetPattern(patternName);
                    }
                    else
                    {
                        switch (patternName)
                        {
                            case "IP Address": IpAddressExtract(); break;
                            case "Email": PatternExtract(PatternBrowser.Mail); break; 
                            
                        }
                    }
                }                
            }        
        }
        private void PatternExtract(string pattern)
        {
            try
            {               
                var content = richTextBoxContent.Text;
                var lines = RegexWorker.Singletone.SeparatorMatches(content, pattern);
                if (lines.Count > 0)
                {
                    richTextBoxContent.Text = TextWorker.GenerateContent(lines, GetSeparator());
                }
                else
                {
                    MessageBox.Show("No results found by pattern!");       
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string GetSeparator()
        {
            if (radioButtonCRLF.Checked)
            {
                return "\r\n";
            }
            else
                return "\n";
        }
        private void IpAddressExtract()
        {
            var content=RegexWorker.Singletone.ExtractIpAddress(richTextBoxContent.Text);
            if (content.Count > 0)
            {               
                richTextBoxContent.Text = string.Join(GetSeparator(), content);
            }
        }
        #endregion

        #region EDITOR
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!richTextBoxContent.Text.Equals(""))
            {
                try
                {
                    if (radioButtonBrackets.Checked)
                    {
                        Bracket();
                    }
                    else if (radioButtonReplace.Checked)
                    {
                        Replace();
                    }
                    else if (radioButtonTrim.Checked)
                    {
                        Trim();
                    }
                    else if (radioButtonFormat.Checked)
                    {
                        Format();
                    }
                    else if (radioButtonRemove.Checked)
                    {
                        Remove();
                    }
                }
                catch (Exception)
                {
                    Message("Something wrong with your input or pattern!");
                }
            }
            else
            {
                Message("Input Empty!");
            }
        }
        private void Bracket()
        {
            if (!textBoxBracketStart.Text.Equals("") || !textBoxBracketEnd.Text.Equals(""))
            {
                var start = textBoxBracketStart.Text;
                var end = textBoxBracketEnd.Text;
                var input = richTextBoxContent.Text;

                richTextBoxContent.Text = TextWorker.GenerateBrackets(input, start, end);
            }
            else
            {
                Message("All brackets is empty!");
            }
        }
        private void Replace()
        {
            if (!textBoxPattern.Text.Equals("") && !textBoxReplace.Text.Equals(""))
            {
                var pattern = textBoxPattern.Text;
                var replace = textBoxReplace.Text;
                var input = richTextBoxContent.Text;

                richTextBoxContent.Text = TextWorker.Replace(input, pattern, replace);
            }
            else
            {
                Message("Pattern or replace is empty!");
            }
        }
        private void Remove()
        {
            if (!textBoxPattern.Text.Equals(""))
            {
                var pattern = textBoxPattern.Text;
               
                var input = richTextBoxContent.Text;

                richTextBoxContent.Text = TextWorker.Remove(input, pattern);
            }
            else
            {
                Message("Pattern to remove is empty!");
            }
        }
        private void Trim()
        {
            if (!textBoxPattern.Text.Equals(""))
            {
                var pattern = textBoxPattern.Text;
                
                var input = richTextBoxContent.Text;

                richTextBoxContent.Text = TextWorker.TrimByLine(input, pattern, GetSeparator());
            }
            else
            {
                Message("Pattern is empty!");
            }
        }
        private void Format()
        {
            if (!textBoxPattern.Text.Equals(""))
            {
                var pattern = textBoxPattern.Text;
                var input = richTextBoxContent.Text;
             
                richTextBoxContent.Text = TextWorker.FormatByLine(input, pattern, GetSeparator());
            }
            else
            {
                Message("Pattern format is empty!");
            }
        }
        private void Message(string msg)
        {
            MessageBox.Show(msg);
        }
        private void radioButtonBrackets_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonBrackets.Checked)
            {
                textBoxPattern.ReadOnly = false;
                textBoxBracketStart.ReadOnly = true;
                textBoxBracketEnd.ReadOnly = true;
            }
            else
            {
                textBoxPattern.ReadOnly = true;
                textBoxBracketStart.ReadOnly = false;
                textBoxBracketEnd.ReadOnly = false;
            }
        }
        private void radioButtonReplace_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonReplace.Checked)
            {
                textBoxReplace.ReadOnly = false;
            }
            else
            {
                textBoxReplace.ReadOnly = true;
            }
        }
        private void checkBoxUseCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUseCustom.Checked)
            {
                textBoxSearchPattern.ReadOnly = false;
            }
            else
            {
                textBoxSearchPattern.ReadOnly = true;
            }
        }
        #endregion
    }
}
