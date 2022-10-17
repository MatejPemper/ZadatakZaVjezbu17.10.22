using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormaProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (comboBoxOdabirPrograma.SelectedIndex == 1)
            {
                Process.Start("notepad.exe");
            }

            if(comboBoxOdabirPrograma.SelectedIndex == 0)
            {
                Process.Start("mspaint.exe");
            }
        }

        private void checkBoxAction_CheckedChanged(object sender, EventArgs e)
        {
            //  GroupBoxControl.Enabled = (GroupBoxControl.CheckState == CheckState.Checked);

            //  textBoxName.Enabled = (textBoxName.CheckState == CheckState.Checked);
            //  textBoxDescription.Enabled = (textBoxDescription.CheckState == CheckState.Checked);


        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Odaberite neko dugme", "Information",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.ShowDialog();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxDescription.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
