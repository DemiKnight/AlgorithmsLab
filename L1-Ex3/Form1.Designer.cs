namespace L1_Ex3
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
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.ColourCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(56, 103);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(100, 20);
            this.MessageTextBox.TabIndex = 0;
            // 
            // ColourCheckBox
            // 
            this.ColourCheckBox.AutoSize = true;
            this.ColourCheckBox.Location = new System.Drawing.Point(56, 190);
            this.ColourCheckBox.Name = "ColourCheckBox";
            this.ColourCheckBox.Size = new System.Drawing.Size(46, 17);
            this.ColourCheckBox.TabIndex = 1;
            this.ColourCheckBox.Text = "Red";
            this.ColourCheckBox.UseVisualStyleBackColor = true;
            this.ColourCheckBox.CheckedChanged += new System.EventHandler(this.ColourCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 450);
            this.Controls.Add(this.ColourCheckBox);
            this.Controls.Add(this.MessageTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.CheckBox ColourCheckBox;
    }
}

