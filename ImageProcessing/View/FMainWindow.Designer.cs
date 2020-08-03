namespace ImageProcessing.View
{
    partial class FMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMainWindow));
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLoadImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsSaveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsImageProcessing = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBasicProc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsColorProc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsColorFilterProc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEffectProc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSizeProc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTxtRate = new System.Windows.Forms.ToolStripTextBox();
            this.tsRotationProc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRotstion90 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRotation270 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFlipping = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCropProc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsInsertProc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsInsertText = new System.Windows.Forms.ToolStripMenuItem();
            this.tsInsertImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsInsertShape = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHistogram = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(0, 24);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(800, 426);
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOption,
            this.tsImageProcessing,
            this.tsHistogram});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsOption
            // 
            this.tsOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLoadImage,
            this.toolStripSeparator,
            this.tsSaveImage,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.tsOption.Name = "tsOption";
            this.tsOption.Size = new System.Drawing.Size(69, 20);
            this.tsOption.Text = "Tùy chọn";
            // 
            // tsLoadImage
            // 
            this.tsLoadImage.Image = ((System.Drawing.Image)(resources.GetObject("tsLoadImage.Image")));
            this.tsLoadImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLoadImage.Name = "tsLoadImage";
            this.tsLoadImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsLoadImage.Size = new System.Drawing.Size(180, 22);
            this.tsLoadImage.Text = "Chọn ảnh";
            this.tsLoadImage.Click += new System.EventHandler(this.tsLoadImage_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(166, 6);
            // 
            // tsSaveImage
            // 
            this.tsSaveImage.Image = ((System.Drawing.Image)(resources.GetObject("tsSaveImage.Image")));
            this.tsSaveImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSaveImage.Name = "tsSaveImage";
            this.tsSaveImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsSaveImage.Size = new System.Drawing.Size(169, 22);
            this.tsSaveImage.Text = "Lưu ";
            this.tsSaveImage.Click += new System.EventHandler(this.tsSaveImage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
            // 
            // tsImageProcessing
            // 
            this.tsImageProcessing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBasicProc,
            this.tsColorProc,
            this.tsSizeProc,
            this.tsRotationProc,
            this.tsCropProc,
            this.tsInsertProc});
            this.tsImageProcessing.Name = "tsImageProcessing";
            this.tsImageProcessing.Size = new System.Drawing.Size(95, 20);
            this.tsImageProcessing.Text = "Chỉnh sửa ảnh";
            this.tsImageProcessing.Click += new System.EventHandler(this.tsImageProcessing_Click);
            this.tsImageProcessing.MouseHover += new System.EventHandler(this.tsImageProcessing_MouseHover);
            // 
            // tsBasicProc
            // 
            this.tsBasicProc.Name = "tsBasicProc";
            this.tsBasicProc.Size = new System.Drawing.Size(180, 22);
            this.tsBasicProc.Text = "Cơ bản";
            this.tsBasicProc.Click += new System.EventHandler(this.tsBasicProc_Click);
            // 
            // tsColorProc
            // 
            this.tsColorProc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsColorFilterProc,
            this.tsEffectProc});
            this.tsColorProc.Name = "tsColorProc";
            this.tsColorProc.Size = new System.Drawing.Size(180, 22);
            this.tsColorProc.Text = "Màu";
            // 
            // tsColorFilterProc
            // 
            this.tsColorFilterProc.Name = "tsColorFilterProc";
            this.tsColorFilterProc.Size = new System.Drawing.Size(158, 22);
            this.tsColorFilterProc.Text = "Lọc màu";
            this.tsColorFilterProc.Click += new System.EventHandler(this.tsColorFilterProc_Click);
            // 
            // tsEffectProc
            // 
            this.tsEffectProc.Name = "tsEffectProc";
            this.tsEffectProc.Size = new System.Drawing.Size(158, 22);
            this.tsEffectProc.Text = "Hiệu ứng";
            this.tsEffectProc.Click += new System.EventHandler(this.tsEffectProc_Click);
            // 
            // tsSizeProc
            // 
            this.tsSizeProc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTxtRate});
            this.tsSizeProc.Name = "tsSizeProc";
            this.tsSizeProc.Size = new System.Drawing.Size(180, 22);
            this.tsSizeProc.Text = "Kích thước (%)";
            this.tsSizeProc.DropDownClosed += new System.EventHandler(this.tsSizeProc_DropDownClosed);
            // 
            // tsTxtRate
            // 
            this.tsTxtRate.Name = "tsTxtRate";
            this.tsTxtRate.Size = new System.Drawing.Size(100, 23);
            this.tsTxtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tsTxtRate_KeyPress);
            this.tsTxtRate.TextChanged += new System.EventHandler(this.tsTxtRate_TextChanged);
            // 
            // tsRotationProc
            // 
            this.tsRotationProc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRotstion90,
            this.tsRotation270,
            this.tsFlipping});
            this.tsRotationProc.Name = "tsRotationProc";
            this.tsRotationProc.Size = new System.Drawing.Size(180, 22);
            this.tsRotationProc.Text = "Xoay";
            // 
            // tsRotstion90
            // 
            this.tsRotstion90.Name = "tsRotstion90";
            this.tsRotstion90.Size = new System.Drawing.Size(113, 22);
            this.tsRotstion90.Text = "90";
            this.tsRotstion90.Click += new System.EventHandler(this.tsRotstion90_Click);
            // 
            // tsRotation270
            // 
            this.tsRotation270.Name = "tsRotation270";
            this.tsRotation270.Size = new System.Drawing.Size(113, 22);
            this.tsRotation270.Text = "-90";
            this.tsRotation270.Click += new System.EventHandler(this.tsRotation270_Click);
            // 
            // tsFlipping
            // 
            this.tsFlipping.Name = "tsFlipping";
            this.tsFlipping.Size = new System.Drawing.Size(113, 22);
            this.tsFlipping.Text = "Lật ảnh";
            this.tsFlipping.Click += new System.EventHandler(this.tsFlipping_Click);
            // 
            // tsCropProc
            // 
            this.tsCropProc.Name = "tsCropProc";
            this.tsCropProc.Size = new System.Drawing.Size(180, 22);
            this.tsCropProc.Text = "Cắt hình";
            this.tsCropProc.Click += new System.EventHandler(this.tsCropProc_Click);
            // 
            // tsInsertProc
            // 
            this.tsInsertProc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsInsertText,
            this.tsInsertImage,
            this.tsInsertShape});
            this.tsInsertProc.Name = "tsInsertProc";
            this.tsInsertProc.Size = new System.Drawing.Size(180, 22);
            this.tsInsertProc.Text = "Chèn";
            // 
            // tsInsertText
            // 
            this.tsInsertText.Name = "tsInsertText";
            this.tsInsertText.Size = new System.Drawing.Size(116, 22);
            this.tsInsertText.Text = "Văn bản";
            this.tsInsertText.Click += new System.EventHandler(this.tsInsertText_Click);
            // 
            // tsInsertImage
            // 
            this.tsInsertImage.Name = "tsInsertImage";
            this.tsInsertImage.Size = new System.Drawing.Size(116, 22);
            this.tsInsertImage.Text = "Ảnh";
            this.tsInsertImage.Click += new System.EventHandler(this.tsInsertImage_Click);
            // 
            // tsInsertShape
            // 
            this.tsInsertShape.Name = "tsInsertShape";
            this.tsInsertShape.Size = new System.Drawing.Size(116, 22);
            this.tsInsertShape.Text = "Hình";
            this.tsInsertShape.Click += new System.EventHandler(this.tsInsertShape_Click);
            // 
            // tsHistogram
            // 
            this.tsHistogram.Name = "tsHistogram";
            this.tsHistogram.Size = new System.Drawing.Size(75, 20);
            this.tsHistogram.Text = "Histogram";
            this.tsHistogram.Click += new System.EventHandler(this.tsHistogram_Click);
            // 
            // FMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FMainWindow";
            this.Text = "FMainWindow";
            this.Load += new System.EventHandler(this.FMainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsOption;
        private System.Windows.Forms.ToolStripMenuItem tsLoadImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem tsSaveImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsHistogram;
        private System.Windows.Forms.ToolStripMenuItem tsImageProcessing;
        private System.Windows.Forms.ToolStripMenuItem tsBasicProc;
        private System.Windows.Forms.ToolStripMenuItem tsColorProc;
        private System.Windows.Forms.ToolStripMenuItem tsColorFilterProc;
        private System.Windows.Forms.ToolStripMenuItem tsEffectProc;
        private System.Windows.Forms.ToolStripMenuItem tsSizeProc;
        private System.Windows.Forms.ToolStripTextBox tsTxtRate;
        private System.Windows.Forms.ToolStripMenuItem tsRotationProc;
        private System.Windows.Forms.ToolStripMenuItem tsRotstion90;
        private System.Windows.Forms.ToolStripMenuItem tsRotation270;
        private System.Windows.Forms.ToolStripMenuItem tsFlipping;
        private System.Windows.Forms.ToolStripMenuItem tsCropProc;
        private System.Windows.Forms.ToolStripMenuItem tsInsertProc;
        private System.Windows.Forms.ToolStripMenuItem tsInsertText;
        private System.Windows.Forms.ToolStripMenuItem tsInsertImage;
        private System.Windows.Forms.ToolStripMenuItem tsInsertShape;
    }
}