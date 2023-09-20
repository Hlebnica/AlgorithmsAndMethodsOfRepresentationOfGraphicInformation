using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        enum TypeOfLine : int { Continuous = 1, Dotted = 2 };
        enum WeightOfLine : int { Five = 5, Ten = 10, Fifteen = 15 };
        int typeOfLine;
        int weightOfLine;
        Point start_coordinates;
        Point previous_coordinates;
        Size size_object;
        bool move_object;
        Color color_brush;
        Color color_pen;
        Rectangle rectangle;

        private Point offset;  // Для хранения смещения между курсором и объектом

        public Form1()
        {
            InitializeComponent();
            typeOfLine = (int)TypeOfLine.Continuous;
            weightOfLine = (int)WeightOfLine.Five;
            start_coordinates = new Point(10, 10);
            size_object = new Size(150, 150);
            move_object = false;
            previous_coordinates = start_coordinates;
            color_brush = Color.Yellow;
            color_pen = Color.Black;

            // Контекстное меню
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            contextMenuStrip.Items.Add("Изменить цвет линии обводки").Click += ChangePenColor_Click;
            contextMenuStrip.Items.Add("Изменить цвет фона").Click += ChangeBrushColor_Click;

            ToolStripMenuItem typeMenu = new ToolStripMenuItem("Изменить тип линии");
            typeMenu.DropDownItems.Add("Прямая").Tag = (int)TypeOfLine.Continuous;
            typeMenu.DropDownItems.Add("Прерывистая").Tag = (int)TypeOfLine.Dotted;
            foreach (ToolStripMenuItem item in typeMenu.DropDownItems)
            {
                item.Click += ChangePenType_Click;
            }
            contextMenuStrip.Items.Add(typeMenu);

            ToolStripMenuItem widthMenu = new ToolStripMenuItem("Изменить толщину линии");
            widthMenu.DropDownItems.Add("5").Tag = (int)WeightOfLine.Five;
            widthMenu.DropDownItems.Add("10").Tag = (int)WeightOfLine.Ten;
            widthMenu.DropDownItems.Add("15").Tag = (int)WeightOfLine.Fifteen;
            foreach (ToolStripMenuItem item in widthMenu.DropDownItems)
            {
                item.Click += ChangePenWidth_Click;
            }
            contextMenuStrip.Items.Add(widthMenu);
            this.ContextMenuStrip = contextMenuStrip;

            // Обработчики событий для перемещения объекта
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;

            // Инициализация прямоугольника
            rectangle = new Rectangle(start_coordinates, size_object);

            // Включение двойной буферизации для предотвращения мерцания
            this.DoubleBuffered = true;

            // Обработчик события Paint
            this.Paint += Form1_Paint;
        }

        // Цвет рамки
        private void ChangePenColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color_pen = colorDialog.Color;
                this.Invalidate();
            }
        }

        // Тип рамки
        private void ChangePenType_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                int selectedType = (int)item.Tag;
                typeOfLine = selectedType;
                this.Invalidate();
            }
        }

        // Размер рамки
        private void ChangePenWidth_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                int selectedWidth = (int)item.Tag;
                weightOfLine = selectedWidth;
                this.Invalidate();
            }
        }

        // Цвет заливки
        private void ChangeBrushColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color_brush = colorDialog.Color;
                this.Invalidate();
            }
        }

        // Отрисовка объекта на форме
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(color_pen, weightOfLine);
            SolidBrush brush = new SolidBrush(color_brush);

            if (typeOfLine == (int)TypeOfLine.Dotted)
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            }

            graphics.FillRectangle(brush, rectangle);
            graphics.DrawRectangle(pen, rectangle);
        }

        // Движение объекта по форме с помощью мыши
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move_object)
            {
                int newX = e.X - offset.X;
                int newY = e.Y - offset.Y;

                newX = Math.Max(0, Math.Min(newX, this.ClientSize.Width - rectangle.Width));
                newY = Math.Max(0, Math.Min(newY, this.ClientSize.Height - rectangle.Height));

                rectangle.Location = new Point(newX, newY);
                this.Invalidate();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rectangle.Contains(e.Location))
            {
                move_object = true;
                offset = new Point(e.X - rectangle.Left, e.Y - rectangle.Top);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move_object = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
