using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private async void buttonSeedFilling_Click(object sender, EventArgs e)
        {
            int startX = selectedX; 
            int startY = selectedY; 

            // Проверка: находится ли начальная точка внутри полигона
            if (!IsPointInPolygon(startX, startY, _currentPoints))
            {
                MessageBox.Show("Выберите точку внутри фигуры для начала заливки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            Color targetColor = _bitmap.GetPixel(startX, startY); // Получение цвета пикселя в начальной точке

            Stack<Point> pixelsToFill = new Stack<Point>(); // Создание стека для хранения пикселей, которые нужно закрасить
            pixelsToFill.Push(new Point(startX, startY)); // Добавление начального пикселя в стек

            int filledPixels = 0; // Счетчик закрашенных пикселей

            while (pixelsToFill.Count > 0)
            {
                Point currentPixel = pixelsToFill.Pop(); // Извлечение пикселя из стека
                int x = currentPixel.X; // Получение X координаты текущего пикселя
                int y = currentPixel.Y; // Получение Y координаты текущего пикселя

                // Проверка, находится ли пиксель в пределах изображения и имеет ли он цвет, который нужно заменить
                if (x >= 0 && x < _bitmap.Width && y >= 0 && y < _bitmap.Height && _bitmap.GetPixel(x, y) == targetColor)
                {
                    _bitmap.SetPixel(x, y, _fillColor); // Закраска пикселя выбранным цветом
                    filledPixels++; 

                    // Задержка для визуализации процесса
                    if (filledPixels % 20 == 0)
                    {
                        pictureBoxForFigure.Refresh(); 
                        await Task.Delay(5); 
                    }

                    // Добавление соседних пикселей в стек для дальнейшей заливки
                    pixelsToFill.Push(new Point(x + 1, y)); // Добавление пикселя справа
                    pixelsToFill.Push(new Point(x - 1, y)); // Добавление пикселя слева
                    pixelsToFill.Push(new Point(x, y + 1)); // Добавление пикселя сверху
                    pixelsToFill.Push(new Point(x, y - 1)); // Добавление пикселя снизу 

                    /*
                    pixelsToFill.Push(new Point(x, y - 1)); // Добавление пикселя сверху
                    pixelsToFill.Push(new Point(x, y + 1)); // Добавление пикселя снизу
                    pixelsToFill.Push(new Point(x - 1, y)); // Добавление пикселя слева
                    pixelsToFill.Push(new Point(x + 1, y)); // Добавление пикселя справа
                    */
                }
            }
            pictureBoxForFigure.Refresh();
        }

        private void pictureBoxForFigure_MouseClick(object sender, MouseEventArgs e)
        {
            selectedX = e.X;
            selectedY = e.Y;
        }

        private bool IsPointInPolygon(int x, int y, List<PointF> polygon)
        {
            int crossings = 0; // Инициализация счетчика пересечений линии из точки с ребрами полигона
            // Цикл по всем вершинам полигона
            for (int i = 0; i < polygon.Count; i++)
            {
                PointF p1 = polygon[i]; // Текущая вершина полигона
                PointF p2 = polygon[(i + 1) % polygon.Count]; // Следующая вершина полигона, с учетом замыкания контура
                // Проверка, пересекает ли горизонтальная линия из точки текущее ребро полигона
                if (p1.Y <= y && p2.Y > y || p1.Y > y && p2.Y <= y)
                {
                    // Вычисление X координаты точки пересечения ребра полигона с горизонтальной линией
                    float vt = (float)(y - p1.Y) / (p2.Y - p1.Y);
                    // Если X координата точки меньше X координаты найденной точки пересечения, увеличиваем счетчик пересечений
                    if (x < p1.X + vt * (p2.X - p1.X))
                        crossings++;
                }
            }
            // Если число пересечений нечетное, точка находится внутри полигона, иначе - снаружи
            return (crossings % 2 == 1);
        }


        private void buttonLineByLineFilling_Click(object sender, EventArgs e)
        {
            if (selectedX == -1 || selectedY == -1 || !IsPointInPolygon(selectedX, selectedY, _currentPoints))
            {
                MessageBox.Show("Выберите точку внутри фигуры для начала заливки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Color targetColor = _bitmap.GetPixel(selectedX, selectedY); // Получение цвета пикселя в начальной точке
            Queue<Point> nodes = new Queue<Point>(); // Создание стека для хранения пикселей, которые нужно закрасить
            nodes.Enqueue(new Point(selectedX, selectedY));

            while (nodes.Count > 0)
            {
                Point node = nodes.Dequeue();
                int x = node.X;
                int y = node.Y;

                // Поиск крайней левой точки горизонтальной линии
                while (x > 0 && _bitmap.GetPixel(x - 1, y) == targetColor)
                {
                    x--;
                }

                bool spanAbove = false;
                bool spanBelow = false;

                // Проход вправо от найденной крайней левой точки, заливка и определение точек для следующих строк
                while (x < _bitmap.Width && _bitmap.GetPixel(x, y) == targetColor)
                {
                    _bitmap.SetPixel(x, y, _fillColor);

                    if (!spanAbove && y > 0 && _bitmap.GetPixel(x, y - 1) == targetColor)
                    {
                        nodes.Enqueue(new Point(x, y - 1));
                        spanAbove = true;
                    }
                    else if (spanAbove && y > 0 && _bitmap.GetPixel(x, y - 1) != targetColor)
                    {
                        spanAbove = false;
                    }

                    if (!spanBelow && y < _bitmap.Height - 1 && _bitmap.GetPixel(x, y + 1) == targetColor)
                    {
                        nodes.Enqueue(new Point(x, y + 1));
                        spanBelow = true;
                    }
                    else if (spanBelow && y < _bitmap.Height - 1 && _bitmap.GetPixel(x, y + 1) != targetColor)
                    {
                        spanBelow = false;
                    }

                    x++;
                }

                pictureBoxForFigure.Refresh(); // Обновление изображения для отображения процесса заливки
                Task.Delay(10).Wait(); // Задержка для визуализации процесса
            }
        }
    }
}
