using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplineDrawingApp
{
    public partial class Form1 : Form
    {
        private List<Point> controlPoints = new List<Point>();
        private int selectedPointIndex = -1;
        private const int pointSize = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            controlPoints.Clear();
            selectedPointIndex = -1; // Сбрасываем выбранную точку при очистке
            pictureBox.Invalidate();
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Проверяем, попал ли пользователь в существующую точку для перемещения или удаления
            for (int i = controlPoints.Count - 1; i >= 0; i--)
            {
                Rectangle pointRect = new Rectangle(controlPoints[i].X - pointSize / 2, controlPoints[i].Y - pointSize / 2, pointSize, pointSize);

                if (pointRect.Contains(e.Location))
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        // Удаление точки при правом клике
                        controlPoints.RemoveAt(i);
                        selectedPointIndex = -1;
                    }
                    else
                    {
                        // Запоминаем индекс выбранной точки для перемещения
                        selectedPointIndex = i;
                    }

                    pictureBox.Invalidate();
                    return;
                }
            }

            // Если пользователь не выбрал существующую точку, добавляем новую
            controlPoints.Add(e.Location);
            selectedPointIndex = controlPoints.Count - 1;
            pictureBox.Invalidate();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            DrawSpline(e.Graphics);
            DrawControlPoints(e.Graphics);
        }

        private void DrawControlPoints(Graphics g)
        {
            foreach (var point in controlPoints)
            {
                g.FillEllipse(Brushes.Blue, point.X - pointSize / 2, point.Y - pointSize / 2, pointSize, pointSize);
            }
        }

        private void DrawSpline(Graphics g)
        {
            if (controlPoints.Count < 2)
                return;

            // Рисуем контрольные точки
            foreach (var point in controlPoints)
            {
                g.FillEllipse(Brushes.Blue, point.X - 3, point.Y - 3, 6, 6);
            }

            // Рисуем кривую по сплайну
            Point[] pointsArray = controlPoints.ToArray();
            for (float t = 0; t <= 1; t += 0.01f)
            {
                Point splinePoint = CalculateSplinePoint(t, pointsArray);
                g.FillEllipse(Brushes.Red, splinePoint.X - 1, splinePoint.Y - 1, 2, 2);
            }
        }

        private Point CalculateSplinePoint(float t, Point[] points)
        {
            int n = points.Length - 1;
            int[] binom = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                binom[i] = BinomialCoefficient(n, i);
            }

            float x = 0, y = 0;

            for (int i = 0; i <= n; i++)
            {
                float blend = binom[i] * (float)Math.Pow(1 - t, n - i) * (float)Math.Pow(t, i);
                x += points[i].X * blend;
                y += points[i].Y * blend;
            }

            return new Point((int)x, (int)y);
        }

        private int BinomialCoefficient(int n, int k)
        {
            if (k == 0 || k == n)
                return 1;

            return BinomialCoefficient(n - 1, k - 1) + BinomialCoefficient(n - 1, k);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            // Перемещение выбранной точки
            if (selectedPointIndex != -1 && e.Button == MouseButtons.Left)
            {
                controlPoints[selectedPointIndex] = e.Location;
                pictureBox.Invalidate();
            }
        }
    }
}
