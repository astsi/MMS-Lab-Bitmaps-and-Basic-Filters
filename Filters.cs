using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _15719_Lab1_MMS
{
    class Filters
    {
        public Filters()
        { }

        public static int Check(int variable, int min, int max)
        {
            if (variable > max)
                variable = max;
            if (variable < min)
                variable = min;
            return variable;
        }



        public static bool ApplyFilters(Bitmap bm, int[] Niz)
        {
            int brightness = Niz[0];
            int contrast = Niz[1];

            brightness = Check(brightness, -255, 255);
            contrast = Check(contrast, -100, 100);

            double con = Convert.ToDouble(contrast);
            con = (100.0 + con) / 100.0;
            con *= con;

            for (int i = 0; i < bm.Width; i++)
                for (int j = 0; j < bm.Height; j++)
                {
                    Color c = bm.GetPixel(i, j);

                    // Brightness filter

                    int r = Check(c.R + brightness, 0, 255);
                    int g = Check(c.G + brightness, 0, 255);
                    int b = Check(c.B + brightness, 0, 255);

                   
                    // Contrast filter

                   double rc = ((r / 255.0 - 0.5) * con + 0.5) * 255.0;
                   double gc = ((g / 255.0 - 0.5) * con + 0.5) * 255.0;
                   double bc = ((b / 255.0 - 0.5) * con + 0.5) * 255.0;

                    r = Check((int)rc, 0, 255);
                    g = Check((int)gc, 0, 255);
                    b = Check((int)bc, 0, 255);

                    bm.SetPixel(i, j, Color.FromArgb(r, g, b));


                }


            return true;
        }
    }
}
