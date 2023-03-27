using System;
using System.Drawing;
using System.Drawing.Imaging;
internal class Program
{
    static void Main()
    {
        Random rng = new Random();
        byte[,,] colors = new byte[3, 1080, 1920];

        for (int color = 0; color < colors.GetLength(0); color++)
        {
            for (int row = 0; row < colors.GetLength(1); row++)
            {
                for (int col = 0; col < colors.GetLength(2); col++)
                {
                    colors[color, row, col] = (byte)rng.Next(0, 255);
                }

            }
        }

        Bitmap bitMapImage = new Bitmap(colors.GetLength(2), colors.GetLength(1), PixelFormat.Format24bppRgb );
        for (int row = 0; row < bitMapImage.Height; row++)
        {
            for (int col = 0; col < bitMapImage.Width; col++)
            {
                bitMapImage.SetPixel(col, row, Color.FromArgb(colors[0, row, col], colors[1, row, col], colors[2, row, col]));
            }
        }
        bitMapImage.Save("test.png");
    }
}

