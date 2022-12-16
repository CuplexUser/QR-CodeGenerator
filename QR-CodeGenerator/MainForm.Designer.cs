namespace QR_CodeGenerator
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuQrImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxMainControlls = new System.Windows.Forms.GroupBox();
            this.pnlPicBox = new System.Windows.Forms.Panel();
            this.picBoxQR = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBoxQuality = new System.Windows.Forms.GroupBox();
            this.rdQhq = new System.Windows.Forms.RadioButton();
            this.rdQm = new System.Windows.Forms.RadioButton();
            this.rdQl = new System.Windows.Forms.RadioButton();
            this.rdQh = new System.Windows.Forms.RadioButton();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtInputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuMainApp = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateCNGRandomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateTextAndQRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImgDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuQrImage.SuspendLayout();
            this.grpBoxMainControlls.SuspendLayout();
            this.pnlPicBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQR)).BeginInit();
            this.grpBoxQuality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.menuMainApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuQrImage
            // 
            this.menuQrImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem,
            this.copyToClipboardToolStripMenuItem,
            this.toolStripMenuItem4,
            this.clearToolStripMenuItem1});
            this.menuQrImage.Name = "menuQrImage";
            this.menuQrImage.Size = new System.Drawing.Size(173, 76);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image As...";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy To Clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(169, 6);
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.ClearToolStripMenuItem1_Click);
            // 
            // grpBoxMainControlls
            // 
            this.grpBoxMainControlls.ContextMenuStrip = this.menuQrImage;
            this.grpBoxMainControlls.Controls.Add(this.pnlPicBox);
            this.grpBoxMainControlls.Controls.Add(this.btnClear);
            this.grpBoxMainControlls.Controls.Add(this.label3);
            this.grpBoxMainControlls.Controls.Add(this.label2);
            this.grpBoxMainControlls.Controls.Add(this.grpBoxQuality);
            this.grpBoxMainControlls.Controls.Add(this.numHeight);
            this.grpBoxMainControlls.Controls.Add(this.numWidth);
            this.grpBoxMainControlls.Controls.Add(this.btnGenerate);
            this.grpBoxMainControlls.Controls.Add(this.txtInputText);
            this.grpBoxMainControlls.Controls.Add(this.label1);
            this.grpBoxMainControlls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxMainControlls.Location = new System.Drawing.Point(5, 24);
            this.grpBoxMainControlls.Name = "grpBoxMainControlls";
            this.grpBoxMainControlls.Size = new System.Drawing.Size(424, 280);
            this.grpBoxMainControlls.TabIndex = 1;
            this.grpBoxMainControlls.TabStop = false;
            // 
            // pnlPicBox
            // 
            this.pnlPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPicBox.Controls.Add(this.picBoxQR);
            this.pnlPicBox.Location = new System.Drawing.Point(6, 23);
            this.pnlPicBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.pnlPicBox.Name = "pnlPicBox";
            this.pnlPicBox.Padding = new System.Windows.Forms.Padding(3);
            this.pnlPicBox.Size = new System.Drawing.Size(215, 219);
            this.pnlPicBox.TabIndex = 10;
            this.pnlPicBox.Resize += new System.EventHandler(this.pnlPicBox_Resize);
            // 
            // picBoxQR
            // 
            this.picBoxQR.BackColor = System.Drawing.SystemColors.Control;
            this.picBoxQR.ContextMenuStrip = this.menuQrImage;
            this.picBoxQR.Image = global::QR_CodeGenerator.Properties.Resources.gnome_mime_image_bmp_RealSR_JPEG_x4;
            this.picBoxQR.InitialImage = global::QR_CodeGenerator.Properties.Resources.gnome_mime_image_bmp_RealSR_JPEG_x4;
            this.picBoxQR.Location = new System.Drawing.Point(2, 3);
            this.picBoxQR.Name = "picBoxQR";
            this.picBoxQR.Padding = new System.Windows.Forms.Padding(2);
            this.picBoxQR.Size = new System.Drawing.Size(210, 210);
            this.picBoxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxQR.TabIndex = 0;
            this.picBoxQR.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(237, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Height";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Width";
            // 
            // grpBoxQuality
            // 
            this.grpBoxQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxQuality.Controls.Add(this.rdQhq);
            this.grpBoxQuality.Controls.Add(this.rdQm);
            this.grpBoxQuality.Controls.Add(this.rdQl);
            this.grpBoxQuality.Controls.Add(this.rdQh);
            this.grpBoxQuality.Location = new System.Drawing.Point(241, 19);
            this.grpBoxQuality.Name = "grpBoxQuality";
            this.grpBoxQuality.Size = new System.Drawing.Size(177, 141);
            this.grpBoxQuality.TabIndex = 6;
            this.grpBoxQuality.TabStop = false;
            this.grpBoxQuality.Text = "Error Tollerance";
            // 
            // rdQhq
            // 
            this.rdQhq.AutoSize = true;
            this.rdQhq.Location = new System.Drawing.Point(10, 72);
            this.rdQhq.Name = "rdQhq";
            this.rdQhq.Size = new System.Drawing.Size(34, 19);
            this.rdQhq.TabIndex = 3;
            this.rdQhq.Tag = "Q";
            this.rdQhq.Text = "Q";
            this.toolTip1.SetToolTip(this.rdQhq, "Q, or quarter offers a high degree of redundency . 25% Like its name and is only " +
        "nessesary on dense QR codes which also can be expected to work even if parts of " +
        "the code is missing or blurred.");
            this.rdQhq.UseVisualStyleBackColor = true;
            // 
            // rdQm
            // 
            this.rdQm.AutoSize = true;
            this.rdQm.Checked = true;
            this.rdQm.Location = new System.Drawing.Point(10, 47);
            this.rdQm.Name = "rdQm";
            this.rdQm.Size = new System.Drawing.Size(36, 19);
            this.rdQm.TabIndex = 2;
            this.rdQm.TabStop = true;
            this.rdQm.Tag = "M";
            this.rdQm.Text = "M";
            this.toolTip1.SetToolTip(this.rdQm, "Medium Quality, recommended for most types of QR codes. \r\nProvides 15% of redunde" +
        "ncy. ");
            this.rdQm.UseVisualStyleBackColor = true;
            // 
            // rdQl
            // 
            this.rdQl.AutoSize = true;
            this.rdQl.Location = new System.Drawing.Point(10, 22);
            this.rdQl.Name = "rdQl";
            this.rdQl.Size = new System.Drawing.Size(31, 19);
            this.rdQl.TabIndex = 1;
            this.rdQl.Tag = "L";
            this.rdQl.Text = "L";
            this.toolTip1.SetToolTip(this.rdQl, resources.GetString("rdQl.ToolTip"));
            this.rdQl.UseVisualStyleBackColor = true;
            // 
            // rdQh
            // 
            this.rdQh.AutoSize = true;
            this.rdQh.Location = new System.Drawing.Point(10, 97);
            this.rdQh.Name = "rdQh";
            this.rdQh.Size = new System.Drawing.Size(34, 19);
            this.rdQh.TabIndex = 0;
            this.rdQh.Tag = "H";
            this.rdQh.Text = "H";
            this.toolTip1.SetToolTip(this.rdQh, resources.GetString("rdQh.ToolTip"));
            this.rdQh.UseVisualStyleBackColor = true;
            // 
            // numHeight
            // 
            this.numHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numHeight.Location = new System.Drawing.Point(327, 181);
            this.numHeight.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            175,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(67, 23);
            this.numHeight.TabIndex = 5;
            this.numHeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // numWidth
            // 
            this.numWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numWidth.Location = new System.Drawing.Point(245, 181);
            this.numWidth.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            175,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(67, 23);
            this.numWidth.TabIndex = 4;
            this.numWidth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(318, 212);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 30);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate QR";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtInputText
            // 
            this.txtInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputText.Location = new System.Drawing.Point(59, 248);
            this.txtInputText.MaxLength = 512;
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.Size = new System.Drawing.Size(359, 23);
            this.txtInputText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "QR Text";
            // 
            // menuMainApp
            // 
            this.menuMainApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMainApp.Location = new System.Drawing.Point(5, 0);
            this.menuMainApp.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.menuMainApp.Name = "menuMainApp";
            this.menuMainApp.Size = new System.Drawing.Size(424, 24);
            this.menuMainApp.TabIndex = 2;
            this.menuMainApp.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "F&ile";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(111, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "E&dit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateCNGRandomToolStripMenuItem,
            this.toolStripMenuItem5,
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // generateCNGRandomToolStripMenuItem
            // 
            this.generateCNGRandomToolStripMenuItem.Name = "generateCNGRandomToolStripMenuItem";
            this.generateCNGRandomToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.generateCNGRandomToolStripMenuItem.Text = "&Generate Random Password";
            this.generateCNGRandomToolStripMenuItem.Click += new System.EventHandler(this.generateCNGRandomToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(219, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateTextAndQRToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // generateTextAndQRToolStripMenuItem
            // 
            this.generateTextAndQRToolStripMenuItem.Checked = true;
            this.generateTextAndQRToolStripMenuItem.CheckOnClick = true;
            this.generateTextAndQRToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.generateTextAndQRToolStripMenuItem.Name = "generateTextAndQRToolStripMenuItem";
            this.generateTextAndQRToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.generateTextAndQRToolStripMenuItem.Text = "&GenerateText and QR";
            this.generateTextAndQRToolStripMenuItem.Click += new System.EventHandler(this.generateTextAndQRToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = global::QR_CodeGenerator.Properties.Resources.Settings;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.optionsToolStripMenuItem.Text = "&Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "H&elp";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // saveImgDialog
            // 
            this.saveImgDialog.Filter = "Jpeg Format (*.jpg)|*.jpg|PNG Format (*.png)|*.png";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 306);
            this.Controls.Add(this.grpBoxMainControlls);
            this.Controls.Add(this.menuMainApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMainApp;
            this.MinimumSize = new System.Drawing.Size(450, 345);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuQrImage.ResumeLayout(false);
            this.grpBoxMainControlls.ResumeLayout(false);
            this.grpBoxMainControlls.PerformLayout();
            this.pnlPicBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQR)).EndInit();
            this.grpBoxQuality.ResumeLayout(false);
            this.grpBoxQuality.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.menuMainApp.ResumeLayout(false);
            this.menuMainApp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private ContextMenuStrip menuQrImage;
		private GroupBox grpBoxMainControlls;
		private Button btnGenerate;
		private TextBox txtInputText;
		private Label label1;
		private PictureBox picBoxQR;
		private MenuStrip menuMainApp;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem saveAsToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem1;
		private ToolStripMenuItem exitToolStripMenuItem;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem copyToolStripMenuItem;
		private ToolStripMenuItem cutToolStripMenuItem;
		private ToolStripMenuItem pasteToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem2;
		private ToolStripMenuItem clearToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem;
		private Button btnClear;
		private Label label3;
		private Label label2;
		private GroupBox grpBoxQuality;
		private RadioButton rdQhq;
		private RadioButton rdQm;
		private RadioButton rdQl;
		private RadioButton rdQh;
		private NumericUpDown numHeight;
		private NumericUpDown numWidth;
		private ToolStripMenuItem newToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripSeparator toolStripMenuItem3;
		private Panel pnlPicBox;
        private ToolStripMenuItem saveImageToolStripMenuItem;
        private ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem clearToolStripMenuItem1;
        private SaveFileDialog saveImgDialog;
        private ToolTip toolTip1;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem generateCNGRandomToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem generateTextAndQRToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
    }
}