using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            TextArea.Clear();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "My open file dialog";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                TextArea.Clear();
                using (StreamReader sr  = new StreamReader(openfile.FileName))
                {
                    TextArea.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Text files (.txt)|*.txt";
            savefile.Title = "Save file as";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter txtoutput = new StreamWriter(savefile.FileName);
                txtoutput.Write(TextArea.Text);
                txtoutput.Close();
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            TextArea.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            TextArea.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            TextArea.Paste();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            TextArea.Undo();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            TextArea.Redo();
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            TextArea.SelectAll();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripButton.PerformClick();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openToolStripButton.PerformClick();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripButton.PerformClick();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripButton.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoButton.PerformClick();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redoButton.PerformClick();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutToolStripButton.PerformClick();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripButton.PerformClick();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasteToolStripButton.PerformClick();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextArea.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                TextArea.SelectionFont = fontDialog1.Font;
            }
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                TextArea.ForeColor = colorDialog1.Color;
            }
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                TextArea.BackColor = colorDialog1.Color;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Font BoldFont = new Font(TextArea.SelectionFont.FontFamily, TextArea.SelectionFont.SizeInPoints, FontStyle.Bold);
            Font RegularFont = new Font(TextArea.SelectionFont.FontFamily, TextArea.SelectionFont.SizeInPoints, FontStyle.Regular);

            if (TextArea.SelectionFont.Bold)
            {
                TextArea.SelectionFont = RegularFont;
            }
            else
            {
                TextArea.SelectionFont = BoldFont;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Font ItalicFont = new Font(TextArea.SelectionFont.FontFamily, TextArea.SelectionFont.SizeInPoints, FontStyle.Italic);
            Font RegularFont = new Font(TextArea.SelectionFont.FontFamily, TextArea.SelectionFont.SizeInPoints, FontStyle.Regular);

            if (TextArea.SelectionFont.Italic)
            {
                TextArea.SelectionFont = RegularFont;
            }
            else
            {
                TextArea.SelectionFont = ItalicFont;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Font UnderlineFont = new Font(TextArea.SelectionFont.FontFamily, TextArea.SelectionFont.SizeInPoints, FontStyle.Underline);
            Font RegularFont = new Font(TextArea.SelectionFont.FontFamily, TextArea.SelectionFont.SizeInPoints, FontStyle.Regular);

            if (TextArea.SelectionFont.Underline)
            {
                TextArea.SelectionFont = RegularFont;
            }
            else
            {
                TextArea.SelectionFont = UnderlineFont;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Font Strikeout = new Font(TextArea.SelectionFont.FontFamily, TextArea.SelectionFont.SizeInPoints, FontStyle.Strikeout);
            Font RegularFont = new Font(TextArea.SelectionFont.FontFamily, TextArea.SelectionFont.SizeInPoints, FontStyle.Regular);

            if (TextArea.SelectionFont.Strikeout)
            {
                TextArea.SelectionFont = RegularFont;
            }
            else
            {
                TextArea.SelectionFont = Strikeout;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            TextArea.SelectedText = TextArea.SelectedText.ToUpper();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            TextArea.SelectedText = TextArea.SelectedText.ToLower();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            float NewFontSize = TextArea.SelectionFont.SizeInPoints + 2;

            Font NewSize = new Font(TextArea.SelectionFont.Name, NewFontSize, TextArea.SelectionFont.Style);

            TextArea.SelectionFont = NewSize;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            float NewFontSize = TextArea.SelectionFont.SizeInPoints - 2;

            Font NewSize = new Font(TextArea.SelectionFont.Name, NewFontSize, TextArea.SelectionFont.Style);

            TextArea.SelectionFont = NewSize;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextArea.SelectionColor = colorDialog1.Color;
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {

        }
    }
}
