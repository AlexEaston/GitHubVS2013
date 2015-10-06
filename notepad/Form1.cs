using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Makes the selected text bold.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBtnBold_Click(object sender, EventArgs e)
        {
            System.Drawing.Font currentFont = rTbNp.SelectionFont;
            System.Drawing.FontStyle newFontStyle;

            if (rTbNp.SelectionFont.Bold == true)
            {              
                newFontStyle = FontStyle.Regular;
                tsBtnBold.Checked = false;
            }
            else
            {
                newFontStyle = FontStyle.Bold;
                tsBtnBold.Checked = true;
            }

            rTbNp.SelectionFont = new Font(
                currentFont.FontFamily,
                currentFont.Size,
                newFontStyle);
            
        }
        /// <summary>
        /// Makes the selected text italic.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBtnItalic_Click(object sender, EventArgs e)
        {
            System.Drawing.Font currentFont = rTbNp.SelectionFont;
            System.Drawing.FontStyle newFontStyle;

            if (rTbNp.SelectionFont.Italic == true)
            {
                newFontStyle = FontStyle.Regular;
                tsBtnItalic.Checked = false;
            }
            else
            {
                newFontStyle = FontStyle.Italic;
                tsBtnItalic.Checked = true;
            }

            rTbNp.SelectionFont = new Font(
                currentFont.FontFamily,
                currentFont.Size,
                newFontStyle);
        }
        /// <summary>
        /// Makes the selected text underlined
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsBtnUnderline_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Opens the save dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
        /// <summary>
        /// Opens the open dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        /// <summary>
        /// Save a file on "txt" or "rtf" type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filename = saveFileDialog1.FileName; 
            System.IO.File.WriteAllText(@filename, rTbNp.Text);
        }
        /// <summary>
        /// Opens a file and put text in the RichTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName))
            {
                String line = sr.ReadToEnd();
                rTbNp.Text = line;
            }

        }
    }
}
