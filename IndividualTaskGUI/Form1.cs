using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualTaskGUI
{
    public partial class Form1 : Form
    {
        private const int clockRadius = 200;
        private const int hourHandLength = 80;
        private const int minuteHandLength = 120;
        private const int secondHandLength = 140;

        private Timer timer;
        private double secondsRotation = 0.0;
        private double minutesRotation = 0.0;
        private double hoursRotation = 0.0;
        private DateTime previousTime;
        private double secondsCoefficient = 1.0;

        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 16; // Используем интервал в 16 миллисекунд для более плавного движения
            timer.Tick += Timer_Tick;
            timer.Start();

            pictureBoxClock.Paint += pictureBoxClock_Paint;
            textBoxSecondsCoefficient.Text = "1";

            previousTime = DateTime.Now;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Получаем текущее время
            DateTime currentTime = DateTime.Now;

            // Рассчитываем прошедшее время с предыдущего тика
            double elapsedSeconds = (currentTime - previousTime).TotalSeconds;

            // Увеличиваем обороты стрелок в зависимости от коэффициента секунд и прошедшего времени
            //double secondsCoefficient = Convert.ToDouble(textBoxSecondsCoefficient.Text);
            secondsRotation += (6.0 * secondsCoefficient * elapsedSeconds);
            minutesRotation += (6.0 / 60.0 * elapsedSeconds * secondsCoefficient);
            hoursRotation += (6.0 / 720.0 * elapsedSeconds * secondsCoefficient);

            // Перерисовываем часы при каждом тике таймера
            pictureBoxClock.Invalidate();

            // Обновляем предыдущее время
            previousTime = currentTime;
        }

        private void pictureBoxClock_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(pictureBoxClock.BackColor);

            int centerX = pictureBoxClock.Width / 2;
            int centerY = pictureBoxClock.Height / 2;

            g.FillEllipse(Brushes.White, centerX - clockRadius, centerY - clockRadius, 2 * clockRadius, 2 * clockRadius);

            for (int mark = 0; mark < 60; mark++)
            {
                double angle = mark * 6;
                double angleRadians = angle * Math.PI / 180;
                int markLength = (mark % 5 == 0) ? 10 : 5;
                int startX = (int)(centerX + (clockRadius - markLength) * Math.Cos(angleRadians));
                int startY = (int)(centerY + (clockRadius - markLength) * Math.Sin(angleRadians));
                int endX = (int)(centerX + clockRadius * Math.Cos(angleRadians));
                int endY = (int)(centerY + clockRadius * Math.Sin(angleRadians));

                g.DrawLine(Pens.Black, startX, startY, endX, endY);
            }

            for (int i = 1; i <= 12; i++)
            {
                double angle = (i - 3) * 30;
                double angleRadians = angle * Math.PI / 180;
                int digitX = (int)(centerX + clockRadius * 0.9 * Math.Cos(angleRadians));
                int digitY = (int)(centerY + clockRadius * 0.9 * Math.Sin(angleRadians));
                g.DrawString(i.ToString(), Font, Brushes.Black, digitX, digitY, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }

            DrawClockHand(g, Pens.Red, centerX, centerY, secondHandLength, secondsRotation);
            DrawClockHand(g, Pens.Blue, centerX, centerY, minuteHandLength, minutesRotation);
            DrawClockHand(g, Pens.Black, centerX, centerY, hourHandLength, hoursRotation);
        }


        private void DrawClockHand(Graphics g, Pen pen, int x, int y, int length, double angleDegrees)
        {
            // Переводим угол в радианы
            double angleRadians = angleDegrees * Math.PI / 180;

            // Вычисляем конечные координаты стрелки
            int endX = (int)(x + length * Math.Sin(angleRadians));
            int endY = (int)(y - length * Math.Cos(angleRadians));

            // Рисуем линию стрелки
            g.DrawLine(pen, x, y, endX, endY);
        }

        private void pictureBoxClock_Click(object sender, EventArgs e)
        {

        }

        private void buttonChangeSecondsCoefficient_Click(object sender, EventArgs e)
        {
            string inputText = textBoxSecondsCoefficient.Text;

            // Проверка на пустое поле
            if (string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Пожалуйста, введите коэффициент.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка на корректность числа
            if (!double.TryParse(inputText, out secondsCoefficient))
            {
                MessageBox.Show("Некорректное значение коэффициента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка на отрицательное значение
            if (secondsCoefficient <= 0)
            {
                MessageBox.Show("Коэффициент должен быть положительным числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
