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
    public partial class PatternFrm : Form
    {
        public new Pattern Container = new Pattern();
        public PatternFrm()
        {
            InitializeComponent();           
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxPatternName.Text != null && textBoxPatternValue.Text != null)
            {
                Container.Name = textBoxPatternName.Text;
                Container.Value = textBoxPatternValue.Text;

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Properties can't be empty!");
            }
        }
    }
}
