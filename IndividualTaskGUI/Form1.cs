﻿using System;
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

        public Form1()
        {
            InitializeComponent();

            // Создаем таймер для обновления времени каждую секунду
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            // Подписываемся на событие Paint pictureBox
            pictureBoxClock.Paint += pictureBoxClock_Paint;

            // Задаем значение по умолчанию для textBoxSecondsCoefficient
            textBoxSecondsCoefficient.Text = "1";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Перерисовываем часы при каждом тике таймера
            pictureBoxClock.Invalidate();
        }

        private void pictureBoxClock_Paint(object sender, PaintEventArgs e)
        {
            // Получаем объект Graphics для рисования на PictureBox
            Graphics g = e.Graphics;

            // Очищаем изображение
            g.Clear(pictureBoxClock.BackColor);

            // Определение центра часов
            int centerX = pictureBoxClock.Width / 2;
            int centerY = pictureBoxClock.Height / 2;

            // Отрисовка часового круга
            g.FillEllipse(Brushes.White, centerX - clockRadius, centerY - clockRadius, 2 * clockRadius, 2 * clockRadius);

            // Рисуем засечки для часов и минут
            for (int mark = 0; mark < 60; mark++)
            {
                double angle = mark * 6; // Каждая засечка находится под углом 6 градусов
                double angleRadians = angle * Math.PI / 180;
                int markLength = (mark % 5 == 0) ? 10 : 5; // Длина для каждой 5-й метки больше
                int startX = (int)(centerX + (clockRadius - markLength) * Math.Cos(angleRadians));
                int startY = (int)(centerY + (clockRadius - markLength) * Math.Sin(angleRadians));
                int endX = (int)(centerX + clockRadius * Math.Cos(angleRadians));
                int endY = (int)(centerY + clockRadius * Math.Sin(angleRadians));

                // Рисуем засечку
                g.DrawLine(Pens.Black, startX, startY, endX, endY);
            }

            // Рисуем цифры от 1 до 12 вокруг эллипса
            for (int i = 1; i <= 12; i++)
            {
                double angle = (i - 3) * 30; // Отступаем на 3 часа и умножаем на 30 градусов
                double angleRadians = angle * Math.PI / 180;
                int digitX = (int)(centerX + clockRadius * 0.9 * Math.Cos(angleRadians)); // Уменьшаем радиус для цифр
                int digitY = (int)(centerY + clockRadius * 0.9 * Math.Sin(angleRadians));

                // Рисуем цифру
                g.DrawString(i.ToString(), Font, Brushes.Black, digitX, digitY, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }

            // Получаем текущее время
            DateTime currentTime = DateTime.Now;

            // Отрисовка секундной стрелки
            DrawClockHand(g, Pens.Red, centerX, centerY, secondHandLength, currentTime.Second * 6);

            // Отрисовка минутной стрелки
            DrawClockHand(g, Pens.Blue, centerX, centerY, minuteHandLength, (currentTime.Minute * 6) + (currentTime.Second * 0.1));

            // Отрисовка часовой стрелки
            DrawClockHand(g, Pens.Black, centerX, centerY, hourHandLength, (currentTime.Hour % 12 * 30) + (currentTime.Minute * 0.5));
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

        }
    }
}
