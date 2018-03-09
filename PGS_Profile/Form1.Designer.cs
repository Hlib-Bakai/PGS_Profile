namespace PGS_Profile
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxFN = new System.Windows.Forms.CheckBox();
            this.checkBoxLN = new System.Windows.Forms.CheckBox();
            this.checkBoxAd = new System.Windows.Forms.CheckBox();
            this.checkBoxPh = new System.Windows.Forms.CheckBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxVal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.labelFN = new System.Windows.Forms.LinkLabel();
            this.labelAd = new System.Windows.Forms.LinkLabel();
            this.labelPh = new System.Windows.Forms.LinkLabel();
            this.labelLN = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxFN
            // 
            this.checkBoxFN.AutoSize = true;
            this.checkBoxFN.Enabled = false;
            this.checkBoxFN.Location = new System.Drawing.Point(13, 13);
            this.checkBoxFN.Name = "checkBoxFN";
            this.checkBoxFN.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFN.TabIndex = 0;
            this.checkBoxFN.UseVisualStyleBackColor = true;
            // 
            // checkBoxLN
            // 
            this.checkBoxLN.AutoSize = true;
            this.checkBoxLN.Enabled = false;
            this.checkBoxLN.Location = new System.Drawing.Point(13, 36);
            this.checkBoxLN.Name = "checkBoxLN";
            this.checkBoxLN.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLN.TabIndex = 1;
            this.checkBoxLN.UseVisualStyleBackColor = true;
            // 
            // checkBoxAd
            // 
            this.checkBoxAd.AutoSize = true;
            this.checkBoxAd.Enabled = false;
            this.checkBoxAd.Location = new System.Drawing.Point(111, 12);
            this.checkBoxAd.Name = "checkBoxAd";
            this.checkBoxAd.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAd.TabIndex = 2;
            this.checkBoxAd.UseVisualStyleBackColor = true;
            // 
            // checkBoxPh
            // 
            this.checkBoxPh.AutoSize = true;
            this.checkBoxPh.Enabled = false;
            this.checkBoxPh.Location = new System.Drawing.Point(111, 35);
            this.checkBoxPh.Name = "checkBoxPh";
            this.checkBoxPh.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPh.TabIndex = 3;
            this.checkBoxPh.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(90, 37);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Location = new System.Drawing.Point(99, 0);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(90, 37);
            this.buttonNext.TabIndex = 9;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 37);
            this.panel1.TabIndex = 10;
            // 
            // textBoxVal
            // 
            this.textBoxVal.Location = new System.Drawing.Point(13, 154);
            this.textBoxVal.Name = "textBoxVal";
            this.textBoxVal.Size = new System.Drawing.Size(164, 20);
            this.textBoxVal.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Please, provide your";
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.Location = new System.Drawing.Point(114, 135);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(37, 13);
            this.labelCurrent.TabIndex = 13;
            this.labelCurrent.Text = "-none-";
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Location = new System.Drawing.Point(36, 12);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(55, 13);
            this.labelFN.TabIndex = 14;
            this.labelFN.TabStop = true;
            this.labelFN.Text = "First name";
            this.labelFN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelFN_LinkClicked);
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(132, 12);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(45, 13);
            this.labelAd.TabIndex = 15;
            this.labelAd.TabStop = true;
            this.labelAd.Text = "Address";
            this.labelAd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelAd_LinkClicked);
            // 
            // labelPh
            // 
            this.labelPh.AutoSize = true;
            this.labelPh.Location = new System.Drawing.Point(132, 35);
            this.labelPh.Name = "labelPh";
            this.labelPh.Size = new System.Drawing.Size(38, 13);
            this.labelPh.TabIndex = 16;
            this.labelPh.TabStop = true;
            this.labelPh.Text = "Phone";
            this.labelPh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelPh_LinkClicked);
            // 
            // labelLN
            // 
            this.labelLN.AutoSize = true;
            this.labelLN.Location = new System.Drawing.Point(36, 35);
            this.labelLN.Name = "labelLN";
            this.labelLN.Size = new System.Drawing.Size(56, 13);
            this.labelLN.TabIndex = 17;
            this.labelLN.TabStop = true;
            this.labelLN.Text = "Last name";
            this.labelLN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelLN_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxResult);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 180);
            this.panel2.TabIndex = 18;
            this.panel2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thank you!";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(13, 30);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(164, 144);
            this.textBoxResult.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(189, 217);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelLN);
            this.Controls.Add(this.labelPh);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.labelFN);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxVal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxPh);
            this.Controls.Add(this.checkBoxAd);
            this.Controls.Add(this.checkBoxLN);
            this.Controls.Add(this.checkBoxFN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxFN;
        private System.Windows.Forms.CheckBox checkBoxLN;
        private System.Windows.Forms.CheckBox checkBoxAd;
        private System.Windows.Forms.CheckBox checkBoxPh;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxVal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCurrent;
        private System.Windows.Forms.LinkLabel labelFN;
        private System.Windows.Forms.LinkLabel labelAd;
        private System.Windows.Forms.LinkLabel labelPh;
        private System.Windows.Forms.LinkLabel labelLN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label1;
    }
}

