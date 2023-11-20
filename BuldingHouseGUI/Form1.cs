using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuldingHouseGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeRoofTypes();

            // Добавление значений в comboBoxCountOfWindows
            comboBoxCountOfWindows.Items.Add("1");
            comboBoxCountOfWindows.Items.Add("2");
            comboBoxCountOfWindows.Items.Add("3");

            // Добавление значений в comboBoxPlaceForWindows
            comboBoxPlaceForWindows.Items.Add("Слева");
            comboBoxPlaceForWindows.Items.Add("По центру");
            comboBoxPlaceForWindows.Items.Add("Справа");

            // Добавление значений в comboBoxPlaceForDoor
            comboBoxPlaceForDoor.Items.Add("Слева");
            comboBoxPlaceForDoor.Items.Add("По центру");
            comboBoxPlaceForDoor.Items.Add("Справа");

        }

        private void InitializeRoofTypes()
        {
            // Заполнение comboBoxRoofType
            comboBoxRoofType.Items.Add("Прямоугольная");
            comboBoxRoofType.Items.Add("Треугольная");
            comboBoxRoofType.Items.Add("Полукруглая");
        }

        private void buttonBuildHouse_Click(object sender, EventArgs e)
        {
            // Получение параметров дома
            int houseHeight = Convert.ToInt32(textBoxHouseHeight.Text);
            int houseWidth = Convert.ToInt32(textBoxHouseWeight.Text);
            int roofHeight = Convert.ToInt32(textBoxRoofHeight.Text);
            string roofType = comboBoxRoofType.SelectedItem.ToString();

            // Получение параметров окон и двери
            int windowCount = Convert.ToInt32(comboBoxCountOfWindows.SelectedItem);
            string windowPlacement = comboBoxPlaceForWindows.SelectedItem.ToString();
            string doorPlacement = comboBoxPlaceForDoor.SelectedItem.ToString();

            // Создание объекта для рисования на pictureBox
            Graphics g = pictureBoxHouse.CreateGraphics();
            g.Clear(Color.White); // Очистка предыдущего рисунка

            // Рисование основания дома
            int baseX = (pictureBoxHouse.Width - houseWidth) / 2;
            int baseY = pictureBoxHouse.Height - houseHeight - 10;
            g.DrawRectangle(Pens.Black, baseX, baseY, houseWidth, houseHeight);

            // Рисование крыши в зависимости от выбранного типа
            switch (roofType)
            {
                case "Прямоугольная":
                    DrawRectangularRoof(g, baseX, baseY, houseWidth, houseHeight, roofHeight);
                    break;
                case "Треугольная":
                    DrawTriangularRoof(g, baseX, baseY, houseWidth, houseHeight, roofHeight);
                    break;
                case "Полукруглая":
                    DrawSemicircularRoof(g, baseX, baseY, houseWidth, houseHeight, roofHeight);
                    break;
                default:
                    break;
            }

            // Рисование окон
            DrawWindows(g, baseX, baseY, houseWidth, houseHeight, windowCount, windowPlacement);

            // Рисование двери
            DrawDoor(g, baseX, baseY, houseWidth, houseHeight, doorPlacement);
        }

        private void DrawWindows(Graphics g, int baseX, int baseY, int houseWidth, int houseHeight, int windowCount, string windowPlacement)
        {
            int windowSize = 20;
            int windowHeight = 30; // Высота окна

            int windowX = 0;
            switch (windowPlacement)
            {
                case "Слева":
                    windowX = baseX + 10;
                    break;
                case "По центру":
                    windowX = baseX + (houseWidth - windowCount * windowSize) / 2;
                    break;
                case "Справа":
                    windowX = baseX + houseWidth - windowCount * windowSize - 10;
                    break;
            }

            int windowY = baseY - windowHeight - 10;

            for (int i = 0; i < windowCount; i++)
            {
                g.DrawRectangle(Pens.Blue, windowX, windowY, windowSize, windowHeight);
                windowX += windowSize + 10; // Промежуток между окнами
            }
        }

        private void DrawDoor(Graphics g, int baseX, int baseY, int houseWidth, int houseHeight, string doorPlacement)
        {
            int doorWidth = 30;
            int doorHeight = 60;

            int doorX = 0;
            switch (doorPlacement)
            {
                case "Слева":
                    doorX = baseX + 10;
                    break;
                case "По центру":
                    doorX = baseX + (houseWidth - doorWidth) / 2;
                    break;
                case "Справа":
                    doorX = baseX + houseWidth - doorWidth - 10;
                    break;
            }

            int doorY = baseY - doorHeight;

            g.DrawRectangle(Pens.Red, doorX, doorY, doorWidth, doorHeight);
        }


        private void DrawRectangularRoof(Graphics g, int baseX, int baseY, int houseWidth, int houseHeight, int roofHeight)
        {
            g.DrawLine(Pens.Black, baseX, baseY, baseX + houseWidth, baseY);
            g.DrawLine(Pens.Black, baseX, baseY, baseX, baseY - roofHeight);
            g.DrawLine(Pens.Black, baseX + houseWidth, baseY, baseX + houseWidth, baseY - roofHeight);
            g.DrawLine(Pens.Black, baseX, baseY - roofHeight, baseX + houseWidth, baseY - roofHeight);
        }

        private void DrawTriangularRoof(Graphics g, int baseX, int baseY, int houseWidth, int houseHeight, int roofHeight)
        {
            g.DrawLine(Pens.Black, baseX, baseY, baseX + houseWidth / 2, baseY - roofHeight);
            g.DrawLine(Pens.Black, baseX + houseWidth / 2, baseY - roofHeight, baseX + houseWidth, baseY);
        }


        private void DrawSemicircularRoof(Graphics g, int baseX, int baseY, int houseWidth, int houseHeight, int roofHeight)
        {
            int radius = houseWidth / 2;
            g.DrawArc(Pens.Black, baseX, baseY - roofHeight, houseWidth, roofHeight * 2, 0, -180);
        }

    }
}
