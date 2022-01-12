using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMS_Lab1_15719
{
    public class Processing
    {
        public Processing()
        { }


        public static bool ConvertToGray(Bitmap bm)
        {
            for (int i = 0; i < bm.Width; i++)
                for (int j = 0; j < bm.Height; j++)
                {
                    Color c1 = bm.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int gray = (byte)(.299 * r1 + .587 * g1 + .114 * b1);
                    r1 = gray;
                    g1 = gray;
                    b1 = gray;
                    bm.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            return true;
        }

        public static void Provera(double d, int min, int max)
        {

        }

        public static bool Brightness (Bitmap bm, int brightness)
        {
            for (int i = 0; i < bm.Width; i++)
                for (int j = 0; j < bm.Height; j++)
                {
                    Color c = bm.GetPixel(i, j);

                    int r = c.R + (byte)brightness;
                    int g = c.G + (byte)brightness;
                    int b = c.B + (byte)brightness;

                    if (r < 0)
                        r = 0;
                    if (r > 255)
                        r = 255;
                    if (g < 0)
                        g = 0;
                    if (g > 255)
                        g = 255;
                    if (b < 0)
                        b = 0;
                    if (b > 255)
                        b = 255;

                    bm.SetPixel(i, j, Color.FromArgb(r, g, b));

                }
            return true;
        }

        public static bool Contrast(Bitmap bm, int brightness)
        {
            double contrast = (100.0 + brightness) / 100.0;
            contrast *= contrast;
            for (int i = 0; i < bm.Width; i++)
                for (int j = 0; j < bm.Height; j++)
                {
                    Color c = bm.GetPixel(i, j);

                   // double r = c.R / 255.0; //fdafajhgfe r = ((r - 0.5)*contrast + 0.5)*255
                                            // r -= 0.5;
                                            //r *= contrast;
                                            //r += 0.5;
                                            //r *= 255;
                    double r = ((c.R/255.0 - 0.5) * contrast + 0.5) * 255.0;
                    double g = c.G / 255.0;
                    g -= 0.5;
                    g *= contrast;
                    g += 0.5;
                    g *= 255.0;
                    double b = c.B / 255.0;
                    b -= 0.5;
                    b *= contrast;
                    b += 0.5;
                    b *= 255;

                    if (r < 0)
                        r = 0;
                    if (r > 255)
                        r = 255;
                    if (g < 0)
                        g = 0;
                    if (g > 255)
                        g = 255;
                    if (b < 0)
                        b = 0;
                    if (b > 255)
                        b = 255;

                    bm.SetPixel(i, j, Color.FromArgb((int)r, (int)g, (int)b));

                }
            return true;
        }

        public static void Gamma(int r, int g, int b)
        {
            byte[] redGamma = new byte[256];
            byte[] greenGamma = new byte[256];
            byte[] blueGamma = new byte[256];
            for (int i=0; i<256; i++)
            {
                redGamma[i] = (byte)Math.Min(255, (int)((255.0 * Math.Pow(i / 255.0, 1.0 /r)) + 0.5));
                greenGamma[i] = (byte)Math.Min(255, (int)((255.0 * Math.Pow(i / 255.0, 1.0 / g)) + 0.5));
                blueGamma[i] = (byte)Math.Min(255, (int)((255.0 * Math.Pow(i / 255.0, 1.0 / b)) + 0.5));
            }

            r = redGamma[r];
            g = greenGamma[g];
            b = blueGamma[b];
        }

        public static bool GammaInUse(Bitmap bm)
        {
            for (int i = 0; i < bm.Width; i++)
                for (int j = 0; j < bm.Height; j++)
                {
                    Color c1 = bm.GetPixel(i, j);
                    int r = c1.R;
                    int g = c1.G;
                    int b = c1.B;
                    Gamma(r, g, b);
                    

                    bm.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            return true;
        }

    }
    
    
}
