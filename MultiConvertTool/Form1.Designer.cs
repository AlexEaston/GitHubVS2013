namespace MultiConvertTool
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
            this.cbIn = new System.Windows.Forms.ComboBox();
            this.cbOut = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbIn = new System.Windows.Forms.TextBox();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conversionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbIn
            // 
            this.cbIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIn.FormattingEnabled = true;
            this.cbIn.Location = new System.Drawing.Point(183, 50);
            this.cbIn.Name = "cbIn";
            this.cbIn.Size = new System.Drawing.Size(89, 21);
            this.cbIn.TabIndex = 1;
            // 
            // cbOut
            // 
            this.cbOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOut.FormattingEnabled = true;
            this.cbOut.Location = new System.Drawing.Point(183, 114);
            this.cbOut.Name = "cbOut";
            this.cbOut.Size = new System.Drawing.Size(89, 21);
            this.cbOut.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(19, 160);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(102, 160);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbIn
            // 
            this.tbIn.Location = new System.Drawing.Point(19, 50);
            this.tbIn.Name = "tbIn";
            this.tbIn.Size = new System.Drawing.Size(158, 20);
            this.tbIn.TabIndex = 5;
            // 
            // tbOut
            // 
            this.tbOut.Location = new System.Drawing.Point(19, 114);
            this.tbOut.Name = "tbOut";
            this.tbOut.ReadOnly = true;
            this.tbOut.Size = new System.Drawing.Size(158, 20);
            this.tbOut.TabIndex = 6;
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(16, 34);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(16, 13);
            this.lblIn.TabIndex = 7;
            this.lblIn.Text = "In";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(16, 98);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(24, 13);
            this.lblOut.TabIndex = 8;
            this.lblOut.Text = "Out";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conversionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conversionsToolStripMenuItem
            // 
            this.conversionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currencyToolStripMenuItem,
            this.lengthToolStripMenuItem,
            this.temperatureToolStripMenuItem});
            this.conversionsToolStripMenuItem.Name = "conversionsToolStripMenuItem";
            this.conversionsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.conversionsToolStripMenuItem.Text = "Conversions";
            // 
            // currencyToolStripMenuItem
            // 
            this.currencyToolStripMenuItem.Name = "currencyToolStripMenuItem";
            this.currencyToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.currencyToolStripMenuItem.Text = "Currency";
            this.currencyToolStripMenuItem.Click += new System.EventHandler(this.currencyToolStripMenuItem_Click);
            // 
            // lengthToolStripMenuItem
            // 
            this.lengthToolStripMenuItem.Name = "lengthToolStripMenuItem";
            this.lengthToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.lengthToolStripMenuItem.Text = "Length";
            this.lengthToolStripMenuItem.Click += new System.EventHandler(this.lengthToolStripMenuItem_Click);
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.temperatureToolStripMenuItem.Text = "Temperature";
            this.temperatureToolStripMenuItem.Click += new System.EventHandler(this.temperatureToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 195);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.tbOut);
            this.Controls.Add(this.tbIn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cbOut);
            this.Controls.Add(this.cbIn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Multi Conversion Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIn;
        private System.Windows.Forms.ComboBox cbOut;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbIn;
        private System.Windows.Forms.TextBox tbOut;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conversionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lengthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureToolStripMenuItem;

    }
}

