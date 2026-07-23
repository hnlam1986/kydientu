namespace KyDienTu
{
    partial class Custom
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
            this.thumnailPDF = new System.Windows.Forms.FlowLayoutPanel();
            this.picView = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRect = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlRect.SuspendLayout();
            this.SuspendLayout();
            // 
            // thumnailPDF
            // 
            this.thumnailPDF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thumnailPDF.Dock = System.Windows.Forms.DockStyle.Left;
            this.thumnailPDF.Location = new System.Drawing.Point(0, 0);
            this.thumnailPDF.Name = "thumnailPDF";
            this.thumnailPDF.Size = new System.Drawing.Size(200, 574);
            this.thumnailPDF.TabIndex = 0;
            // 
            // picView
            // 
            this.picView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picView.Location = new System.Drawing.Point(0, 0);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(425, 516);
            this.picView.TabIndex = 1;
            this.picView.TabStop = false;
            this.picView.Visible = false;
            this.picView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picView_MouseDown);
            this.picView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picView_MouseMove);
            this.picView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picView_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pnlRect);
            this.panel1.Controls.Add(this.picView);
            this.panel1.Location = new System.Drawing.Point(206, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 574);
            this.panel1.TabIndex = 2;
            // 
            // pnlRect
            // 
            this.pnlRect.BackColor = System.Drawing.Color.Transparent;
            this.pnlRect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlRect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRect.Controls.Add(this.label1);
            this.pnlRect.Location = new System.Drawing.Point(252, 417);
            this.pnlRect.Name = "pnlRect";
            this.pnlRect.Size = new System.Drawing.Size(106, 34);
            this.pnlRect.TabIndex = 2;
            this.pnlRect.Visible = false;
            this.pnlRect.Click += new System.EventHandler(this.pnlRect_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click on for signing";
            this.label1.Click += new System.EventHandler(this.pnlRect_Click);
            // 
            // Custom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.thumnailPDF);
            this.Name = "Custom";
            this.Text = "Custom";
            this.Load += new System.EventHandler(this.Custom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlRect.ResumeLayout(false);
            this.pnlRect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel thumnailPDF;
        private System.Windows.Forms.PictureBox picView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlRect;
        private System.Windows.Forms.Label label1;
    }
}