using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateFractal_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxIterations.Text, out int maxIterations))
            {
                double zoom = 150;
                double offsetX = pictureBox.Width / 2.0 + 100;
                double offsetY = pictureBox.Height / 2.0;

                Bitmap fractalBitmap = GenerateFractal(maxIterations, zoom, offsetX, offsetY);
                pictureBox.Image = fractalBitmap;
            }
            else
            {
                MessageBox.Show("Введите корректное число для уровней вложенности.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Bitmap GenerateFractal(int maxIterations, double zoom, double offsetX, double offsetY)
        {
            int width = pictureBox.Width;    
            int height = pictureBox.Height;  

            Bitmap bitmap = new Bitmap(width, height); 

            // Проход по каждому пикселю изображения
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // Преобразование координат пикселя в координаты фрактала с учетом масштабирования и сдвига
                    double zx = (x - offsetX) / zoom;
                    double zy = (y - offsetY) / zoom;

                    double cx = zx;
                    double cy = zy;

                    int iteration = 0;

                    // Вычисление фрактала с использованием итераций
                    while (iteration < maxIterations)
                    {
                        // Фрактал Мандельброта
                        //         2
                        // Z    = Z   + C
                        //  n+1    n
                        double newZx = zx * zx - zy * zy + cx;
                        double newZy = 2 * zx * zy + cy;

                        zx = newZx;
                        zy = newZy;

                        // Если выходит за пределы установленной границы, завершение итерации
                        if (zx * zx + zy * zy > 4)
                            break;

                        iteration++;
                    }

                    // Определение цвета пикселя на основе числа итераций
                    Color color = GetColor(iteration, maxIterations);

                    // Установка цвета пикселя в изображении
                    bitmap.SetPixel(x, y, color);
                }
            }

            return bitmap;
        }

        // Метод GetColor возвращает цвет в зависимости от числа итераций
        private Color GetColor(int iteration, int maxIterations)
        {
            if (iteration == maxIterations)
            {
                return Color.Black;  // Возвращаем черный цвет для точек, не выходящих за границы фрактала
            }
            else
            {
                // Вычисление цвета в зависимости от числа итераций
                double hue = (double)iteration / maxIterations * 360.0;

                // Цвет, зависящий от числа итераций
                return Color.FromArgb(255, (int)hue % 256, 0, 0);
            }
        }


    }
}
