namespace KUKA.Translate
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used. test
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelExtensionUpdate = new System.Windows.Forms.Label();
            this.LabelExtension = new System.Windows.Forms.Label();
            this.LabelFileNameUpdate = new System.Windows.Forms.Label();
            this.labelFileSize = new System.Windows.Forms.Label();
            this.LabelFilename = new System.Windows.Forms.Label();
            this.LabelFileSizeUpdate = new System.Windows.Forms.Label();
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OptionKeepOriginalComment = new System.Windows.Forms.CheckBox();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxPreview = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBoxDelimiter = new System.Windows.Forms.TextBox();
            this.LabelDelimValue = new System.Windows.Forms.Label();
            this.OptionOverwriteOriginalFile = new System.Windows.Forms.CheckBox();
            this.TooltipKeepOriginalComment = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipOverwriteOriginalFile = new System.Windows.Forms.ToolTip(this.components);
            this.Output = new System.Windows.Forms.GroupBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TranslationBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem2.Text = "About";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelExtensionUpdate);
            this.groupBox1.Controls.Add(this.LabelExtension);
            this.groupBox1.Controls.Add(this.LabelFileNameUpdate);
            this.groupBox1.Controls.Add(this.labelFileSize);
            this.groupBox1.Controls.Add(this.LabelFilename);
            this.groupBox1.Controls.Add(this.LabelFileSizeUpdate);
            this.groupBox1.Controls.Add(this.ButtonBrowse);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source File";
            // 
            // LabelExtensionUpdate
            // 
            this.LabelExtensionUpdate.AutoSize = true;
            this.LabelExtensionUpdate.Enabled = false;
            this.LabelExtensionUpdate.Location = new System.Drawing.Point(61, 76);
            this.LabelExtensionUpdate.Name = "LabelExtensionUpdate";
            this.LabelExtensionUpdate.Size = new System.Drawing.Size(53, 13);
            this.LabelExtensionUpdate.TabIndex = 13;
            this.LabelExtensionUpdate.Text = "Extension";
            // 
            // LabelExtension
            // 
            this.LabelExtension.AutoSize = true;
            this.LabelExtension.Location = new System.Drawing.Point(6, 76);
            this.LabelExtension.Name = "LabelExtension";
            this.LabelExtension.Size = new System.Drawing.Size(59, 13);
            this.LabelExtension.TabIndex = 12;
            this.LabelExtension.Text = "Extension: ";
            // 
            // LabelFileNameUpdate
            // 
            this.LabelFileNameUpdate.AutoSize = true;
            this.LabelFileNameUpdate.Location = new System.Drawing.Point(61, 59);
            this.LabelFileNameUpdate.Name = "LabelFileNameUpdate";
            this.LabelFileNameUpdate.Size = new System.Drawing.Size(49, 13);
            this.LabelFileNameUpdate.TabIndex = 11;
            this.LabelFileNameUpdate.Text = "Filename";
            // 
            // labelFileSize
            // 
            this.labelFileSize.AutoSize = true;
            this.labelFileSize.Location = new System.Drawing.Point(6, 42);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(30, 13);
            this.labelFileSize.TabIndex = 8;
            this.labelFileSize.Text = "Size:";
            // 
            // LabelFilename
            // 
            this.LabelFilename.AutoSize = true;
            this.LabelFilename.Location = new System.Drawing.Point(6, 59);
            this.LabelFilename.Name = "LabelFilename";
            this.LabelFilename.Size = new System.Drawing.Size(52, 13);
            this.LabelFilename.TabIndex = 10;
            this.LabelFilename.Text = "Filename:";
            // 
            // LabelFileSizeUpdate
            // 
            this.LabelFileSizeUpdate.AutoSize = true;
            this.LabelFileSizeUpdate.Location = new System.Drawing.Point(61, 42);
            this.LabelFileSizeUpdate.Name = "LabelFileSizeUpdate";
            this.LabelFileSizeUpdate.Size = new System.Drawing.Size(28, 13);
            this.LabelFileSizeUpdate.TabIndex = 9;
            this.LabelFileSizeUpdate.Text = "0 kb";
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.Location = new System.Drawing.Point(262, 17);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowse.TabIndex = 7;
            this.ButtonBrowse.Text = "Browse";
            this.ButtonBrowse.UseVisualStyleBackColor = true;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 6;
            // 
            // OptionKeepOriginalComment
            // 
            this.OptionKeepOriginalComment.AutoSize = true;
            this.OptionKeepOriginalComment.Location = new System.Drawing.Point(8, 19);
            this.OptionKeepOriginalComment.Name = "OptionKeepOriginalComment";
            this.OptionKeepOriginalComment.Size = new System.Drawing.Size(134, 17);
            this.OptionKeepOriginalComment.TabIndex = 5;
            this.OptionKeepOriginalComment.Text = "Keep original Comment";
            this.TooltipKeepOriginalComment.SetToolTip(this.OptionKeepOriginalComment, "Keeps the original comment in the output text file.\r\nUnchecked:\r\n    stop()   ; W" +
        "arning\r\nChecked:\r\n    stop()   : Achtung -> Warning");
            this.OptionKeepOriginalComment.UseVisualStyleBackColor = true;
            this.OptionKeepOriginalComment.CheckedChanged += new System.EventHandler(this.OptionKeepOriginalComment_CheckedChanged);
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(261, 132);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(77, 22);
            this.buttonTranslate.TabIndex = 2;
            this.buttonTranslate.Text = "Translate";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxPreview);
            this.groupBox2.Location = new System.Drawing.Point(363, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 411);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // richTextBoxPreview
            // 
            this.richTextBoxPreview.Location = new System.Drawing.Point(6, 21);
            this.richTextBoxPreview.Name = "richTextBoxPreview";
            this.richTextBoxPreview.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxPreview.Size = new System.Drawing.Size(413, 384);
            this.richTextBoxPreview.TabIndex = 1;
            this.richTextBoxPreview.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextBoxDelimiter);
            this.groupBox3.Controls.Add(this.LabelDelimValue);
            this.groupBox3.Controls.Add(this.OptionOverwriteOriginalFile);
            this.groupBox3.Controls.Add(this.buttonTranslate);
            this.groupBox3.Controls.Add(this.OptionKeepOriginalComment);
            this.groupBox3.Location = new System.Drawing.Point(13, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 160);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // TextBoxDelimiter
            // 
            this.TextBoxDelimiter.Location = new System.Drawing.Point(94, 64);
            this.TextBoxDelimiter.Name = "TextBoxDelimiter";
            this.TextBoxDelimiter.Size = new System.Drawing.Size(45, 20);
            this.TextBoxDelimiter.TabIndex = 8;
            this.TextBoxDelimiter.Text = ";";
            this.TextBoxDelimiter.TextChanged += new System.EventHandler(this.TextBoxDelimiter_TextChanged);
            // 
            // LabelDelimValue
            // 
            this.LabelDelimValue.AutoSize = true;
            this.LabelDelimValue.Location = new System.Drawing.Point(7, 67);
            this.LabelDelimValue.Name = "LabelDelimValue";
            this.LabelDelimValue.Size = new System.Drawing.Size(81, 13);
            this.LabelDelimValue.TabIndex = 7;
            this.LabelDelimValue.Text = "Delimiting value";
            this.TooltipKeepOriginalComment.SetToolTip(this.LabelDelimValue, "Value that indicates a comment:\r\nKRL          ;  comment\r\nC#, Java // comment");
            // 
            // OptionOverwriteOriginalFile
            // 
            this.OptionOverwriteOriginalFile.AutoSize = true;
            this.OptionOverwriteOriginalFile.Location = new System.Drawing.Point(8, 43);
            this.OptionOverwriteOriginalFile.Name = "OptionOverwriteOriginalFile";
            this.OptionOverwriteOriginalFile.Size = new System.Drawing.Size(128, 17);
            this.OptionOverwriteOriginalFile.TabIndex = 6;
            this.OptionOverwriteOriginalFile.Text = "Overwrite Original File";
            this.tooltipOverwriteOriginalFile.SetToolTip(this.OptionOverwriteOriginalFile, "Save your translated file with the same filename as original");
            this.OptionOverwriteOriginalFile.UseVisualStyleBackColor = true;
            this.OptionOverwriteOriginalFile.CheckedChanged += new System.EventHandler(this.OptionOverwriteOriginalFile_CheckedChanged);
            // 
            // Output
            // 
            this.Output.Controls.Add(this.ButtonSave);
            this.Output.Location = new System.Drawing.Point(13, 311);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(344, 127);
            this.Output.TabIndex = 7;
            this.Output.TabStop = false;
            this.Output.Text = "Output";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(261, 98);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 0;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // TranslationBackgroundWorker
            // 
            this.TranslationBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TranslationBackgroundWorker_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "KUKA.Translate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Output.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.CheckBox OptionKeepOriginalComment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ButtonBrowse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label labelFileSize;
        private System.Windows.Forms.Label LabelFileSizeUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox OptionOverwriteOriginalFile;
        private System.Windows.Forms.Label LabelDelimValue;
        private System.Windows.Forms.TextBox TextBoxDelimiter;
        private System.Windows.Forms.RichTextBox richTextBoxPreview;
        private System.Windows.Forms.Label LabelFilename;
        private System.Windows.Forms.Label LabelFileNameUpdate;
        private System.Windows.Forms.ToolTip TooltipKeepOriginalComment;
        private System.Windows.Forms.ToolTip tooltipOverwriteOriginalFile;
        private System.Windows.Forms.GroupBox Output;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ButtonSave;
        private System.ComponentModel.BackgroundWorker TranslationBackgroundWorker;
        private System.Windows.Forms.Label LabelExtension;
        private System.Windows.Forms.Label LabelExtensionUpdate;
    }
}

