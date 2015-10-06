namespace CurrencyConverter
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
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.tbxIn = new System.Windows.Forms.TextBox();
            this.tbxOut = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbFrom
            // 
            this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.cbFrom.Location = new System.Drawing.Point(188, 65);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(62, 21);
            this.cbFrom.TabIndex = 0;
            // 
            // cbTo
            // 
            this.cbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.cbTo.Location = new System.Drawing.Point(188, 120);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(62, 21);
            this.cbTo.TabIndex = 1;
            // 
            // tbxIn
            // 
            this.tbxIn.Location = new System.Drawing.Point(12, 65);
            this.tbxIn.Name = "tbxIn";
            this.tbxIn.Size = new System.Drawing.Size(170, 20);
            this.tbxIn.TabIndex = 2;
            // 
            // tbxOut
            // 
            this.tbxOut.Location = new System.Drawing.Point(12, 121);
            this.tbxOut.Name = "tbxOut";
            this.tbxOut.ReadOnly = true;
            this.tbxOut.Size = new System.Drawing.Size(170, 20);
            this.tbxOut.TabIndex = 3;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(13, 46);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(96, 13);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "Enter the sum here";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(12, 105);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(27, 13);
            this.lblOut.TabIndex = 5;
            this.lblOut.Text = "Out ";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(188, 46);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(188, 104);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "To";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 168);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(93, 168);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.tbxOut);
            this.Controls.Add(this.tbxIn);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.cbFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.TextBox tbxIn;
        private System.Windows.Forms.TextBox tbxOut;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
    }
}

