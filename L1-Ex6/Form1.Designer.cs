namespace L1_Ex6
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
            this.TextBoxExpression = new System.Windows.Forms.TextBox();
            this.LabelExpression = new System.Windows.Forms.Label();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.LabelResult = new System.Windows.Forms.Label();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxExpression
            // 
            this.TextBoxExpression.Location = new System.Drawing.Point(77, 28);
            this.TextBoxExpression.Name = "TextBoxExpression";
            this.TextBoxExpression.Size = new System.Drawing.Size(100, 20);
            this.TextBoxExpression.TabIndex = 0;
            // 
            // LabelExpression
            // 
            this.LabelExpression.AutoSize = true;
            this.LabelExpression.Location = new System.Drawing.Point(13, 28);
            this.LabelExpression.Name = "LabelExpression";
            this.LabelExpression.Size = new System.Drawing.Size(58, 13);
            this.LabelExpression.TabIndex = 1;
            this.LabelExpression.Text = "Expression";
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Location = new System.Drawing.Point(77, 81);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.ReadOnly = true;
            this.TextBoxResult.Size = new System.Drawing.Size(100, 20);
            this.TextBoxResult.TabIndex = 2;
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(36, 84);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(37, 13);
            this.LabelResult.TabIndex = 3;
            this.LabelResult.Text = "Result";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(77, 180);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 4;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 246);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.LabelExpression);
            this.Controls.Add(this.TextBoxExpression);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxExpression;
        private System.Windows.Forms.Label LabelExpression;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Button BtnCalculate;
    }
}

