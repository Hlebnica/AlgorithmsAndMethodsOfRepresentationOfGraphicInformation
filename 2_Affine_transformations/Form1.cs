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
            //MessageBox.Show(Convert.ToString(angle));

            for (int i = 0; i < _currentPoints.Count; i++)
            {
                float newX = (float)(_currentPoints[i].X * Math.Cos(angle) - _currentPoints[i].Y * Math.Sin(angle) - (_currentPoints[0].X * Math.Cos(angle) - _currentPoints[0].Y * Math.Sin(angle)) + _currentPoints[0].X);
                float newY = (float)(_currentPoints[i].X * Math.Sin(angle) + _currentPoints[i].Y * Math.Cos(angle) - (_currentPoints[0].X * Math.Sin(angle) + _currentPoints[0].Y * Math.Cos(angle)) + _currentPoints[0].Y);
                _currentPoints[i] = new PointF(newX, newY);
            }

            DrawFigure();
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

            for (int i = 0; i < _currentPoints.Count; i++)
                _currentPoints[i] = new PointF(_currentPoints[i].X + moveX, _currentPoints[i].Y + moveY);

            DrawFigure();
        }

        // Растяжение/сжатие
        private void buttonScale_Click(object sender, EventArgs e)
        {
            if (textBoxX_Scale.Text == "" || textBoxY_Scale.Text == "") return;
            float scaleX = float.Parse(textBoxX_Scale.Text);
            float scaleY = float.Parse(textBoxY_Scale.Text);

            // Поиск центра фигуры
            PointF center = new PointF(0, 0);
            for (int i = 0; i < _currentPoints.Count; i++)
            {
                center.X += _currentPoints[i].X;
                center.Y += _currentPoints[i].Y;
            }
            center.X /= _currentPoints.Count;
            center.Y /= _currentPoints.Count;

            for (int i = 0; i < _currentPoints.Count; i++)
            {
                // Сдвиг точек относительно центра
                _currentPoints[i] = new PointF(_currentPoints[i].X - center.X, _currentPoints[i].Y - center.Y);
                // Масштабирование
                _currentPoints[i] = new PointF(_currentPoints[i].X * scaleX, _currentPoints[i].Y * scaleY);
                // Возврат точек относительно центра
                _currentPoints[i] = new PointF(_currentPoints[i].X + center.X, _currentPoints[i].Y + center.Y);
            }

            DrawFigure();
        }

    }
}
