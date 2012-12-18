namespace BaseFrameWork.UI.BaseWinframeProject
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
            this.rulerBar1 = new TXTextControl.RulerBar();
            this.textControl1 = new TXTextControl.TextControl();
            this.buttonBar1 = new TXTextControl.ButtonBar();
            this.statusBar1 = new TXTextControl.StatusBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_SaveFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat_Paragraph = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat_Character = new System.Windows.Forms.ToolStripMenuItem();
            this.paragraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rulerBar1
            // 
            this.rulerBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rulerBar1.Location = new System.Drawing.Point(0, 53);
            this.rulerBar1.Name = "rulerBar1";
            this.rulerBar1.Size = new System.Drawing.Size(658, 25);
            this.rulerBar1.TabIndex = 0;
            this.rulerBar1.Text = "rulerBar1";
            // 
            // textControl1
            // 
            this.textControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.textControl1.Location = new System.Drawing.Point(0, 78);
            this.textControl1.Name = "textControl1";
            this.textControl1.Size = new System.Drawing.Size(658, 356);
            this.textControl1.TabIndex = 0;
            this.textControl1.Text = "textControl1";
            this.textControl1.ViewMode = TXTextControl.ViewMode.PageView;
            // 
            // buttonBar1
            // 
            this.buttonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBar1.Location = new System.Drawing.Point(0, 25);
            this.buttonBar1.Name = "buttonBar1";
            this.buttonBar1.Size = new System.Drawing.Size(658, 28);
            this.buttonBar1.TabIndex = 2;
            this.buttonBar1.Text = "buttonBar1";
            // 
            // statusBar1
            // 
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar1.Location = new System.Drawing.Point(0, 434);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(658, 18);
            this.statusBar1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.editToolStripMenuItem,
            this.mnuFormat_Paragraph});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile_OpenFile,
            this.mnuFile_SaveFileAs});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.filesToolStripMenuItem.Text = "File";
            // 
            // mnuFile_OpenFile
            // 
            this.mnuFile_OpenFile.Name = "mnuFile_OpenFile";
            this.mnuFile_OpenFile.Size = new System.Drawing.Size(105, 22);
            this.mnuFile_OpenFile.Text = "Load";
            this.mnuFile_OpenFile.Click += new System.EventHandler(this.mnuFile_OpenFile_Click);
            // 
            // mnuFile_SaveFileAs
            // 
            this.mnuFile_SaveFileAs.Name = "mnuFile_SaveFileAs";
            this.mnuFile_SaveFileAs.Size = new System.Drawing.Size(105, 22);
            this.mnuFile_SaveFileAs.Text = "Save";
            this.mnuFile_SaveFileAs.Click += new System.EventHandler(this.mnuFile_SaveFileAs_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCut,
            this.mnuCopy,
            this.mnuPaste});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mnuCut
            // 
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.Size = new System.Drawing.Size(152, 22);
            this.mnuCut.Text = "Cut";
            this.mnuCut.Click += new System.EventHandler(this.mnuCut_Click);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Size = new System.Drawing.Size(152, 22);
            this.mnuCopy.Text = "Copy";
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // mnuPaste
            // 
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.Size = new System.Drawing.Size(152, 22);
            this.mnuPaste.Text = "Paste";
            this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
            // 
            // mnuFormat_Paragraph
            // 
            this.mnuFormat_Paragraph.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFormat_Character,
            this.paragraphToolStripMenuItem});
            this.mnuFormat_Paragraph.Name = "mnuFormat_Paragraph";
            this.mnuFormat_Paragraph.Size = new System.Drawing.Size(61, 21);
            this.mnuFormat_Paragraph.Text = "Format";
            // 
            // mnuFormat_Character
            // 
            this.mnuFormat_Character.Name = "mnuFormat_Character";
            this.mnuFormat_Character.Size = new System.Drawing.Size(152, 22);
            this.mnuFormat_Character.Text = "Character";
            this.mnuFormat_Character.Click += new System.EventHandler(this.mnuFormat_Character_Click);
            // 
            // paragraphToolStripMenuItem
            // 
            this.paragraphToolStripMenuItem.Name = "paragraphToolStripMenuItem";
            this.paragraphToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.paragraphToolStripMenuItem.Text = "Paragraph";
            this.paragraphToolStripMenuItem.Click += new System.EventHandler(this.paragraphToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 452);
            this.Controls.Add(this.textControl1);
            this.Controls.Add(this.rulerBar1);
            this.Controls.Add(this.buttonBar1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TXTextControl.RulerBar rulerBar1;
        private TXTextControl.TextControl textControl1;
        private TXTextControl.ButtonBar buttonBar1;
        private TXTextControl.StatusBar statusBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_SaveFileAs;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCut;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat_Paragraph;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat_Character;
        private System.Windows.Forms.ToolStripMenuItem paragraphToolStripMenuItem;
    }
}