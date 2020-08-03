namespace ImageProcessing.View.ImageProc.ColorProc
{
    partial class FEffect
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
            this.label2 = new System.Windows.Forms.Label();
            this.pbNagativeEffect = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbBAndWEffect = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNagativeEffect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBAndWEffect)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Âm bản";
            // 
            // pbNagativeEffect
            // 
            this.pbNagativeEffect.Location = new System.Drawing.Point(329, 45);
            this.pbNagativeEffect.Name = "pbNagativeEffect";
            this.pbNagativeEffect.Size = new System.Drawing.Size(270, 173);
            this.pbNagativeEffect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNagativeEffect.TabIndex = 6;
            this.pbNagativeEffect.TabStop = false;
            this.pbNagativeEffect.Click += new System.EventHandler(this.pbNagativeEffect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đen trắng";
            // 
            // pbBAndWEffect
            // 
            this.pbBAndWEffect.Location = new System.Drawing.Point(12, 45);
            this.pbBAndWEffect.Name = "pbBAndWEffect";
            this.pbBAndWEffect.Size = new System.Drawing.Size(270, 173);
            this.pbBAndWEffect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBAndWEffect.TabIndex = 4;
            this.pbBAndWEffect.TabStop = false;
            this.pbBAndWEffect.Click += new System.EventHandler(this.pbBAndWEffect_Click);
            // 
            // FEffect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbNagativeEffect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbBAndWEffect);
            this.Name = "FEffect";
            this.Text = "FEffect";
            this.Load += new System.EventHandler(this.FEffect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNagativeEffect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBAndWEffect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbNagativeEffect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbBAndWEffect;
    }
}