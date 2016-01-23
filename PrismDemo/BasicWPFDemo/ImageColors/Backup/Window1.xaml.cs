using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImageColors
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            // Connect btnRed's event handler.
            btnRed.Click += btnRed_Click;
        }

        private const int offset_a = 3;
        private const int offset_r = 2;
        private const int offset_g = 1;
        private const int offset_b = 0;

        // Return the ARGB components of a pixel.
        private void GetPixel(byte[] pixels, int stride, int bytes_per_pixel, int x, int y, ref byte a, ref byte r, ref byte g, ref byte b)
        {
            int offset = y * stride + x * bytes_per_pixel;
            a = pixels[offset + offset_a];
            r = pixels[offset + offset_r];
            g = pixels[offset + offset_g];
            b = pixels[offset + offset_b];
        }

        // Set the ARGB components of a pixel.
        private void SetPixel(byte[] pixels, int stride, int bytes_per_pixel, int x, int y, byte a, byte r, byte g, byte b)
        {
            int offset = y * stride + x * bytes_per_pixel;
            pixels[offset + offset_a] = a;
            pixels[offset + offset_r] = r;
            pixels[offset + offset_g] = g;
            pixels[offset + offset_b] = b;
        }

        // Invert the original image.
        private void btnInvert_Click(object sender, RoutedEventArgs e)
        {
            // Get the bitmap source.
            BitmapSource bms_old = (BitmapSource)imgOld.Source;

            // Get the size in pixels.
            int wid = (int)bms_old.PixelWidth;
            int hgt = (int)bms_old.PixelHeight;

            // Make room for the pixel bytes.
            int bytes_per_pixel = (int)(bms_old.Format.BitsPerPixel / 8);
            int stride = (int)(wid * bytes_per_pixel);
            byte[] pixels_old = new byte[hgt * stride];

            // Get the pixel data.
            try
            {
                bms_old.CopyPixels(pixels_old, stride, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // Make room for the output pixel data.
            byte[] pixels_new = new byte[hgt * stride];

            // Transform the pixel data.
            for (int y = 0; y < hgt; y++)       // For each row...
            {
                for (int x = 0; x < wid; x++)   // For each column...
                {
                    // Get the pixel's old value.
                    byte a = 0, r = 0, g = 0, b = 0;
                    GetPixel(pixels_old, stride, bytes_per_pixel,
                        x, y, ref a, ref r, ref g, ref b);

                    // Invert.
                    r = (byte)(255  - r);
                    g = (byte)(255 - g);
                    b = (byte)(255 - b);
                    SetPixel(pixels_new, stride, bytes_per_pixel,
                        x, y, a, r, g, b);
                }
            }

            pixels_old.CopyTo(pixels_new, 0);
            for (int i=0; i < hgt * stride; i++)
            {
                pixels_new[i] = (byte)(255 - pixels_new[i]);
            }

            // Display the result.
            BitmapSource bms_new = BitmapSource.Create(wid, hgt,
                bms_old.DpiX, bms_old.DpiY, bms_old.Format,
                null, pixels_new, stride);
            imgNew.Source = bms_new;
        }

        // Keep only the red color component.
        private void btnRed_Click(object sender, RoutedEventArgs e)
        {
            CopyColors(true, true, false, false);
        }

        // Keep only the green color component.
        private void btnGreen_Click(object sender, RoutedEventArgs e)
        {
            CopyColors(true, false, true, false);
        }

        // Keep only the blue color component.
        private void btnBlue_Click(object sender, RoutedEventArgs e)
        {
            CopyColors(true, false, false, true);
        }

        // Copy red, green, or blue color components.
        private void CopyColors(bool copy_a, bool copy_r, bool copy_g, bool copy_b)
        {
            // Get the bitmap source.
            BitmapSource bms_old = (BitmapSource)imgOld.Source;

            // Get the size in pixels.
            int wid = (int)bms_old.PixelWidth;
            int hgt = (int)bms_old.PixelHeight;

            // Make room for the pixel bytes.
            int bytes_per_pixel = (int)(bms_old.Format.BitsPerPixel / 8);
            int stride = (int)(wid * bytes_per_pixel);
            byte[] pixels_old = new byte[hgt * stride];

            // Get the pixel data.
            try
            {
                bms_old.CopyPixels(pixels_old, stride, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Make room for the output pixel data.
            byte[] pixels_new = new byte[hgt * stride];

            // Transform the pixel data.
            for (int y = 0; y < hgt; y++)       // For each row...
            {
                for (int x = 0; x < wid; x++)   // For each column...
                {
                    // Get the pixel's old value.
                    byte a = 0, r = 0, g = 0, b = 0;
                    GetPixel(pixels_old, stride, bytes_per_pixel,
                        x, y, ref a, ref r, ref g, ref b);

                    // Save only the selected components.
                    if (!copy_a) a = 0;
                    if (!copy_r) r = 0;
                    if (!copy_g) g = 0;
                    if (!copy_b) b = 0;

                    // Save the result.
                    SetPixel(pixels_new, stride, bytes_per_pixel, x, y, a, r, g, b);
                }
            }

            // Display the result.
            BitmapSource bms_new = BitmapSource.Create(wid, hgt,
                bms_old.DpiX, bms_old.DpiY, bms_old.Format,
                null, pixels_new, stride);
            imgNew.Source = bms_new;
        }

        // Convert to grayscale.
        private void btnGrayscale_Click(object sender, RoutedEventArgs e)
        {
            // Get the bitmap source.
            BitmapSource bms_old = (BitmapSource)imgOld.Source;

            // Get the size in pixels.
            int wid = (int)bms_old.PixelWidth;
            int hgt = (int)bms_old.PixelHeight;

            // Make room for the pixel bytes.
            int bytes_per_pixel = (int)(bms_old.Format.BitsPerPixel / 8);
            int stride = (int)(wid * bytes_per_pixel);
            byte[] pixels_old = new byte[hgt * stride];

            // Get the pixel data.
            try
            {
                bms_old.CopyPixels(pixels_old, stride, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Make room for the output pixel data.
            byte[] pixels_new = new byte[hgt * stride];

            // Transform the pixel data.
            for (int y = 0; y < hgt; y++)       // For each row...
            {
                for (int x = 0; x < wid; x++)   // For each column...
                {
                    // Get the pixel's old value.
                    byte a=0, r=0, g=0, b=0;
                    GetPixel(pixels_old, stride, bytes_per_pixel,
                        x, y, ref a, ref r, ref g, ref b);

                    // Convert to gray scale.
                    byte gray = (byte)(0.3 * r + 0.5 * g + 0.2 * b);
                    SetPixel(pixels_new, stride, bytes_per_pixel, x, y,
                        255, gray, gray, gray);
                }
            }

            // Display the result.
            BitmapSource bms_new = BitmapSource.Create(wid, hgt,
                bms_old.DpiX, bms_old.DpiY, bms_old.Format,
                null, pixels_new, stride);
            imgNew.Source = bms_new;
        }

        // Average the red, green, and blue components.
        private void btnAverage_Click(object sender, RoutedEventArgs e)
        {
            // Get the bitmap source.
            BitmapSource bms_old = (BitmapSource)imgOld.Source;

            // Get the size in pixels.
            int wid = (int)bms_old.PixelWidth;
            int hgt = (int)bms_old.PixelHeight;

            // Make room for the pixel bytes.
            int bytes_per_pixel = (int)(bms_old.Format.BitsPerPixel / 8);
            int stride = (int)(wid * bytes_per_pixel);
            byte[] pixels_old = new byte[hgt * stride];

            // Get the pixel data.
            try
            {
                bms_old.CopyPixels(pixels_old, stride, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Make room for the output pixel data.
            byte[] pixels_new = new byte[hgt * stride];

            // Transform the pixel data.
            for (int y = 0; y < hgt; y++)       // For each row...
            {
                for (int x = 0; x < wid; x++)   // For each column...
                {
                    // Get the pixel's old value.
                    byte a = 0, r = 0, g = 0, b = 0;
                    GetPixel(pixels_old, stride, bytes_per_pixel,
                        x, y, ref a, ref r, ref g, ref b);

                    // Average the components.
                    byte gray = (byte)((r + g + b) / 3);
                    SetPixel(pixels_new, stride, bytes_per_pixel, x, y,
                        255, gray, gray, gray);
                }
            }

            // Display the result.
            BitmapSource bms_new = BitmapSource.Create(wid, hgt,
                bms_old.DpiX, bms_old.DpiY, bms_old.Format,
                null, pixels_new, stride);
            imgNew.Source = bms_new;
        }
    }
}
