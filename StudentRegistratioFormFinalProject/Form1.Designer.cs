namespace StudentRegistratioFormFinalProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FnameBox = new System.Windows.Forms.TextBox();
            this.LnameBox = new System.Windows.Forms.TextBox();
            this.MnameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maleButton = new System.Windows.Forms.RadioButton();
            this.femaleButton = new System.Windows.Forms.RadioButton();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Middle name: ";
            // 
            // FnameBox
            // 
            this.FnameBox.Location = new System.Drawing.Point(47, 159);
            this.FnameBox.MaximumSize = new System.Drawing.Size(3000, 700);
            this.FnameBox.MinimumSize = new System.Drawing.Size(352, 70);
            this.FnameBox.Name = "FnameBox";
            this.FnameBox.Size = new System.Drawing.Size(365, 22);
            this.FnameBox.TabIndex = 4;
            // 
            // LnameBox
            // 
            this.LnameBox.Location = new System.Drawing.Point(47, 223);
            this.LnameBox.MinimumSize = new System.Drawing.Size(365, 29);
            this.LnameBox.Name = "LnameBox";
            this.LnameBox.Size = new System.Drawing.Size(365, 22);
            this.LnameBox.TabIndex = 5;
            // 
            // MnameBox
            // 
            this.MnameBox.Location = new System.Drawing.Point(47, 292);
            this.MnameBox.MinimumSize = new System.Drawing.Size(352, 29);
            this.MnameBox.Name = "MnameBox";
            this.MnameBox.Size = new System.Drawing.Size(365, 22);
            this.MnameBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gender: ";
            // 
            // maleButton
            // 
            this.maleButton.AutoSize = true;
            this.maleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.maleButton.Location = new System.Drawing.Point(172, 366);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(73, 22);
            this.maleButton.TabIndex = 8;
            this.maleButton.TabStop = true;
            this.maleButton.Text = "MALE";
            this.maleButton.UseVisualStyleBackColor = true;
            this.maleButton.CheckedChanged += new System.EventHandler(this.mouseUncheckedMale);
            this.maleButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClickFemale);
            // 
            // femaleButton
            // 
            this.femaleButton.AutoSize = true;
            this.femaleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.femaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.femaleButton.Location = new System.Drawing.Point(264, 365);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(94, 22);
            this.femaleButton.TabIndex = 9;
            this.femaleButton.TabStop = true;
            this.femaleButton.Text = "FEMALE";
            this.femaleButton.UseVisualStyleBackColor = true;
            this.femaleButton.CheckedChanged += new System.EventHandler(this.mUnClickedFemale);
            this.femaleButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mClickFemale);
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.DropDownHeight = 70;
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.IntegralHeight = false;
            this.comboBoxDay.Location = new System.Drawing.Point(80, 467);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(66, 24);
            this.comboBoxDay.TabIndex = 10;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.DropDownHeight = 70;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.IntegralHeight = false;
            this.comboBoxMonth.Location = new System.Drawing.Point(152, 467);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(65, 24);
            this.comboBoxMonth.TabIndex = 11;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownHeight = 70;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.IntegralHeight = false;
            this.comboBoxYear.ItemHeight = 16;
            this.comboBoxYear.Location = new System.Drawing.Point(223, 467);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(88, 24);
            this.comboBoxYear.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(386, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitButton);
            this.button1.MouseLeave += new System.EventHandler(this.MouseLeaveButton);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(172, 521);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(128, 57);
            this.registerButton.TabIndex = 15;
            this.registerButton.Text = "REGISTER";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            this.registerButton.MouseLeave += new System.EventHandler(this.registerButton_MouseLeave);
            this.registerButton.MouseHover += new System.EventHandler(this.Register_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(496, 590);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.comboBoxDay);
            this.Controls.Add(this.femaleButton);
            this.Controls.Add(this.maleButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MnameBox);
            this.Controls.Add(this.LnameBox);
            this.Controls.Add(this.FnameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FnameBox;
        private System.Windows.Forms.TextBox LnameBox;
        private System.Windows.Forms.TextBox MnameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.RadioButton femaleButton;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button registerButton;
    }
}

