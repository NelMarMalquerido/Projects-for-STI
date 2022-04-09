namespace StudentRegistratioFormFinalProject
{
    partial class Form2
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
            this.outputBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.AutoSize = true;
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputBox.Location = new System.Drawing.Point(21, 75);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(2, 18);
            this.outputBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(341, 189);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(7, 20, 20, 20);
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label outputBox;
        private System.Windows.Forms.Label label1;
    }
}