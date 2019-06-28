using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using Emgu.Util;
using System.Threading;
using System.Runtime.InteropServices;



namespace ImageHistogram
{
    public partial class Form1 : Form
    {
       Image<Bgr,byte> _input;
        Image<Gray, byte> R;
        Image<Gray, byte> G;
        Image<Gray, byte> B;
        OpenFileDialog opf;

        public Form1()
        {
            InitializeComponent();

        }

        private void btn_img_upload_Click(object sender, EventArgs e)
        {
             opf = new OpenFileDialog();
            // chose the images type
          opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                // get the image returned by OpenFileDialog 

                Image<Bgr, byte> _input = new Image<Bgr, byte>(opf.FileName);

               //    input_Img_Picture_Box.Image = Image.FromFile(opf.FileName);
                //  input_Img_Picture_Box.BackgroundImageLayout = ImageLayout.None
                input_Img_Picture_Box.Image = _input.Bitmap;

                //The Red Green Blue chanel of an Image
                if (_input!=null) {
                R = _input[0];
                G = _input[1];
                B = _input[2];
                imageBox1.Image = R;
                imageBox2.Image = G;
                imageBox3.Image = B;
                }


            }
        }

    
        private void button1_Click(object sender, EventArgs e)
        {

            redChanelHistogram();
            greenChanelHistogram();
            blueChanelHistogram();


        }

        //Method for calculating Red Channel Histrogram of input image in the Histogram box
        private void redChanelHistogram() {

            histogramBox1.ClearHistogram();
            histogramBox1.GenerateHistograms(R, 256);
            histogramBox1.Refresh();




        }

        //Method for calculating Green Channel Histrogram of input image in the Histogram box
        private void greenChanelHistogram()
        {

            histogramBox2.ClearHistogram();
            histogramBox2.GenerateHistograms(G, 256);
            histogramBox2.Refresh();




        }

        //Method for calculating Green Channel Histrogram of input image in the Histogram box
        private  void blueChanelHistogram()
        {



            histogramBox3.ClearHistogram();
            histogramBox3.GenerateHistograms(B, 256);
            histogramBox3.Refresh();



        }

        private void btn_parallel_excution_Click(object sender, EventArgs e)
        {
            var t1 = new Task(() => Dowork(1, 1000));
            t1.Start();

         var t2 = new Task(() => Dowork(2, 1000));
           t2.Start();
            var t3 = new Task(() => Dowork(3, 1000));
          t3.Start();


        }

        private void Dowork(int id, int sleep)
        {
            

            if (id == 1)
            {
               histogram_parallel_exe_1.ClearHistogram();
                histogram_parallel_exe_1.GenerateHistograms(R, 256);
                histogram_parallel_exe_1.Refresh();
                Thread.Sleep(sleep);
            }

           else if (id == 2)
            {

                histogram_parallel_exe_2.ClearHistogram();
                histogram_parallel_exe_2.GenerateHistograms(G, 256);
                histogram_parallel_exe_2.Refresh();
                Thread.Sleep(sleep);
            }

           else if (id == 2)
            {

                histogram_parallel_exe_3.ClearHistogram();
                histogram_parallel_exe_3.GenerateHistograms(B, 256);
                histogram_parallel_exe_3.Refresh();
                Thread.Sleep(sleep);
            }



        }

     

            private void Form1_Load(object sender, EventArgs e)
        {
        
        }


    }
}
