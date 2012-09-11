namespace ns7.sadh.ByteReader
{
    partial class ByteReadForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ByteReadForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bottomStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.fileVisibilitySelector = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fileSizeLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileNameExtensionLabel = new System.Windows.Forms.ToolStripLabel();
            this.xBox = new System.Windows.Forms.TextBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.topStrip = new System.Windows.Forms.ToolStrip();
            this.selectFileButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fontSelect = new System.Windows.Forms.ToolStripButton();
            this.RefreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.openTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExecutableFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.readTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.bottomStrip.SuspendLayout();
            this.topStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.bottomStrip);
            this.panel1.Controls.Add(this.xBox);
            this.panel1.Controls.Add(this.topLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 415);
            this.panel1.TabIndex = 0;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterEvent);
            // 
            // bottomStrip
            // 
            this.bottomStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bottomStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.fileVisibilitySelector,
            this.toolStripSeparator3,
            this.fileSizeLabel,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.fileNameExtensionLabel});
            this.bottomStrip.Location = new System.Drawing.Point(0, 390);
            this.bottomStrip.Name = "bottomStrip";
            this.bottomStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bottomStrip.Size = new System.Drawing.Size(626, 25);
            this.bottomStrip.TabIndex = 5;
            this.bottomStrip.Text = "ByteReader";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(115, 22);
            this.toolStripLabel1.Text = "Visible Portion of File : ";
            this.toolStripLabel1.ToolTipText = "Select how many bytes from the first of the file is to be displayed.";
            // 
            // fileVisibilitySelector
            // 
            this.fileVisibilitySelector.Items.AddRange(new object[] {
            "Full",
            "1kB",
            "64kB",
            "1MB"});
            this.fileVisibilitySelector.Name = "fileVisibilitySelector";
            this.fileVisibilitySelector.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fileVisibilitySelector.Size = new System.Drawing.Size(121, 25);
            this.fileVisibilitySelector.ToolTipText = "Select how many bytes from the first of the file is to be displayed.";
            this.fileVisibilitySelector.SelectedIndexChanged += new System.EventHandler(this.FileVisibilitySelected);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(78, 22);
            this.fileSizeLabel.Text = "0 (select a file)";
            this.fileSizeLabel.ToolTipText = "The size of selected file is displayed here";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel2.Text = "File Size :";
            this.toolStripLabel2.ToolTipText = "Size of selected file.";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // fileNameExtensionLabel
            // 
            this.fileNameExtensionLabel.Name = "fileNameExtensionLabel";
            this.fileNameExtensionLabel.Size = new System.Drawing.Size(19, 22);
            this.fileNameExtensionLabel.Text = "...";
            this.fileNameExtensionLabel.ToolTipText = "Name of Selected File";
            // 
            // xBox
            // 
            this.xBox.AllowDrop = true;
            this.xBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xBox.BackColor = System.Drawing.Color.AliceBlue;
            this.xBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.xBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.xBox.Location = new System.Drawing.Point(0, 45);
            this.xBox.Multiline = true;
            this.xBox.Name = "xBox";
            this.xBox.ReadOnly = true;
            this.xBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.xBox.Size = new System.Drawing.Size(625, 342);
            this.xBox.TabIndex = 2;
            this.xBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.xBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterEvent);
            // 
            // topLabel
            // 
            this.topLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.topLabel.AutoSize = true;
            this.topLabel.BackColor = System.Drawing.SystemColors.Info;
            this.topLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topLabel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.topLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.topLabel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(0, 25);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(1052, 17);
            this.topLabel.TabIndex = 3;
            this.topLabel.Text = " Byte  Number     00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F    Text Within " +
                "Byte                                                                ";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // topStrip
            // 
            this.topStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.topStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFileButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.fontSelect,
            this.RefreshToolStripButton,
            this.helpToolStripButton,
            this.toolStripSplitButton1});
            this.topStrip.Location = new System.Drawing.Point(0, 0);
            this.topStrip.Name = "topStrip";
            this.topStrip.Size = new System.Drawing.Size(626, 25);
            this.topStrip.TabIndex = 1;
            this.topStrip.Text = "Byte Read by iceSapphire";
            // 
            // selectFileButton
            // 
            this.selectFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectFileButton.Image = ((System.Drawing.Image)(resources.GetObject("selectFileButton.Image")));
            this.selectFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.RightToLeftAutoMirrorImage = true;
            this.selectFileButton.Size = new System.Drawing.Size(23, 22);
            this.selectFileButton.Text = "Select File";
            this.selectFileButton.ToolTipText = "Select a file. This application will read it bytewise";
            this.selectFileButton.Click += new System.EventHandler(this.SelectFileEvent);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(53, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.SelectFileEvent);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.SaveInFileEvent);
            // 
            // fontSelect
            // 
            this.fontSelect.Image = ((System.Drawing.Image)(resources.GetObject("fontSelect.Image")));
            this.fontSelect.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fontSelect.Name = "fontSelect";
            this.fontSelect.Size = new System.Drawing.Size(49, 22);
            this.fontSelect.Text = "&Font";
            this.fontSelect.ToolTipText = "Select Font";
            this.fontSelect.Click += new System.EventHandler(this.SelectFontEvent);
            // 
            // RefreshToolStripButton
            // 
            this.RefreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshToolStripButton.Image")));
            this.RefreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshToolStripButton.Name = "RefreshToolStripButton";
            this.RefreshToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.RefreshToolStripButton.Text = "Refresh";
            this.RefreshToolStripButton.Click += new System.EventHandler(this.RefreshEvent);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.AboutEvent);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTextFileToolStripMenuItem,
            this.openExecutableFileToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(155, 22);
            this.toolStripSplitButton1.Text = "Open File in Other Mode";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // openTextFileToolStripMenuItem
            // 
            this.openTextFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openTextFileToolStripMenuItem.Image")));
            this.openTextFileToolStripMenuItem.Name = "openTextFileToolStripMenuItem";
            this.openTextFileToolStripMenuItem.Size = new System.Drawing.Size(191, 38);
            this.openTextFileToolStripMenuItem.Text = "Open Text File";
            this.openTextFileToolStripMenuItem.Click += new System.EventHandler(this.OpenTextEvent);
            // 
            // openExecutableFileToolStripMenuItem
            // 
            this.openExecutableFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openExecutableFileToolStripMenuItem.Image")));
            this.openExecutableFileToolStripMenuItem.Name = "openExecutableFileToolStripMenuItem";
            this.openExecutableFileToolStripMenuItem.Size = new System.Drawing.Size(191, 38);
            this.openExecutableFileToolStripMenuItem.Text = "Open Executable File";
            this.openExecutableFileToolStripMenuItem.Click += new System.EventHandler(this.ExeFileOpenEvent);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Byte Reader : an application by iceSapphire which reads anyfile in byte format an" +
                "d show them in hexadecimal.";
            this.notifyIcon1.BalloonTipTitle = "Byte Reader";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "byte reader";
            this.notifyIcon1.Visible = true;
            // 
            // readTextFileToolStripMenuItem
            // 
            this.readTextFileToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readTextFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("readTextFileToolStripMenuItem.Image")));
            this.readTextFileToolStripMenuItem.Name = "readTextFileToolStripMenuItem";
            this.readTextFileToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.readTextFileToolStripMenuItem.Text = "Open Text File";
            this.readTextFileToolStripMenuItem.Click += new System.EventHandler(this.OpenTextEvent);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.openToolStripMenuItem.Text = "Open Executable";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.ExeFileOpenEvent);
            // 
            // ByteReadForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(626, 415);
            this.Controls.Add(this.topStrip);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(634, 449);
            this.Name = "ByteReadForm";
            this.Opacity = 0.9;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sfaar Byte Reader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bottomStrip.ResumeLayout(false);
            this.bottomStrip.PerformLayout();
            this.topStrip.ResumeLayout(false);
            this.topStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.ToolStrip bottomStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox fileVisibilitySelector;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel fileSizeLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip topStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton selectFileButton;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripButton fontSelect;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripLabel fileNameExtensionLabel;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripButton RefreshToolStripButton;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem readTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExecutableFileToolStripMenuItem;


    }
}

