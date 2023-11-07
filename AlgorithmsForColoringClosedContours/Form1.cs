using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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
                Pen pen = new Pen(ControlPaint.Light(Color.Black, 0.1f));

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
                    if (filledPixels % 40 == 0)
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
            //selectedX = e.X;
            //selectedY = e.Y;
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


        private async void buttonLineByLineFilling_Click(object sender, EventArgs e)
        {
            // Устанавливается цвет границы с использованием утилиты ControlPaint для осветления черного цвета
            Color borderColor = ControlPaint.Light(Color.Black, 0.1f);

            // Запускается асинхронная задача, чтобы процесс заливки не блокировал UI
            await Task.Run(() =>
            {
                // Определяется минимальная и максимальная координата Y среди всех точек фигуры
                float minY = _currentPoints.Min(p => p.Y);
                float maxY = _currentPoints.Max(p => p.Y);

                // Цикл перебирает каждую строку между минимальной и максимальной координатами Y
                for (int y = (int)minY; y < (int)maxY; y++)
                {
                    // Список для хранения X координат пересечений с границей фигуры
                    List<float> nodeX = new List<float>();
                    // Цикл перебирает все отрезки, составляющие границу фигуры
                    for (int i = 0; i < _currentPoints.Count; i++)
                    {
                        // Получение текущей и следующей точки отрезка
                        PointF p1 = _currentPoints[i];
                        PointF p2 = _currentPoints[(i + 1) % _currentPoints.Count];

                        // Проверка, пересекает ли горизонтальная линия на уровне Y отрезок между p1 и p2
                        if ((p1.Y < y && p2.Y >= y) || (p2.Y < y && p1.Y >= y))
                        {
                            // Расчет X координаты пересечения и добавление ее в список
                            nodeX.Add(p1.X + (y - p1.Y) / (p2.Y - p1.Y) * (p2.X - p1.X));
                        }
                    }

                    nodeX.Sort();

                    // Цикл закрашивает пиксели между парами пересечений
                    for (int i = 0; i < nodeX.Count; i += 2)
                    {
                        // Если первое пересечение за пределами изображения, прерывается текущая итерация
                        if (nodeX[i] >= _bitmap.Width) break;
                        // Если второе пересечение вне изображения, продолжается цикл
                        if (nodeX[i + 1] > 0)
                        {
                            // Закрашивание пикселей от первого до второго пересечения
                            for (int x = (int)nodeX[i] + 1; x < nodeX[i + 1]; x++)
                            {
                                // Проверка, что текущий X находится в пределах изображения
                                if (x >= 0 && x < _bitmap.Width)
                                {
                                    // Получение цвета текущего пикселя
                                    Color currentPixelColor = _bitmap.GetPixel(x, y);
                                    // Если цвет пикселя не близок к цвету границы, он закрашивается
                                    if (!ColorsAreClose(currentPixelColor, borderColor))
                                    {
                                        _bitmap.SetPixel(x, y, _fillColor);
                                    }
                                }
                            }
                        }
                    }

                    // Обновление изображения на форме в главном потоке после обработки каждой строки
                    this.Invoke(new Action(() =>
                    {
                        pictureBoxForFigure.Refresh();
                    }));

                    // Вставка задержки для видимости заливки
                    Task.Delay(5).Wait();
                }
            });
        }


        // Метод для определения, насколько близки цвета
        private bool ColorsAreClose(Color a, Color b, int threshold = 10)
        {
            return Math.Abs(a.R - b.R) < threshold &&
                   Math.Abs(a.G - b.G) < threshold &&
                   Math.Abs(a.B - b.B) < threshold;
        }


        private void Form1_Load(object sender, System.EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                selectedX = 300;
                selectedY = 300;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                selectedX = 410;
                selectedY = 300;
            }
        }
    }
}
