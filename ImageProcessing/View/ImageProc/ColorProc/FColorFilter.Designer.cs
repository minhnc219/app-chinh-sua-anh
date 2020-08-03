namespace ImageProcessing.View.ImageProc.ColorProc
{
    partial class FColorFilter
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
            this.pbRedColorFilter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbGreenColorFilter = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbBlueColorFilter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedColorFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreenColorFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlueColorFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRedColorFilter
            // 
            this.pbRedColorFilter.Location = new System.Drawing.Point(12, 55);
            this.pbRedColorFilter.Name = "pbRedColorFilter";
            this.pbRedColorFilter.Size = new System.Drawing.Size(270, 173);
            this.pbRedColorFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRedColorFilter.TabIndex = 0;
            this.pbRedColorFilter.TabStop = false;
            this.pbRedColorFilter.Click += new System.EventHandler(this.pbRedColorFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Màu đỏ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Màu lục";
            // 
            // pbGreenColorFilter
            // 
            this.pbGreenColorFilter.Location = new System.Drawing.Point(329, 55);
            this.pbGreenColorFilter.Name = "pbGreenColorFilter";
            this.pbGreenColorFilter.Size = new System.Drawing.Size(270, 173);
            this.pbGreenColorFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGreenColorFilter.TabIndex = 2;
            this.pbGreenColorFilter.TabStop = false;
            this.pbGreenColorFilter.Click += new System.EventHandler(this.pbGreenColorFilter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Màu lam";
            // 
            // pbBlueColorFilter
            // 
            this.pbBlueColorFilter.Location = new System.Drawing.Point(12, 265);
            this.pbBlueColorFilter.Name = "pbBlueColorFilter";
            this.pbBlueColorFilter.Size = new System.Drawing.Size(270, 173);
            this.pbBlueColorFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBlueColorFilter.TabIndex = 4;
            this.pbBlueColorFilter.TabStop = false;
            this.pbBlueColorFilter.Click += new System.EventHandler(this.pbBlueColorFilter_Click);
            // 
            // FColorFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbBlueColorFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbGreenColorFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRedColorFilter);
            this.Name = "FColorFilter";
            this.Text = "FColorFilter";
            this.Load += new System.EventHandler(this.FColorFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRedColorFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGreenColorFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlueColorFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRedColorFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbGreenColorFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbBlueColorFilter;
    }
}