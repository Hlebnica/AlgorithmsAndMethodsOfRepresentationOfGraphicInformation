using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab4.Form1.ItemForDrawing;

namespace lab4
{
    public partial class Form1 : Form
    {
        ItemForDrawing object_;
        Bitmap bitmap;
        Brush brushForDrawRectangle;
        Color color;
        int weightOfLine;
        Graphics graphics;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = (Image)bitmap;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            brushForDrawRectangle = Brushes.Black;
            color = Color.Black;
            weightOfLine = 2;
            graphics = Graphics.FromImage(bitmap);
        }

        // Хранение данных об объекте
        public class ItemForDrawing
        {
            public enum TypeOfObject : int
            { Point = 0, Line = 1, Rectangle = 2, Ellipse = 3, String = 4 }
            public Point startCoordinate { set; get; }
            public Point endCoordinate { set; get; }
            public Size size { set; get; }
            public string text { set; get; }
            public int typeOfObject { set; get; }

            public ItemForDrawing(Point coordinate)
            {
                startCoordinate = coordinate;
                typeOfObject = (int)TypeOfObject.Point;
            }

            public ItemForDrawing(int typeOfObject, Point coordinate, Size size)
            {
                startCoordinate = coordinate;
                this.size = size;
                this.typeOfObject = typeOfObject;
            }

            public ItemForDrawing(Point startCoordinate, Point endCoordinate)
            {
                this.startCoordinate = startCoordinate;
                this.endCoordinate = endCoordinate;
                typeOfObject = (int)TypeOfObject.Line;
            }

            public ItemForDrawing(Point startCoordinate, string text)
            {
                this.text = text;
                this.startCoordinate = startCoordinate;
                typeOfObject = (int)TypeOfObject.String;
            }
        }

        // Метод для рисования объектов на PictureBox
        private void DrawObject(ItemForDrawing item)
        {
            switch (item.typeOfObject)
            {
                case (int)TypeOfObject.Point:
                    graphics.FillRectangle(
                        brushForDrawRectangle,
                        item.startCoordinate.X,
                        item.startCoordinate.Y,
                        5, 5); // Точка
                    break;
                case (int)TypeOfObject.Line:
                    Pen pen = new Pen(color, weightOfLine);
                    graphics.DrawLine(
                        pen,
                        item.startCoordinate,
                        item.endCoordinate); // Линия
                    break;
                case (int)TypeOfObject.Rectangle:
                    graphics.FillRectangle(
                        brushForDrawRectangle,
                        item.startCoordinate.X, item.startCoordinate.Y,
                        item.size.Width, item.size.Height); // Прямоугольник
                    break;
                case (int)TypeOfObject.Ellipse:
                    graphics.FillEllipse(
                        brushForDrawRectangle,
                        item.startCoordinate.X,
                        item.startCoordinate.Y,
                        item.size.Width,
                        item.size.Height); // Эллипс
                    break;
                case (int)TypeOfObject.String:
                    Font font = new Font("Arial", 10);
                    graphics.DrawString(
                        item.text,
                        font,
                        brushForDrawRectangle,
                        item.startCoordinate); // Текст
                    break;
            }
            pictureBox1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Добавить элементы в ComboBox
            comboBox_DrawingObject.Items.Add("Точка");
            comboBox_DrawingObject.Items.Add("Линия");
            comboBox_DrawingObject.Items.Add("Прямоугольник");
            comboBox_DrawingObject.Items.Add("Эллипс");
            comboBox_DrawingObject.Items.Add("Текст");

            // Устанавить выбранный элемент по умолчанию
            comboBox_DrawingObject.SelectedIndex = 0;
        }

        private void button_CreateObject_Click(object sender, EventArgs e)
        {
            // Получаем значения из текстовых полей, если они введены корректно
            int.TryParse(textBox_X1.Text, out int x1);
            int.TryParse(textBox_Y1.Text, out int y1);
            int.TryParse(textBox_X2.Text, out int x2);
            int.TryParse(textBox_Y2.Text, out int y2);
            int.TryParse(textBox_Width.Text, out int width);
            int.TryParse(textBox_Height.Text, out int height);
            string text = textBox_TextObject.Text;

            // Получить выбранный тип объекта из ComboBox
            ItemForDrawing.TypeOfObject objectType = (ItemForDrawing.TypeOfObject)comboBox_DrawingObject.SelectedIndex;

            // Создать объект ItemForDrawing в зависимости от выбранного типа
            ItemForDrawing newItem;

            switch (objectType)
            {
                case TypeOfObject.Point:
                    newItem = new ItemForDrawing(new Point(x1, y1));
                    break;
                case TypeOfObject.Line:
                    newItem = new ItemForDrawing(new Point(x1, y1), new Point(x2, y2));
                    break;
                case TypeOfObject.Rectangle:
                    newItem = new ItemForDrawing((int)objectType, new Point(x1, y1), new Size(width, height));
                    break;
                case TypeOfObject.Ellipse:
                    newItem = new ItemForDrawing((int)objectType, new Point(x1, y1), new Size(width, height));
                    break;
                case TypeOfObject.String:
                    newItem = new ItemForDrawing(new Point(x1, y1), text);
                    break;
                default:
                    // По умолчанию точка
                    newItem = new ItemForDrawing(new Point(x1, y1));
                    break;
            }

            // Вызыв метода DrawObject для отображения объекта на холсте
            DrawObject(newItem);
        }

        // Очистка холста
        private void button_ClearForm_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pictureBox1.Invalidate();
        }

        // Очистка текстовых полей
        private void Clear_TextBox()
        {
            textBox_X1.Clear();
            textBox_Y1.Clear();
            textBox_X2.Clear();
            textBox_Y2.Clear();
            textBox_Width.Clear();
            textBox_Height.Clear();
            textBox_TextObject.Clear();
        }

        private void comboBox_DrawingObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получить выбранный тип объекта из ComboBox
            ItemForDrawing.TypeOfObject objectType = (ItemForDrawing.TypeOfObject)comboBox_DrawingObject.SelectedIndex;

            // Отключить все textBox по умолчанию
            textBox_X1.Enabled = false;
            textBox_Y1.Enabled = false;
            textBox_X2.Enabled = false;
            textBox_Y2.Enabled = false;
            textBox_Width.Enabled = false;
            textBox_Height.Enabled = false;
            textBox_TextObject.Enabled = false;

            // Включить только те textBox, которые необходимы для выбранного типа объекта
            switch (objectType)
            {
                case TypeOfObject.Point:
                    Clear_TextBox();
                    textBox_X1.Enabled = true;
                    textBox_Y1.Enabled = true;
                    break;
                case TypeOfObject.Line:
                    Clear_TextBox();
                    textBox_X1.Enabled = true;
                    textBox_Y1.Enabled = true;
                    textBox_X2.Enabled = true;
                    textBox_Y2.Enabled = true;
                    break;
                case TypeOfObject.Rectangle:
                case TypeOfObject.Ellipse:
                    Clear_TextBox();
                    textBox_X1.Enabled = true;
                    textBox_Y1.Enabled = true;
                    textBox_Width.Enabled = true;
                    textBox_Height.Enabled = true;
                    break;
                case TypeOfObject.String:
                    Clear_TextBox();
                    textBox_X1.Enabled = true;
                    textBox_Y1.Enabled = true;
                    textBox_TextObject.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
