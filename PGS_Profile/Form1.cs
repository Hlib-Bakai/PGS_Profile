using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGS_Profile
{
    public partial class Form1 : Form
    {
        private int currentIdx = 0;

        private String[] fields;
        private String[] values;
        private Label[] labels;
        private CheckBox[] checkers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fields = new String[] { "First name", "Last name", "Address", "Phone" };
            values = new String[4];
            labels = new Label[] { labelFN, labelLN, labelAd, labelPh };
            checkers = new CheckBox[] { checkBoxFN, checkBoxLN, checkBoxAd, checkBoxPh };

            buttonBack.Enabled = false;
            labelCurrent.Text = fields[currentIdx];
            textBoxVal.Text = values[currentIdx];
            labels[currentIdx].Font = new Font(labels[currentIdx].Font, FontStyle.Bold);
        }

        private void ChangeCurrent(bool toBack = false)  //Default - change to next
        {
            values[currentIdx] = textBoxVal.Text;
            checkers[currentIdx].Checked = (textBoxVal.Text != String.Empty);
            labels[currentIdx].Font = new Font(labels[currentIdx].Font, FontStyle.Regular);

            currentIdx = toBack ? currentIdx - 1 : currentIdx + 1;
            labelCurrent.Text = fields[currentIdx];
            textBoxVal.Text = values[currentIdx];
            labels[currentIdx].Font = new Font(labels[currentIdx].Font, FontStyle.Bold);

            buttonBack.Enabled = currentIdx == 0 ? false : true;
            buttonNext.Enabled = currentIdx == fields.Count() - 1 ? false : true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ChangeCurrent(true);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ChangeCurrent();
        }
    }
}
