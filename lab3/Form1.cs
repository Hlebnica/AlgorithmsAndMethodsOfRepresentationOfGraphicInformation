using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        enum TypeOfLine: int { Continuous = 1, Dotted = 1 };
        enum WeightOfLine : int { Five = 5, Ten = 20, Fifteen = 15 };
        int typeOfLine;
        int weightOfLine;
        Point start_coorditans;
        Point previos_coorditans;
        Size size_object;
        bool move_object;
        Color color_brush;
        Color color_pen;

        public Form1()
        {
            InitializeComponent();

            typeOfLine = (int)TypeOfLine.Continuous;
            weightOfLine = (int)WeightOfLine.Five;
            start_coorditans = new Point(10, 10);
            size_object = new Size(100, 100);
            move_object = false;
            previos_coorditans = start_coorditans;
            color_brush = Color.Aquamarine;
            color_pen = Color.Aqua;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
