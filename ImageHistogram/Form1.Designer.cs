namespace ImageHistogram
{
    partial class Form1
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
            this.btn_img_upload = new System.Windows.Forms.Button();
            this.input_Img_Picture_Box = new System.Windows.Forms.PictureBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox3 = new Emgu.CV.UI.HistogramBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_parallel_excution = new System.Windows.Forms.Button();
            this.histogram_parallel_exe_1 = new Emgu.CV.UI.HistogramBox();
            this.histogram_parallel_exe_2 = new Emgu.CV.UI.HistogramBox();
            this.histogram_parallel_exe_3 = new Emgu.CV.UI.HistogramBox();
            ((System.ComponentModel.ISupportInitialize)(this.input_Img_Picture_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_img_upload
            // 
            this.btn_img_upload.Location = new System.Drawing.Point(21, 254);
            this.btn_img_upload.Name = "btn_img_upload";
            this.btn_img_upload.Size = new System.Drawing.Size(268, 37);
            this.btn_img_upload.TabIndex = 0;
            this.btn_img_upload.Text = "Upload Image";
            this.btn_img_upload.UseVisualStyleBackColor = true;
            this.btn_img_upload.Click += new System.EventHandler(this.btn_img_upload_Click);
            // 
            // input_Img_Picture_Box
            // 
            this.input_Img_Picture_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.input_Img_Picture_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_Img_Picture_Box.Location = new System.Drawing.Point(21, 26);
            this.input_Img_Picture_Box.Name = "input_Img_Picture_Box";
            this.input_Img_Picture_Box.Size = new System.Drawing.Size(268, 209);
            this.input_Img_Picture_Box.TabIndex = 1;
            this.input_Img_Picture_Box.TabStop = false;
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(13, 19);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(187, 141);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox2.Location = new System.Drawing.Point(206, 19);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(212, 141);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // imageBox3
            // 
            this.imageBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox3.Location = new System.Drawing.Point(424, 19);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(200, 141);
            this.imageBox3.TabIndex = 2;
            this.imageBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1072, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show Histogram";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Red Channel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Blue Channel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Green Channel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imageBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.imageBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(309, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 199);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grey Scale of The Uploaded Image";
            // 
            // histogramBox1
            // 
            this.histogramBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histogramBox1.Location = new System.Drawing.Point(12, 349);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(325, 261);
            this.histogramBox1.TabIndex = 6;
            // 
            // histogramBox2
            // 
            this.histogramBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histogramBox2.Location = new System.Drawing.Point(353, 349);
            this.histogramBox2.Name = "histogramBox2";
            this.histogramBox2.Size = new System.Drawing.Size(369, 261);
            this.histogramBox2.TabIndex = 7;
            // 
            // histogramBox3
            // 
            this.histogramBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histogramBox3.Location = new System.Drawing.Point(733, 349);
            this.histogramBox3.Name = "histogramBox3";
            this.histogramBox3.Size = new System.Drawing.Size(344, 261);
            this.histogramBox3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(322, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(418, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "OpenCV Implementation  using EMGU.CV ";
            // 
            // btn_parallel_excution
            // 
            this.btn_parallel_excution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_parallel_excution.Location = new System.Drawing.Point(12, 616);
            this.btn_parallel_excution.Name = "btn_parallel_excution";
            this.btn_parallel_excution.Size = new System.Drawing.Size(1065, 51);
            this.btn_parallel_excution.TabIndex = 10;
            this.btn_parallel_excution.Text = "Show a Parallel Execution Version";
            this.btn_parallel_excution.UseVisualStyleBackColor = true;
            this.btn_parallel_excution.Click += new System.EventHandler(this.btn_parallel_excution_Click);
            // 
            // histogram_parallel_exe_1
            // 
            this.histogram_parallel_exe_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histogram_parallel_exe_1.Location = new System.Drawing.Point(12, 734);
            this.histogram_parallel_exe_1.Name = "histogram_parallel_exe_1";
            this.histogram_parallel_exe_1.Size = new System.Drawing.Size(325, 217);
            this.histogram_parallel_exe_1.TabIndex = 11;
            // 
            // histogram_parallel_exe_2
            // 
            this.histogram_parallel_exe_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histogram_parallel_exe_2.Location = new System.Drawing.Point(374, 734);
            this.histogram_parallel_exe_2.Name = "histogram_parallel_exe_2";
            this.histogram_parallel_exe_2.Size = new System.Drawing.Size(325, 217);
            this.histogram_parallel_exe_2.TabIndex = 12;
            // 
            // histogram_parallel_exe_3
            // 
            this.histogram_parallel_exe_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histogram_parallel_exe_3.Location = new System.Drawing.Point(733, 734);
            this.histogram_parallel_exe_3.Name = "histogram_parallel_exe_3";
            this.histogram_parallel_exe_3.Size = new System.Drawing.Size(325, 217);
            this.histogram_parallel_exe_3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 963);
            this.Controls.Add(this.histogram_parallel_exe_3);
            this.Controls.Add(this.histogram_parallel_exe_2);
            this.Controls.Add(this.histogram_parallel_exe_1);
            this.Controls.Add(this.btn_parallel_excution);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.histogramBox3);
            this.Controls.Add(this.histogramBox2);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.input_Img_Picture_Box);
            this.Controls.Add(this.btn_img_upload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.input_Img_Picture_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_img_upload;
        private System.Windows.Forms.PictureBox input_Img_Picture_Box;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox imageBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private Emgu.CV.UI.HistogramBox histogramBox2;
        private Emgu.CV.UI.HistogramBox histogramBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_parallel_excution;
        private Emgu.CV.UI.HistogramBox histogram_parallel_exe_1;
        private Emgu.CV.UI.HistogramBox histogram_parallel_exe_2;
        private Emgu.CV.UI.HistogramBox histogram_parallel_exe_3;
    }
}

