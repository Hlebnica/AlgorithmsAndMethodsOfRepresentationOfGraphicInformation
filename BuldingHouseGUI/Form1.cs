using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuldingHouseGUI
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        List<DrawingObject> drawingObjects = new List<DrawingObject>();
        Color houseColor = Color.Gray;
        Color roofColor = Color.Black;
        Color doorColor = Color.Brown;
        Color windowColor = Color.Blue;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBoxHouse.Width, pictureBoxHouse.Height);
            pictureBoxHouse.Image = bitmap;
            pictureBoxHouse.BackgroundImageLayout = ImageLayout.None;

            deleteHouse();

            comboBoxRoofType.Items.Add("Треугольник");
            comboBoxRoofType.Items.Add("Трапеция");
            comboBoxRoofType.Items.Add("Полукруг");

            comboBoxCountOfWindows.Items.Add("1");
            comboBoxCountOfWindows.Items.Add("2");
            comboBoxCountOfWindows.Items.Add("3");

            comboBoxPlaceForWindows.Items.Add("Слева");
            comboBoxPlaceForWindows.Items.Add("По центру");
            comboBoxPlaceForWindows.Items.Add("Справа");

            comboBoxPlaceForDoor.Items.Add("Слева");
            comboBoxPlaceForDoor.Items.Add("По центру");
            comboBoxPlaceForDoor.Items.Add("Справа");

        }

        private void buttonBuildHouse_Click(object sender, EventArgs e)
        {
            deleteHouse();
            pictureBoxHouse.Invalidate();
            int houseWidth = 0;
            int houseHeight = 0;
            int roofHeight = 0;

            try
            {
                houseWidth = int.Parse(textBoxHouseWeight.Text);
                houseHeight = int.Parse(textBoxHouseHeight.Text);
                roofHeight = int.Parse(textBoxRoofHeight.Text);

                if (houseWidth < 100 || houseWidth > 300)
                {
                    MessageBox.Show("Некорректная ширина дома");
                    return;
                }
                if (houseHeight < 100 || houseHeight > 200)
                {
                    MessageBox.Show("Некорректная высота дома");
                    return;
                }
                if (roofHeight < 80 || roofHeight > 120)
                {
                    MessageBox.Show("Некорректная высота крыши");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            if (comboBoxRoofType.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тип крыши");
                return;
            }
            if (comboBoxCountOfWindows.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите количество окон");
                return;
            }
            if (comboBoxPlaceForDoor.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите расположение двери");
                return;
            }
            if (comboBoxCountOfWindows.SelectedIndex == 0 && comboBoxPlaceForWindows.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите расположение окон");
                return;
            }

            //Корпус
            drawingObjects.Add(new DrawingObject(DrawingObject.ObjectType.Rectangle,
                houseColor, pictureBoxHouse.Width / 2 - houseWidth / 2, pictureBoxHouse.Height - 50 - houseHeight, houseWidth, houseHeight));


            //Крыша
            switch (comboBoxRoofType.SelectedIndex)
            {
                case 0:
                    // Треугольная крыша
                    drawingObjects.Add(new DrawingObject(DrawingObject.ObjectType.Polygon, roofColor,
                        pictureBoxHouse.Width / 2 - houseWidth / 2 - 10, pictureBoxHouse.Height - 50 - houseHeight,
                        new Point[] {
                            new Point(0, 0),
                            new Point(houseWidth + 20, 0),
                            new Point(houseWidth / 2 + 10, -roofHeight) }));
                    break;
                case 1:
                    // Трапециевидная крыша
                    drawingObjects.Add(new DrawingObject(DrawingObject.ObjectType.Polygon, roofColor,
                        pictureBoxHouse.Width / 2 - houseWidth / 2 - 10, pictureBoxHouse.Height - 50 - houseHeight,
                        new Point[] {
                            new Point(0, 0),
                            new Point(houseWidth + 20, 0),
                            new Point(houseWidth / 4 * 3 + 5, -roofHeight),
                            new Point(houseWidth / 4 + 5, -roofHeight)
                        }));
                    break;
                case 2:
                    // Полукруглая крыша
                    drawingObjects.Add(new DrawingObject(DrawingObject.ObjectType.HalfCircle, roofColor,
                        pictureBoxHouse.Width / 2 - houseWidth / 2 - 10, pictureBoxHouse.Height - 50 - houseHeight - roofHeight/2,
                        houseWidth + 20, roofHeight));
                    break;
                default:
                    MessageBox.Show("Неверный тип крыши");
                    break;
            }

            //Дверь
            switch (comboBoxPlaceForDoor.SelectedIndex)
            {
                case 0:
                    drawingObjects.Add(new DrawingObject(DrawingObject.ObjectType.Rectangle,
                        doorColor, pictureBoxHouse.Width / 2 - (int)(houseWidth / 2.5),
                        pictureBoxHouse.Height - 50 - (int)(houseHeight / 2.5),
                        houseWidth / 6, (int)(houseHeight / 2.5)));
                    break;
                case 1:
                    drawingObjects.Add(new DrawingObject(DrawingObject.ObjectType.Rectangle,
                        doorColor, pictureBoxHouse.Width / 2 - houseWidth / 6 / 2,
                        pictureBoxHouse.Height - 50 - (int)(houseHeight / 2.5),
                        houseWidth / 6, (int)(houseHeight / 2.5)));
                    break;
                case 2:
                    drawingObjects.Add(new DrawingObject(DrawingObject.ObjectType.Rectangle,
                        doorColor, pictureBoxHouse.Width / 2 + (int)(houseWidth / 2.5) - houseWidth / 6,
                        pictureBoxHouse.Height - 50 - (int)(houseHeight / 2.5),
                        houseWidth / 6, (int)(houseHeight / 2.5)));
                    break;
                default:
                    MessageBox.Show("Неверное расположение двери");
                    break;
            }

            //Окна
            if (comboBoxCountOfWindows.SelectedIndex == 0)
            {
                switch (comboBoxPlaceForWindows.SelectedIndex)
                {
                    case 0:
                        drawingObjects.Add(new DrawingObject(DrawingObject.ObjectType.Rectangle,
                            windowColor, pictureBoxHouse.Width / 2 - (int)(houseWidth / 2.5),
                            pictureBoxHouse.Height - 50 - (int)(houseHeight / 4) - (int)(houseHeight / 1.75),
                            houseWidth / 6, (int)(houseHeight / 4)));
                        break;
                    case 1:
                        drawingObjects.Add(new DrawingObject(DrawingObject.ObjectType.Rectangle,
                            windowColor, pictureBoxHouse.Width / 2 - houseWidth / 6 / 2,
                            pictureBoxHouse.Height - 50 - (int)(houseHeight / 4) - (int)(houseHeight / 1.75),
                            houseWidth / 6, (int)(houseHeight / 4)));
                        break;
                    case 2:
                        drawingObjects.Add(new DrawingObject(DrawingObject.ObjectType.Rectangle,
                             windowColor, pictureBoxHouse.Width / 2 + (int)(houseWidth / 2.5) - houseWidth / 6,
                             pictureBoxHouse.Height - 50 - (int)(houseHeight / 4) - (int)(houseHeight / 1.75),
                             houseWidth / 6, (int)(houseHeight / 4)));
                        break;
                    default:
                        MessageBox.Show("Неверное расположение двери");
                        break;
                }
            }
            else
            {
                for (int i = 0; i < comboBoxCountOfWindows.SelectedIndex + 1; i++)
                {
                    drawingObjects.Add(new DrawingObject(DrawingObject.ObjectType.Rectangle,
                            windowColor,
                            pictureBoxHouse.Width / 2 - houseWidth / 2 +
                            houseWidth / (comboBoxCountOfWindows.SelectedIndex + 2) / (comboBoxCountOfWindows.SelectedIndex + 1) +
                            i * houseWidth / (comboBoxCountOfWindows.SelectedIndex + 1),
                            pictureBoxHouse.Height - 50 - (int)(houseHeight / 4) - (int)(houseHeight / 1.75),
                            houseWidth / 6, (int)(houseHeight / 4)));
                }
            }

            DrawObjects();
        }

        private void deleteHouse()
        {
            drawingObjects.Clear();
            bitmap = new Bitmap(pictureBoxHouse.Width, pictureBoxHouse.Height);
            pictureBoxHouse.Image = bitmap;
            pictureBoxHouse.BackgroundImageLayout = ImageLayout.None;

        }

        private void DrawObjects()
        {
            bitmap = new Bitmap(pictureBoxHouse.Width, pictureBoxHouse.Height);
            pictureBoxHouse.Image = bitmap;
            pictureBoxHouse.BackgroundImageLayout = ImageLayout.None;


            Graphics formGraphics = Graphics.FromImage(bitmap);
            foreach (DrawingObject drawingObject in drawingObjects)
            {
                if (drawingObject != null)
                {
                    Brush myBrush = new SolidBrush(drawingObject.color);
                    switch (drawingObject.type)
                    {
                        case DrawingObject.ObjectType.Rectangle:
                            formGraphics.FillRectangle(myBrush, new Rectangle(drawingObject.x, drawingObject.y, drawingObject.width, drawingObject.height));
                            break;
                        case DrawingObject.ObjectType.Polygon:
                            formGraphics.FillPolygon(myBrush, drawingObject.points.Select(point => new Point(drawingObject.x + point.X, drawingObject.y + point.Y)).ToArray());
                            break;
                        case DrawingObject.ObjectType.HalfCircle:
                            GraphicsPath path = new GraphicsPath();
                            path.AddArc(drawingObject.x, drawingObject.y, drawingObject.width, drawingObject.height, 180, 180);
                            formGraphics.FillPath(myBrush, path);
                            break;
                        default:
                            MessageBox.Show("Неизвестный тип объекта");
                            break;
                    }
                    myBrush.Dispose();
                }

            }
            formGraphics.Dispose();
        }

        public class DrawingObject
        {
            public enum ObjectType : int { Polygon = 0, Rectangle = 1, HalfCircle = 2 }
            public ObjectType type { get; set; }
            public int x, y, height, width;
            public Color color { get; set; }
            public Point[] points { get; set; }


            public DrawingObject(ObjectType type, Color color, int x, int y, Point[] pointArray)
            {
                this.type = type;
                this.color = color;
                this.x = x;
                this.y = y;
                this.points = pointArray;
            }

            public DrawingObject(ObjectType type, Color color, int x, int y, int width, int height)
            {
                this.type = type;
                this.color = color;
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
            }
        }

        private void buttonChangeHouseColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                houseColor = colorDialog.Color;
            }
        }

        private void buttonChangeRoofColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                roofColor = colorDialog.Color;
            }
        }

        private void buttonChangeDoorColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                doorColor = colorDialog.Color;
            }
        }

        private void buttonChangeWindowColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                windowColor = colorDialog.Color;
            }
        }

        private void comboBoxCountOfWindows_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCountOfWindows.SelectedIndex != 0)
            {
                comboBoxPlaceForWindows.SelectedIndex = -1;
                comboBoxPlaceForWindows.Enabled = false;
            }
            else
            {
                comboBoxPlaceForWindows.Enabled = true;
            }
        }

        private void buttonDestroyHouse_Click(object sender, EventArgs e)
        {
            deleteHouse();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Тест\n" +
                "   - Тест\n" +
                "   - Тест\n\n" 
                , "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
