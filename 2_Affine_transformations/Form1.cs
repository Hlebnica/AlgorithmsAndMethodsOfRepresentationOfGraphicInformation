using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _2_Affine_transformations
{
    public partial class Form1 : Form
    {
        private Bitmap _bitmap;
        private List<PointF> _mainPoints = new List<PointF>
        {
            new PointF(0, 0),
            new PointF(60, 100),
            new PointF(120, 0),
            new PointF(180, 100),
            new PointF(60, 100),
            new PointF(180, 100),
        };
        private List<PointF> _currentPoints = new List<PointF>();

        public Form1()
        {
            InitializeComponent();
            _bitmap = new Bitmap(pictureBoxForFigure.Width, pictureBoxForFigure.Height);
            pictureBoxForFigure.Image = _bitmap;
            pictureBoxForFigure.BackgroundImageLayout = ImageLayout.None;
            _currentPoints = _mainPoints;
            ClearPictureBox();
        }

        private void buttonCreateFigure_Click(object sender, EventArgs e)
        {
            DrawFigure();
        }

        // Отрисовка фигуры
        private void DrawFigure()
        {
            ClearPictureBox();

            using (Graphics graphics = Graphics.FromImage(_bitmap))
            {
                Pen pen = new Pen(Color.Black);

                // Соединение точек
                for (int i = 0; i < _currentPoints.Count; i++)
                {
                    graphics.DrawLine(pen, _currentPoints[i], _currentPoints[(i + 1) % _currentPoints.Count]);
                }

                pictureBoxForFigure.Invalidate();
            }
        }

        // Очистка pictureBox
        private void ClearPictureBox()
        {
            using (Graphics graphics = Graphics.FromImage(_bitmap))
            {
                graphics.Clear(Color.White);
            }
        }

        // Поворот
        private void buttonRotate_Click(object sender, EventArgs e)
        {
            if (textBox_Rotate.Text == "") return;
            float angle = ConvertToRadians(float.Parse(textBox_Rotate.Text));

            List<PointF> tempPoints = new List<PointF>(_currentPoints);

            for (int i = 0; i < tempPoints.Count; i++)
            {
                float newX = (float)(tempPoints[i].X * Math.Cos(angle) - tempPoints[i].Y * Math.Sin(angle) - (tempPoints[0].X * Math.Cos(angle) - tempPoints[0].Y * Math.Sin(angle)) + tempPoints[0].X);
                float newY = (float)(tempPoints[i].X * Math.Sin(angle) + tempPoints[i].Y * Math.Cos(angle) - (tempPoints[0].X * Math.Sin(angle) + tempPoints[0].Y * Math.Cos(angle)) + tempPoints[0].Y);
                tempPoints[i] = new PointF(newX, newY);
            }

            if (!IsFigureOutOfBound(tempPoints))
            {
                _currentPoints = tempPoints;
                DrawFigure();
            }
            else
            {
                MessageBox.Show("Фигура выходит за границы");
            }
        }



        private float ConvertToRadians(double degrees)
        {
            return (float)(degrees * (Math.PI / 180));
        }

        // Перемещение
        private void buttonMoveFigure_Click(object sender, EventArgs e)
        {
            if (textBoxX_Move.Text == "" || textBoxY_Move.Text == "") return;
            int moveX = int.Parse(textBoxX_Move.Text);
            int moveY = int.Parse(textBoxY_Move.Text);

            List<PointF> tempPoints = new List<PointF>(_currentPoints);

            for (int i = 0; i < tempPoints.Count; i++)
            {
                tempPoints[i] = new PointF(tempPoints[i].X + moveX, tempPoints[i].Y + moveY);
            }

            if (!IsFigureOutOfBound(tempPoints))
            {
                _currentPoints = tempPoints;
                DrawFigure();
            }
            else
            {
                MessageBox.Show("Фигура выходит за границы");
            }
        }


        // Растяжение/сжатие
        private void buttonScale_Click(object sender, EventArgs e)
        {
            if (textBoxX_Scale.Text == "" || textBoxY_Scale.Text == "") return;
            float scaleX = float.Parse(textBoxX_Scale.Text);
            float scaleY = float.Parse(textBoxY_Scale.Text);

            List<PointF> tempPoints = new List<PointF>(_currentPoints);

            // Найдите центр фигуры
            PointF center = new PointF(0, 0);
            for (int i = 0; i < tempPoints.Count; i++)
            {
                center.X += tempPoints[i].X;
                center.Y += tempPoints[i].Y;
            }
            center.X /= tempPoints.Count;
            center.Y /= tempPoints.Count;

            // Выполните масштабирование на временных точках
            for (int i = 0; i < tempPoints.Count; i++)
            {
                // Сдвиг точек относительно центра
                tempPoints[i] = new PointF(tempPoints[i].X - center.X, tempPoints[i].Y - center.Y);
                // Масштабирование
                tempPoints[i] = new PointF(tempPoints[i].X * scaleX, tempPoints[i].Y * scaleY);
                // Возврат точек относительно центра
                tempPoints[i] = new PointF(tempPoints[i].X + center.X, tempPoints[i].Y + center.Y);
            }

            if (!IsFigureOutOfBound(tempPoints))
            {
                _currentPoints = tempPoints;
                DrawFigure();
            }
            else
            {
                MessageBox.Show("Фигура выходит за границы");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_Rotate.Text = "0";
            textBoxX_Move.Text = "0";
            textBoxY_Move.Text = "0";
            textBoxX_Scale.Text = "1";
            textBoxY_Scale.Text = "1";
        }

        private bool IsFigureOutOfBound(List<PointF> points)
        {
            foreach (var point in points)
            {
                if (point.X < 0 || point.X > pictureBoxForFigure.Width || point.Y < 0 || point.Y > pictureBoxForFigure.Height)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
