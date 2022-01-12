using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMS_Lab1_15719
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfile = new OpenFileDialog();
            opfile.Filter = "Image File (*.bmp, *.jpg)|*.bmp;*.jpg";

            if (DialogResult.OK == opfile.ShowDialog())
            {
                this.pictureBox1.Image = new Bitmap(opfile.FileName);

            }

        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pictureBox1.Image);

            Processing.ConvertToGray(copy);

            this.pictureBox2.Image = copy;
        }

        private void btnBrightness_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pictureBox1.Image);
            int value;
            try
            {
                value = Int32.Parse(tbBrightness.Text);
            }
            catch(Exception)
            {
                value = 1;
            }
            

            Processing.Brightness(copy, value);
            this.pictureBox2.Image = copy;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnContrast_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pictureBox1.Image);
            int value;
            try
            {
                value = Int32.Parse(tbBrightness.Text);
            }
            catch (Exception)
            {
                value = 1;
            }


            Processing.Contrast(copy, value);
            this.pictureBox2.Image = copy;
        }

        private void btnGamma_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pictureBox1.Image);

            Processing.GammaInUse(copy);

            this.pictureBox2.Image = copy;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
    }
