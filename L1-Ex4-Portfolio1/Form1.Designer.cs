namespace L1_Ex4_Portfolio1
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
            this.ColorCheckBox = new System.Windows.Forms.CheckBox();
            this.MessageColourBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ColorCheckBox
            // 
            this.ColorCheckBox.AutoSize = true;
            this.ColorCheckBox.Location = new System.Drawing.Point(99, 194);
            this.ColorCheckBox.Name = "ColorCheckBox";
            this.ColorCheckBox.Size = new System.Drawing.Size(62, 17);
            this.ColorCheckBox.TabIndex = 0;
            this.ColorCheckBox.Text = "cOLOR";
            this.ColorCheckBox.UseVisualStyleBackColor = true;
            this.ColorCheckBox.CheckedChanged += new System.EventHandler(this.ColorCheckBox_CheckedChanged);
            // 
            // MessageColourBox
            // 
            this.MessageColourBox.Location = new System.Drawing.Point(99, 127);
            this.MessageColourBox.Name = "MessageColourBox";
            this.MessageColourBox.Size = new System.Drawing.Size(100, 20);
            this.MessageColourBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.MessageColourBox);
            this.Controls.Add(this.ColorCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ColorCheckBox;
        private System.Windows.Forms.TextBox MessageColourBox;
    }
}

