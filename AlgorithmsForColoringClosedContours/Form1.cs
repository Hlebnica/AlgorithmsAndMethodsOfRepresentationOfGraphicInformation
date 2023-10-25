using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmsForColoringClosedContours
{
    public partial class Form1 : Form
    {
        private Bitmap _bitmap;
        private List<PointF> _mainPoints = new List<PointF>
        {
            new PointF(200, 200),
            new PointF(320, 400),
            new PointF(440, 200),
            new PointF(560, 400),
            //new PointF(120, 200),
            //new PointF(360, 200),
        };
        private List<PointF> _currentPoints = new List<PointF>();
        private Color _fillColor = ColorTranslator.FromHtml("#0008FF");

        private int selectedX = -1;
        private int selectedY = -1;

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
                new PointF(200, 200),
                new PointF(320, 400),
                new PointF(440, 200),
                new PointF(560, 400),
                //new PointF(120, 200),
                //new PointF(360, 200),
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
            int startX = selectedX; 
            int startY = selectedY;

            if (!IsPointInPolygon(startX, startY, _currentPoints))
            {
                MessageBox.Show("Выбранная точка не соответствует условиям.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Color targetColor = _bitmap.GetPixel(startX, startY);

            Stack<Point> pixelsToFill = new Stack<Point>();
            pixelsToFill.Push(new Point(startX, startY));

            while (pixelsToFill.Count > 0)
            {
                Point currentPixel = pixelsToFill.Pop();
                int x = currentPixel.X;
                int y = currentPixel.Y;

                if (x >= 0 && x < _bitmap.Width && y >= 0 && y < _bitmap.Height && _bitmap.GetPixel(x, y) == targetColor)
                {
                    _bitmap.SetPixel(x, y, _fillColor);

                    pictureBoxForFigure.Refresh();

                    pixelsToFill.Push(new Point(x + 1, y));
                    pixelsToFill.Push(new Point(x - 1, y));
                    pixelsToFill.Push(new Point(x, y + 1));
                    pixelsToFill.Push(new Point(x, y - 1));
                }
            }
        }

        private void pictureBoxForFigure_MouseClick(object sender, MouseEventArgs e)
        {
            selectedX = e.X;
            selectedY = e.Y;
        }

        private bool IsPointInPolygon(int x, int y, List<PointF> polygon)
        {
            int crossings = 0;
            for (int i = 0; i < polygon.Count; i++)
            {
                PointF p1 = polygon[i];
                PointF p2 = polygon[(i + 1) % polygon.Count];
                if (p1.Y <= y && p2.Y > y || p1.Y > y && p2.Y <= y)
                {
                    float vt = (float)(y - p1.Y) / (p2.Y - p1.Y);
                    if (x < p1.X + vt * (p2.X - p1.X))
                        crossings++;
                }
            }
            return (crossings % 2 == 1);
        }

        private void buttonLineByLineFilling_Click(object sender, EventArgs e)
        {

        }
    }
}
