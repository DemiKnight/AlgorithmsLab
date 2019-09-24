namespace L1_Ex5
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
            this.LabelNumber1 = new System.Windows.Forms.Label();
            this.LabelNumber2 = new System.Windows.Forms.Label();
            this.TextBoxNumber1 = new System.Windows.Forms.TextBox();
            this.TextBoxNumber2 = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.CheckListOperator = new System.Windows.Forms.CheckedListBox();
            this.LabelOperator = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelNumber1
            // 
            this.LabelNumber1.AutoSize = true;
            this.LabelNumber1.Location = new System.Drawing.Point(30, 100);
            this.LabelNumber1.Name = "LabelNumber1";
            this.LabelNumber1.Size = new System.Drawing.Size(53, 13);
            this.LabelNumber1.TabIndex = 0;
            this.LabelNumber1.Text = "Number 1";
            // 
            // LabelNumber2
            // 
            this.LabelNumber2.AutoSize = true;
            this.LabelNumber2.Location = new System.Drawing.Point(30, 170);
            this.LabelNumber2.Name = "LabelNumber2";
            this.LabelNumber2.Size = new System.Drawing.Size(53, 13);
            this.LabelNumber2.TabIndex = 1;
            this.LabelNumber2.Text = "Number 2";
            // 
            // TextBoxNumber1
            // 
            this.TextBoxNumber1.Location = new System.Drawing.Point(90, 92);
            this.TextBoxNumber1.Name = "TextBoxNumber1";
            this.TextBoxNumber1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNumber1.TabIndex = 2;
            // 
            // TextBoxNumber2
            // 
            this.TextBoxNumber2.Location = new System.Drawing.Point(90, 162);
            this.TextBoxNumber2.Name = "TextBoxNumber2";
            this.TextBoxNumber2.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNumber2.TabIndex = 3;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(90, 243);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 4;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // CheckListOperator
            // 
            this.CheckListOperator.CheckOnClick = true;
            this.CheckListOperator.FormattingEnabled = true;
            this.CheckListOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "^"});
            this.CheckListOperator.Location = new System.Drawing.Point(258, 127);
            this.CheckListOperator.Name = "CheckListOperator";
            this.CheckListOperator.Size = new System.Drawing.Size(78, 79);
            this.CheckListOperator.TabIndex = 5;
            this.CheckListOperator.Tag = "Operator";
            // 
            // LabelOperator
            // 
            this.LabelOperator.AutoSize = true;
            this.LabelOperator.Location = new System.Drawing.Point(275, 116);
            this.LabelOperator.Name = "LabelOperator";
            this.LabelOperator.Size = new System.Drawing.Size(53, 13);
            this.LabelOperator.TabIndex = 6;
            this.LabelOperator.Text = "Operators";
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(33, 226);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(37, 13);
            this.LabelResult.TabIndex = 7;
            this.LabelResult.Text = "Result";
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Location = new System.Drawing.Point(90, 217);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.ReadOnly = true;
            this.TextBoxResult.Size = new System.Drawing.Size(100, 20);
            this.TextBoxResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.LabelOperator);
            this.Controls.Add(this.CheckListOperator);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TextBoxNumber2);
            this.Controls.Add(this.TextBoxNumber1);
            this.Controls.Add(this.LabelNumber2);
            this.Controls.Add(this.LabelNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNumber1;
        private System.Windows.Forms.Label LabelNumber2;
        private System.Windows.Forms.TextBox TextBoxNumber1;
        private System.Windows.Forms.TextBox TextBoxNumber2;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.CheckedListBox CheckListOperator;
        private System.Windows.Forms.Label LabelOperator;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.TextBox TextBoxResult;
    }
}

