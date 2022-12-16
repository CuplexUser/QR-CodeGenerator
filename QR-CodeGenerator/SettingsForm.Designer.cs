namespace QR_CodeGenerator
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.grpBoxMain = new System.Windows.Forms.GroupBox();
            this.chkBoxGenerateQR = new System.Windows.Forms.CheckBox();
            this.flowPanelRandomDataType = new System.Windows.Forms.FlowLayoutPanel();
            this.rdHex = new System.Windows.Forms.RadioButton();
            this.rdPassword = new System.Windows.Forms.RadioButton();
            this.rdAlphanumeric = new System.Windows.Forms.RadioButton();
            this.rdNumeric = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.numericStringGenLength = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.notifyIconDefinePasswordChars = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpBoxMain.SuspendLayout();
            this.flowPanelRandomDataType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericStringGenLength)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxMain
            // 
            this.grpBoxMain.Controls.Add(this.chkBoxGenerateQR);
            this.grpBoxMain.Controls.Add(this.flowPanelRandomDataType);
            this.grpBoxMain.Controls.Add(this.btnOk);
            this.grpBoxMain.Controls.Add(this.numericStringGenLength);
            this.grpBoxMain.Controls.Add(this.label2);
            this.grpBoxMain.Controls.Add(this.btnCancel);
            this.grpBoxMain.Controls.Add(this.label1);
            this.grpBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxMain.Location = new System.Drawing.Point(5, 4);
            this.grpBoxMain.Name = "grpBoxMain";
            this.grpBoxMain.Size = new System.Drawing.Size(274, 202);
            this.grpBoxMain.TabIndex = 0;
            this.grpBoxMain.TabStop = false;
            this.grpBoxMain.Text = "Settings";
            // 
            // chkBoxGenerateQR
            // 
            this.chkBoxGenerateQR.AutoSize = true;
            this.chkBoxGenerateQR.Checked = true;
            this.chkBoxGenerateQR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxGenerateQR.Location = new System.Drawing.Point(7, 99);
            this.chkBoxGenerateQR.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chkBoxGenerateQR.Name = "chkBoxGenerateQR";
            this.chkBoxGenerateQR.Size = new System.Drawing.Size(174, 19);
            this.chkBoxGenerateQR.TabIndex = 1;
            this.chkBoxGenerateQR.Text = "Generate QR Code after Text";
            this.chkBoxGenerateQR.UseVisualStyleBackColor = true;
            // 
            // flowPanelRandomDataType
            // 
            this.flowPanelRandomDataType.Controls.Add(this.rdHex);
            this.flowPanelRandomDataType.Controls.Add(this.rdPassword);
            this.flowPanelRandomDataType.Controls.Add(this.rdAlphanumeric);
            this.flowPanelRandomDataType.Controls.Add(this.rdNumeric);
            this.flowPanelRandomDataType.Location = new System.Drawing.Point(7, 37);
            this.flowPanelRandomDataType.Name = "flowPanelRandomDataType";
            this.flowPanelRandomDataType.Size = new System.Drawing.Size(261, 52);
            this.flowPanelRandomDataType.TabIndex = 0;
            // 
            // rdHex
            // 
            this.rdHex.AutoSize = true;
            this.rdHex.Location = new System.Drawing.Point(3, 3);
            this.rdHex.Name = "rdHex";
            this.rdHex.Size = new System.Drawing.Size(94, 19);
            this.rdHex.TabIndex = 5;
            this.rdHex.Tag = "Hex";
            this.rdHex.Text = "Hexadecimal";
            this.rdHex.UseVisualStyleBackColor = true;
            // 
            // rdPassword
            // 
            this.rdPassword.AutoSize = true;
            this.rdPassword.Checked = true;
            this.rdPassword.Location = new System.Drawing.Point(103, 3);
            this.rdPassword.Name = "rdPassword";
            this.rdPassword.Size = new System.Drawing.Size(119, 19);
            this.rdPassword.TabIndex = 6;
            this.rdPassword.TabStop = true;
            this.rdPassword.Tag = "Password";
            this.rdPassword.Text = "Password char set";
            this.rdPassword.UseVisualStyleBackColor = true;
            // 
            // rdAlphanumeric
            // 
            this.rdAlphanumeric.AutoSize = true;
            this.rdAlphanumeric.Location = new System.Drawing.Point(3, 28);
            this.rdAlphanumeric.Name = "rdAlphanumeric";
            this.rdAlphanumeric.Size = new System.Drawing.Size(100, 19);
            this.rdAlphanumeric.TabIndex = 7;
            this.rdAlphanumeric.Tag = "Alpha";
            this.rdAlphanumeric.Text = "Alphanumeric";
            this.rdAlphanumeric.UseVisualStyleBackColor = true;
            // 
            // rdNumeric
            // 
            this.rdNumeric.AutoSize = true;
            this.rdNumeric.Location = new System.Drawing.Point(109, 28);
            this.rdNumeric.Name = "rdNumeric";
            this.rdNumeric.Size = new System.Drawing.Size(71, 19);
            this.rdNumeric.TabIndex = 8;
            this.rdNumeric.Tag = "Numeric";
            this.rdNumeric.Text = "Numeric";
            this.rdNumeric.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(110, 166);
            this.btnOk.Margin = new System.Windows.Forms.Padding(5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 28);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // numericStringGenLength
            // 
            this.numericStringGenLength.Location = new System.Drawing.Point(193, 126);
            this.numericStringGenLength.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numericStringGenLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericStringGenLength.Name = "numericStringGenLength";
            this.numericStringGenLength.Size = new System.Drawing.Size(57, 23);
            this.numericStringGenLength.TabIndex = 2;
            this.numericStringGenLength.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type of Random text generated";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(193, 166);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generated Random text length";
            // 
            // notifyIconDefinePasswordChars
            // 
            this.notifyIconDefinePasswordChars.Text = "The Password character pool is {0}";
            this.notifyIconDefinePasswordChars.Visible = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.grpBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(5, 4, 5, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Random generation options";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.grpBoxMain.ResumeLayout(false);
            this.grpBoxMain.PerformLayout();
            this.flowPanelRandomDataType.ResumeLayout(false);
            this.flowPanelRandomDataType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericStringGenLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpBoxMain;
        private Button btnCancel;
        private Label label1;
        private NumericUpDown numericStringGenLength;
        private FolderBrowserDialog folderBrowserDialog1;
        private CheckBox chkBoxGenerateQR;
        private FlowLayoutPanel flowPanelRandomDataType;
        private RadioButton rdHex;
        private RadioButton rdPassword;
        private RadioButton rdAlphanumeric;
        private RadioButton rdNumeric;
        private Button btnOk;
        private Label label2;
        private NotifyIcon notifyIconDefinePasswordChars;
    }
}