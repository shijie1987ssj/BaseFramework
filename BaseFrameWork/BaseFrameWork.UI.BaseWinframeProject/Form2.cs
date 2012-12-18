using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace BaseFrameWork.UI.BaseWinframeProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textControl1.RulerBar = rulerBar1;
            textControl1.ButtonBar = buttonBar1;
            textControl1.StatusBar = statusBar1;
        }

        private void mnuFile_OpenFile_Click(object sender, EventArgs e)
        {
            textControl1.Load(TXTextControl.StreamType.RichTextFormat | TXTextControl.StreamType.HTMLFormat);
        }

        private void mnuFile_SaveFileAs_Click(object sender, EventArgs e)
        {
            textControl1.Save(TXTextControl.StreamType.RichTextFormat | TXTextControl.StreamType.HTMLFormat);
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            textControl1.Cut();

        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            textControl1.Copy();

        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            textControl1.Paste();

        }

        private void mnuFormat_Character_Click(object sender, EventArgs e)
        {
            textControl1.FontDialog();

        }

        private void paragraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textControl1.ParagraphFormatDialog();

        }
    }
}
