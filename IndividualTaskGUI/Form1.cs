﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace IndividualTaskGUI
{
    public partial class Form1 : Form
    {
        private const int clockRadius = 220;
        private const int hourHandLength = 100;
        private const int minuteHandLength = 140;
        private const int secondHandLength = 170;

        private Timer timer;
        private DateTime previousTime;
        private double secondsRotation = 0.0;
        private double minutesRotation = 0.0;
        private double hoursRotation = 0.0;
        private double secondsCoefficient = 1.0;

        private Color secondsHandColor = Color.Red;
        private Color minuteHandColor = Color.Blue;
        private Color hoursHandColor = Color.Black;

        private Color marksColor = Color.Black;
        private SolidBrush digitBrush = new SolidBrush(Color.Black);
        private SolidBrush backgroundBrush = new SolidBrush(Color.White);

        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 16;
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

            // Рассчитываем обновленные углы вращения стрелок
            secondsRotation += (6.0 * secondsCoefficient * elapsedSeconds);
            minutesRotation += (6.0 / 60.0 * elapsedSeconds * secondsCoefficient);
            hoursRotation += (6.0 / 720.0 * elapsedSeconds * secondsCoefficient);

            // Если стрелка идет назад, корректировка значений
            if (hoursRotation < 0)
            {
                hoursRotation = 720 + hoursRotation % 360;
            }
            if (minutesRotation < 0)
            {
                minutesRotation = 360 + minutesRotation % 360;
            }
            if (secondsRotation < 0)
            {
                secondsRotation = 360 + secondsRotation % 360;
            }

            // Расчет времени 
            int totalSeconds = (int)(secondsRotation / 6.0);
            int totalMinutes = (int)(minutesRotation / 6.0);

            int totalHours = (int)(hoursRotation / 30.0);
            totalHours = (totalHours + 24) % 24; 

            int hours = totalHours;
            int minutes = totalMinutes % 60;
            int seconds = totalSeconds % 60;

            string digitalClockText = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
            labelDigitalClock.Text = digitalClockText;

            pictureBoxClock.Invalidate();

            // Обновить предыдущее время
            previousTime = currentTime;
        }


        private void pictureBoxClock_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(pictureBoxClock.BackColor);

            int centerX = pictureBoxClock.Width / 2;
            int centerY = pictureBoxClock.Height / 2;

            // Фон часов
            g.FillEllipse(backgroundBrush, centerX - clockRadius, centerY - clockRadius, 2 * clockRadius, 2 * clockRadius);

            // Засечки
            for (int mark = 0; mark < 60; mark++)
            {
                double angle = mark * 6;
                double angleRadians = angle * Math.PI / 180;
                int markLength = (mark % 5 == 0) ? 10 : 5;
                int startX = (int)(centerX + (clockRadius - markLength) * Math.Cos(angleRadians));
                int startY = (int)(centerY + (clockRadius - markLength) * Math.Sin(angleRadians));
                int endX = (int)(centerX + clockRadius * Math.Cos(angleRadians));
                int endY = (int)(centerY + clockRadius * Math.Sin(angleRadians));

                g.DrawLine(new Pen(marksColor), startX, startY, endX, endY);
            }

            // Числа часов
            for (int i = 1; i <= 12; i++)
            {
                double angle = (i - 3) * 30;
                double angleRadians = angle * Math.PI / 180;
                int digitX = (int)(centerX + clockRadius * 0.9 * Math.Cos(angleRadians));
                int digitY = (int)(centerY + clockRadius * 0.9 * Math.Sin(angleRadians));
                g.DrawString(i.ToString(), Font, digitBrush, digitX, digitY, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }

            // Стрелки
            DrawClockHand(g, new Pen(secondsHandColor), centerX, centerY, secondHandLength, secondsRotation);
            DrawClockHand(g, new Pen(minuteHandColor), centerX, centerY, minuteHandLength, minutesRotation);
            DrawClockHand(g, new Pen(hoursHandColor), centerX, centerY, hourHandLength, hoursRotation);
        }


        private void DrawClockHand(Graphics g, Pen pen, int x, int y, int length, double angleDegrees)
        {
            double angleRadians = angleDegrees * Math.PI / 180;

            int endX = (int)(x + length * Math.Sin(angleRadians));
            int endY = (int)(y - length * Math.Cos(angleRadians));

            g.DrawLine(pen, x, y, endX, endY);
        }

        private void buttonChangeSecondsCoefficient_Click(object sender, EventArgs e)
        {
            string inputText = textBoxSecondsCoefficient.Text;
            double newSecondsCoefficient;

            if (string.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Пожалуйста, введите коэффициент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (double.TryParse(inputText, out newSecondsCoefficient))
            {
                if (newSecondsCoefficient < -100000)
                {
                    MessageBox.Show("Коэффициент должен не может быть меньше -100 000", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (newSecondsCoefficient > 100000)
                {
                    MessageBox.Show("Коэффициент не может быть больше 100 000", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                secondsCoefficient = newSecondsCoefficient;
            }
            else
            {
                MessageBox.Show("Некорректное значение коэффициента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "В центре находится поле с аналогвыми часами.\n" +
                "   - Секундная стрелка - Максимальная по длине (По умолчанию красного цвета)\n" +
                "   - Минутная стрелка - Средняя по длине (По умолчанию синего цвета)\n" +
                "   - Часовая стрелка - Минимальная по длине (По умолчанию черного цвета)\n\n" +
                "Аналогвые часы управляются с помощью меню управления расположенного слева\n\n" +
                "Раздел 'Цифровые часы'\n" +
                "   - Отображает текущее время Аналоговых часов в цифровом виде\n\n" +
                "Раздел 'Коэффициент скорости движения секундной стрелки'\n" +
                "   - Содержить поле для коэффициента скорости движения секундной стрелки\n" +
                "   Ограничения поля скорости движения секундной стрелки:\n" +
                "       - Коэффициент не может быть больше 100 000\n" +
                "       - Коэффициент не может быть меньше -100 000\n\n" +
                "Раздел 'Смена цвета стрелок'\n" +
                "   - Позволяет изменить цвет стрелки по названию соответсвующей кнопки\n\n" +
                "Раздел 'Смена цвета внутренних элементов'\n" +
                "   - Позволяет изменить цвет элементов аналогвых часов соответствующих названий\n\n" +
                "Кнопка 'Сбросить все настройки' - позволяет установить все изменяемые параметры на изначальные"
                , "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private ColorDialog colorDialog = new ColorDialog();

        private void buttonSecondsHandColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                secondsHandColor = colorDialog.Color;
                pictureBoxClock.Invalidate();
            }
        }

        private void buttonMinutesHandColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                minuteHandColor = colorDialog.Color;
                pictureBoxClock.Invalidate();
            }
        }

        private void buttonHoursHandColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                hoursHandColor = colorDialog.Color;
                pictureBoxClock.Invalidate();
            }
        }

        private void buttonMarkColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                marksColor = colorDialog.Color;
                pictureBoxClock.Invalidate();
            }
        }

        private void buttonDigitsColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                digitBrush.Color = colorDialog.Color;
                pictureBoxClock.Invalidate();
            }
        }

        private void buttonColorBackgroundClocks_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                backgroundBrush.Color = colorDialog.Color;
                pictureBoxClock.Invalidate();
            }
        }

        private void buttonResetSettings_Click(object sender, EventArgs e)
        {
            textBoxSecondsCoefficient.Text = "1";
            secondsCoefficient = 1.0;
            
            secondsHandColor = Color.Red;
            minuteHandColor = Color.Blue;
            hoursHandColor = Color.Black;

            marksColor = Color.Black;
            digitBrush.Color = Color.Black;

            backgroundBrush.Color = Color.White;

            secondsRotation = 0.0;
            minutesRotation = 0.0;
            hoursRotation = 0.0;

            labelDigitalClock.Text = "00:00:00";

            pictureBoxClock.Invalidate();
        }

    }
}
