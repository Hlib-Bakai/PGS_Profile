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

        private void ChangeCurrent(int newIdx) 
        {
            if (currentIdx != fields.Count())  //If was not a result page
            {
                values[currentIdx] = textBoxVal.Text;
                checkers[currentIdx].Checked = (textBoxVal.Text != String.Empty);
                labels[currentIdx].Font = new Font(labels[currentIdx].Font, FontStyle.Regular);
            } else //If was a result page
            {
                buttonNext.Click -= buttonExit_Click;
                buttonNext.Click += buttonNext_Click;
            }

            currentIdx = newIdx;

            buttonBack.Enabled = currentIdx == 0 ? false : true;

            panel2.Visible = currentIdx == fields.Count();
            if (panel2.Visible)
            {
                fillResult();
                buttonNext.Text = "Exit";
                buttonNext.Click -= buttonNext_Click;
                buttonNext.Click += buttonExit_Click;
            }
            else
            {
                buttonNext.Text = "Next";
                labelCurrent.Text = fields[currentIdx];
                textBoxVal.Text = values[currentIdx];
                labels[currentIdx].Font = new Font(labels[currentIdx].Font, FontStyle.Bold);
            }
        }

        private void fillResult()
        {
            textBoxResult.Clear();

            for (int i = 0; i < fields.Count(); i++)
                textBoxResult.Text += String.Format("{0}: {1}" + Environment.NewLine, fields[i], values[i]);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ChangeCurrent(currentIdx - 1);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Proceed with exit?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ChangeCurrent(currentIdx + 1);
        }


        private void labelFN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangeCurrent(0);
        }

        private void labelLN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangeCurrent(1);
        }

        private void labelAd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangeCurrent(2);
        }

        private void labelPh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangeCurrent(3);
        }
    }
}
