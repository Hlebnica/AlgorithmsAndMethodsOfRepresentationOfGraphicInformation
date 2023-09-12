using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        string typeOfLine = "";
        string typeOfGeoObj = "";

        public Form1()
        {
            InitializeComponent();

            var items = new string[] { "Круг", "Квадрат", "Прямоугольник" };
            comboBox_ListTypesGeoFigures.Items.AddRange(items);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_LineType.Text != "")
            {
                listBox_ListTypesForLines.Items.Add(textBox_LineType.Text);
            }
        }

        private void button_SeeChoice_Click(object sender, EventArgs e)
        {
            if (typeOfLine != "" && typeOfGeoObj != "")
            {
                listBox_UserChoice.Items.Clear();
                listBox_UserChoice.Items.Add($"Тип линии: {typeOfLine}");
                listBox_UserChoice.Items.Add($"\n\nВид геометрической фигуры: {typeOfGeoObj}");
            }
        }

        private void comboBox_ListTypesGeoFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_ListTypesGeoFigures.SelectedItem != null)
            {
                typeOfGeoObj = comboBox_ListTypesGeoFigures.SelectedItem.ToString();
            }
        }

        private void listBox_ListTypesForLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_ListTypesForLines.SelectedItem != null)
            {
                typeOfLine = listBox_ListTypesForLines.SelectedItem.ToString();
            }

        }
    }
}