using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AlgorithmsForColoringClosedContours
{
    public partial class Form1 : Form
    {
        private Bitmap _bitmap;
        private List<PointF> _mainPoints = new List<PointF>
        {
            new PointF(300, 200),
            new PointF(360, 300),
            new PointF(420, 200),
            new PointF(480, 300),
            new PointF(360, 300),
            new PointF(480, 300),
        };
        private List<PointF> _currentPoints = new List<PointF>();
        private Color _fillColor = ColorTranslator.FromHtml("#0008FF");

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
            InitializeFigure();
            ClearPictureBox();
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

        private void InitializeFigure()
        {
            _currentPoints = new List<PointF>
            {
                new PointF(300, 200),
                new PointF(360, 300),
                new PointF(420, 200),
                new PointF(480, 300),
                new PointF(360, 300),
                new PointF(480, 300),
            };
        }

        // Выбор цвета
        private void buttonColorPicker_Click(object sender, EventArgs e) 
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _fillColor = colorDialog.Color;
            }
        }

        private void buttonSeedFilling_Click(object sender, EventArgs e)
        {

        }

        private void buttonLineByLineFilling_Click(object sender, EventArgs e)
        {

        }
    }
}
