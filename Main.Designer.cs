namespace KyDienTu
{
    partial class Main
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
            this.btnKyDienTu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnSignedFolder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdBR = new System.Windows.Forms.RadioButton();
            this.rdBL = new System.Windows.Forms.RadioButton();
            this.rdTR = new System.Windows.Forms.RadioButton();
            this.rdTL = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCustom = new System.Windows.Forms.Button();
            this.rdLast = new System.Windows.Forms.RadioButton();
            this.rdFirst = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.TextBox();
            this.lblSignedFolder = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numWidthSignArea = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numHeightSignArea = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdCustom = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidthSignArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeightSignArea)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKyDienTu
            // 
            this.btnKyDienTu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKyDienTu.Location = new System.Drawing.Point(12, 491);
            this.btnKyDienTu.Name = "btnKyDienTu";
            this.btnKyDienTu.Size = new System.Drawing.Size(750, 54);
            this.btnKyDienTu.TabIndex = 0;
            this.btnKyDienTu.Text = "Sign Document";
            this.btnKyDienTu.UseVisualStyleBackColor = true;
            this.btnKyDienTu.Click += new System.EventHandler(this.btnKyDienTu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select file or folder";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(130, 21);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(92, 23);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "Select a file";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Font size:";
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(90, 23);
            this.numSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(43, 20);
            this.numSize.TabIndex = 6;
            this.numSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Font color:";
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.Black;
            this.pnlColor.Location = new System.Drawing.Point(90, 49);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(43, 20);
            this.pnlColor.TabIndex = 9;
            this.pnlColor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlColor_Paint);
            this.pnlColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColor_MouseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(234, 21);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(92, 23);
            this.btnFolder.TabIndex = 10;
            this.btnFolder.Text = "Select a folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnSignedFolder
            // 
            this.btnSignedFolder.Location = new System.Drawing.Point(130, 80);
            this.btnSignedFolder.Name = "btnSignedFolder";
            this.btnSignedFolder.Size = new System.Drawing.Size(92, 23);
            this.btnSignedFolder.TabIndex = 12;
            this.btnSignedFolder.Text = "Signed folder";
            this.btnSignedFolder.UseVisualStyleBackColor = true;
            this.btnSignedFolder.Click += new System.EventHandler(this.btnSignedFolder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(19, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 134);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdBR);
            this.panel1.Controls.Add(this.rdBL);
            this.panel1.Controls.Add(this.rdTR);
            this.panel1.Controls.Add(this.rdTL);
            this.panel1.Location = new System.Drawing.Point(11, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 104);
            this.panel1.TabIndex = 14;
            // 
            // rdBR
            // 
            this.rdBR.AutoSize = true;
            this.rdBR.Location = new System.Drawing.Point(63, 86);
            this.rdBR.Name = "rdBR";
            this.rdBR.Size = new System.Drawing.Size(14, 13);
            this.rdBR.TabIndex = 3;
            this.rdBR.UseVisualStyleBackColor = true;
            // 
            // rdBL
            // 
            this.rdBL.AutoSize = true;
            this.rdBL.Location = new System.Drawing.Point(3, 86);
            this.rdBL.Name = "rdBL";
            this.rdBL.Size = new System.Drawing.Size(14, 13);
            this.rdBL.TabIndex = 2;
            this.rdBL.UseVisualStyleBackColor = true;
            // 
            // rdTR
            // 
            this.rdTR.AutoSize = true;
            this.rdTR.Checked = true;
            this.rdTR.Location = new System.Drawing.Point(63, 3);
            this.rdTR.Name = "rdTR";
            this.rdTR.Size = new System.Drawing.Size(14, 13);
            this.rdTR.TabIndex = 1;
            this.rdTR.TabStop = true;
            this.rdTR.UseVisualStyleBackColor = true;
            // 
            // rdTL
            // 
            this.rdTL.AutoSize = true;
            this.rdTL.Location = new System.Drawing.Point(3, 3);
            this.rdTL.Name = "rdTL";
            this.rdTL.Size = new System.Drawing.Size(14, 13);
            this.rdTL.TabIndex = 0;
            this.rdTL.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdCustom);
            this.groupBox2.Controls.Add(this.btnCustom);
            this.groupBox2.Controls.Add(this.rdLast);
            this.groupBox2.Controls.Add(this.rdFirst);
            this.groupBox2.Location = new System.Drawing.Point(150, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 134);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Signed page";
            // 
            // btnCustom
            // 
            this.btnCustom.Enabled = false;
            this.btnCustom.Location = new System.Drawing.Point(7, 94);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(160, 32);
            this.btnCustom.TabIndex = 2;
            this.btnCustom.Text = "Custom location";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // rdLast
            // 
            this.rdLast.AutoSize = true;
            this.rdLast.Location = new System.Drawing.Point(7, 43);
            this.rdLast.Name = "rdLast";
            this.rdLast.Size = new System.Drawing.Size(72, 17);
            this.rdLast.TabIndex = 1;
            this.rdLast.Text = "Last page";
            this.rdLast.UseVisualStyleBackColor = true;
            this.rdLast.CheckedChanged += new System.EventHandler(this.rdLast_CheckedChanged);
            // 
            // rdFirst
            // 
            this.rdFirst.AutoSize = true;
            this.rdFirst.Checked = true;
            this.rdFirst.Location = new System.Drawing.Point(7, 20);
            this.rdFirst.Name = "rdFirst";
            this.rdFirst.Size = new System.Drawing.Size(71, 17);
            this.rdFirst.TabIndex = 0;
            this.rdFirst.TabStop = true;
            this.rdFirst.Text = "First page";
            this.rdFirst.UseVisualStyleBackColor = true;
            this.rdFirst.CheckedChanged += new System.EventHandler(this.rdFirst_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Select output folder";
            // 
            // lblSelected
            // 
            this.lblSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelected.Location = new System.Drawing.Point(19, 52);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.ReadOnly = true;
            this.lblSelected.Size = new System.Drawing.Size(712, 20);
            this.lblSelected.TabIndex = 18;
            // 
            // lblSignedFolder
            // 
            this.lblSignedFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSignedFolder.Location = new System.Drawing.Point(19, 109);
            this.lblSignedFolder.Name = "lblSignedFolder";
            this.lblSignedFolder.ReadOnly = true;
            this.lblSignedFolder.Size = new System.Drawing.Size(712, 20);
            this.lblSignedFolder.TabIndex = 19;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblSignedFolder);
            this.groupBox3.Controls.Add(this.btnSelectFile);
            this.groupBox3.Controls.Add(this.lblSelected);
            this.groupBox3.Controls.Add(this.btnFolder);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnSignedFolder);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(750, 144);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "In-Out Configuration";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.numHeightSignArea);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.numWidthSignArea);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.numSize);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.pnlColor);
            this.groupBox4.Location = new System.Drawing.Point(12, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(750, 323);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Appearence Configuation";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtEmail);
            this.groupBox5.Controls.Add(this.txtDate);
            this.groupBox5.Controls.Add(this.txtName);
            this.groupBox5.Controls.Add(this.chkEmail);
            this.groupBox5.Controls.Add(this.chkDate);
            this.groupBox5.Controls.Add(this.chkName);
            this.groupBox5.Location = new System.Drawing.Point(150, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(180, 104);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Display field";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(67, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "Email:    ";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(67, 46);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 4;
            this.txtDate.Text = "Ngày:     ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Ký bởi:   ";
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(6, 74);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(51, 17);
            this.chkEmail.TabIndex = 2;
            this.chkEmail.Text = "Email";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Checked = true;
            this.chkDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDate.Location = new System.Drawing.Point(7, 48);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(49, 17);
            this.chkDate.TabIndex = 1;
            this.chkDate.Text = "Date";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // chkName
            // 
            this.chkName.AutoSize = true;
            this.chkName.Checked = true;
            this.chkName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkName.Location = new System.Drawing.Point(7, 23);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(54, 17);
            this.chkName.TabIndex = 0;
            this.chkName.Text = "Name";
            this.chkName.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Width";
            // 
            // numWidthSignArea
            // 
            this.numWidthSignArea.Location = new System.Drawing.Point(90, 75);
            this.numWidthSignArea.Maximum = new decimal(new int[] {
            390,
            0,
            0,
            0});
            this.numWidthSignArea.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidthSignArea.Name = "numWidthSignArea";
            this.numWidthSignArea.Size = new System.Drawing.Size(43, 20);
            this.numWidthSignArea.TabIndex = 19;
            this.numWidthSignArea.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numWidthSignArea.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Height";
            // 
            // numHeightSignArea
            // 
            this.numHeightSignArea.Location = new System.Drawing.Point(90, 101);
            this.numHeightSignArea.Maximum = new decimal(new int[] {
            390,
            0,
            0,
            0});
            this.numHeightSignArea.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeightSignArea.Name = "numHeightSignArea";
            this.numHeightSignArea.Size = new System.Drawing.Size(43, 20);
            this.numHeightSignArea.TabIndex = 21;
            this.numHeightSignArea.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numHeightSignArea.ValueChanged += new System.EventHandler(this.numHeightSignArea_ValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(220, 130);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 30);
            this.button1.TabIndex = 25;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 254);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(345, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 285);
            this.panel3.TabIndex = 27;
            // 
            // rdCustom
            // 
            this.rdCustom.AutoSize = true;
            this.rdCustom.Enabled = false;
            this.rdCustom.Location = new System.Drawing.Point(7, 66);
            this.rdCustom.Name = "rdCustom";
            this.rdCustom.Size = new System.Drawing.Size(60, 17);
            this.rdCustom.TabIndex = 3;
            this.rdCustom.Text = "Custom";
            this.rdCustom.UseVisualStyleBackColor = true;
            this.rdCustom.CheckedChanged += new System.EventHandler(this.rdCustom_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 557);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnKyDienTu);
            this.Name = "Main";
            this.Text = "PDF Digitally Signed";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidthSignArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeightSignArea)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKyDienTu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnSignedFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdBR;
        private System.Windows.Forms.RadioButton rdBL;
        private System.Windows.Forms.RadioButton rdTR;
        private System.Windows.Forms.RadioButton rdTL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdLast;
        private System.Windows.Forms.RadioButton rdFirst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lblSelected;
        private System.Windows.Forms.TextBox lblSignedFolder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.CheckBox chkName;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numHeightSignArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numWidthSignArea;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdCustom;
    }
}

