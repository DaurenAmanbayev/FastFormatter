using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextFastFormat.Extractor;

namespace FastFormatter
{
    public partial class PatternsManager : Form
    {
        PatternBrowser browser;
        string filename;

        public PatternsManager(PatternBrowser browser)
        {
            InitializeComponent();
            this.browser = browser;
            this.filename = browser.Location;
        }

        private void LoadBrowser()
        {            
            int id = 1;
            foreach (var pattern in browser.GetPatternList())
            {
                BuildItem(id, pattern);
                id++;
            }
        }
        private void BuildItem(int id, Pattern pattern)
        {
            var item = new ListViewItem(new[]
                {
                    id.ToString(),
                    pattern.Name,
                    pattern.Value
                });
            item.Name = pattern.Name;

            // item.BackColor = SystemColors.ActiveBorder;
            listViewPatterns.Items.Add(item);
        }

        #region MENU
        private void addPatternToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatternFrm frm = new PatternFrm();
            var result=frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                var container = frm.Container;                
                browser.AddPattern(container);
                listViewPatterns.Items.Clear();
                LoadBrowser();
                Changed();
            }

        }
        private void Changed()
        {
            this.DialogResult=DialogResult.OK;
        }

        private void deletePatternToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewPatterns.SelectedItems.Count > 0)
            {
                var item = listViewPatterns.SelectedItems[0];
                browser.RemovePattern(item.Name);
                listViewPatterns.Items.Remove(item);
                Changed();
            }
        }
        #endregion

        private void PatternsFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            browser.Save(filename);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
