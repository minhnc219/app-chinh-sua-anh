namespace ImageProcessing.View.ImageProc
{
    partial class FBasic
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
            this.pbBasic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBrightness = new System.Windows.Forms.TrackBar();
            this.tbContrast = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmBasicProc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBasic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBasic
            // 
            this.pbBasic.Location = new System.Drawing.Point(12, 12);
            this.pbBasic.Name = "pbBasic";
            this.pbBasic.Size = new System.Drawing.Size(443, 298);
            this.pbBasic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBasic.TabIndex = 5;
            this.pbBasic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Độ sáng";
            // 
            // tbBrightness
            // 
            this.tbBrightness.Location = new System.Drawing.Point(118, 327);
            this.tbBrightness.Maximum = 255;
            this.tbBrightness.Minimum = -255;
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(337, 45);
            this.tbBrightness.TabIndex = 7;
            this.tbBrightness.Scroll += new System.EventHandler(this.tbBrightness_Scroll);
            // 
            // tbContrast
            // 
            this.tbContrast.Location = new System.Drawing.Point(118, 378);
            this.tbContrast.Maximum = 100;
            this.tbContrast.Minimum = -100;
            this.tbContrast.Name = "tbContrast";
            this.tbContrast.Size = new System.Drawing.Size(337, 45);
            this.tbContrast.TabIndex = 6;
            this.tbContrast.Scroll += new System.EventHandler(this.tbContrast_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Độ tương phản";
            // 
            // btnConfirmBasicProc
            // 
            this.btnConfirmBasicProc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmBasicProc.Location = new System.Drawing.Point(360, 429);
            this.btnConfirmBasicProc.Name = "btnConfirmBasicProc";
            this.btnConfirmBasicProc.Size = new System.Drawing.Size(95, 44);
            this.btnConfirmBasicProc.TabIndex = 10;
            this.btnConfirmBasicProc.Text = "Xác nhận";
            this.btnConfirmBasicProc.UseVisualStyleBackColor = true;
            this.btnConfirmBasicProc.Click += new System.EventHandler(this.btnConfirmBasicProc_Click);
            // 
            // FBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 485);
            this.Controls.Add(this.btnConfirmBasicProc);
            this.Controls.Add(this.tbContrast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBrightness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbBasic);
            this.Name = "FBasic";
            this.Text = "FBasic";
            this.Load += new System.EventHandler(this.FBasic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBasic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBasic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbBrightness;
        private System.Windows.Forms.TrackBar tbContrast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmBasicProc;
    }
}