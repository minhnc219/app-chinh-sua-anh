namespace ImageProcessing.View.Histogram
{
    partial class FHistogram
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRGBHistogram = new System.Windows.Forms.Button();
            this.btnRedHistogram = new System.Windows.Forms.Button();
            this.btnGreenHistogram = new System.Windows.Forms.Button();
            this.btnBlueHistogram = new System.Windows.Forms.Button();
            this.zgcHistogram = new ZedGraph.ZedGraphControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBlueHistogram);
            this.groupBox1.Controls.Add(this.btnGreenHistogram);
            this.groupBox1.Controls.Add(this.btnRedHistogram);
            this.groupBox1.Controls.Add(this.btnRGBHistogram);
            this.groupBox1.Location = new System.Drawing.Point(710, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(78, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnRGBHistogram
            // 
            this.btnRGBHistogram.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRGBHistogram.Location = new System.Drawing.Point(6, 19);
            this.btnRGBHistogram.Name = "btnRGBHistogram";
            this.btnRGBHistogram.Size = new System.Drawing.Size(66, 36);
            this.btnRGBHistogram.TabIndex = 1;
            this.btnRGBHistogram.Text = "RGB";
            this.btnRGBHistogram.UseVisualStyleBackColor = true;
            this.btnRGBHistogram.Click += new System.EventHandler(this.btnRGBHistogram_Click);
            // 
            // btnRedHistogram
            // 
            this.btnRedHistogram.BackColor = System.Drawing.Color.Red;
            this.btnRedHistogram.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedHistogram.Location = new System.Drawing.Point(6, 83);
            this.btnRedHistogram.Name = "btnRedHistogram";
            this.btnRedHistogram.Size = new System.Drawing.Size(66, 36);
            this.btnRedHistogram.TabIndex = 2;
            this.btnRedHistogram.Text = "R";
            this.btnRedHistogram.UseVisualStyleBackColor = false;
            this.btnRedHistogram.Click += new System.EventHandler(this.btnRedHistogram_Click);
            // 
            // btnGreenHistogram
            // 
            this.btnGreenHistogram.BackColor = System.Drawing.Color.Lime;
            this.btnGreenHistogram.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreenHistogram.Location = new System.Drawing.Point(6, 148);
            this.btnGreenHistogram.Name = "btnGreenHistogram";
            this.btnGreenHistogram.Size = new System.Drawing.Size(66, 36);
            this.btnGreenHistogram.TabIndex = 3;
            this.btnGreenHistogram.Text = "G";
            this.btnGreenHistogram.UseVisualStyleBackColor = false;
            this.btnGreenHistogram.Click += new System.EventHandler(this.btnGreenHistogram_Click);
            // 
            // btnBlueHistogram
            // 
            this.btnBlueHistogram.BackColor = System.Drawing.Color.Blue;
            this.btnBlueHistogram.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlueHistogram.Location = new System.Drawing.Point(6, 215);
            this.btnBlueHistogram.Name = "btnBlueHistogram";
            this.btnBlueHistogram.Size = new System.Drawing.Size(66, 36);
            this.btnBlueHistogram.TabIndex = 4;
            this.btnBlueHistogram.Text = "B";
            this.btnBlueHistogram.UseVisualStyleBackColor = false;
            this.btnBlueHistogram.Click += new System.EventHandler(this.btnBlueHistogram_Click);
            // 
            // zgcHistogram
            // 
            this.zgcHistogram.Location = new System.Drawing.Point(12, 12);
            this.zgcHistogram.Name = "zgcHistogram";
            this.zgcHistogram.ScrollGrace = 0D;
            this.zgcHistogram.ScrollMaxX = 0D;
            this.zgcHistogram.ScrollMaxY = 0D;
            this.zgcHistogram.ScrollMaxY2 = 0D;
            this.zgcHistogram.ScrollMinX = 0D;
            this.zgcHistogram.ScrollMinY = 0D;
            this.zgcHistogram.ScrollMinY2 = 0D;
            this.zgcHistogram.Size = new System.Drawing.Size(692, 426);
            this.zgcHistogram.TabIndex = 1;
            this.zgcHistogram.UseExtendedPrintDialog = true;
            // 
            // FHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zgcHistogram);
            this.Controls.Add(this.groupBox1);
            this.Name = "FHistogram";
            this.Text = "FHistogram";
            this.Load += new System.EventHandler(this.FHistogram_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBlueHistogram;
        private System.Windows.Forms.Button btnGreenHistogram;
        private System.Windows.Forms.Button btnRedHistogram;
        private System.Windows.Forms.Button btnRGBHistogram;
        private ZedGraph.ZedGraphControl zgcHistogram;
    }
}