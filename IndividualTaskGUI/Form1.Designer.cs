namespace IndividualTaskGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChangeSecondsCoefficient = new System.Windows.Forms.Button();
            this.textBoxSecondsCoefficient = new System.Windows.Forms.TextBox();
            this.pictureBoxClock = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDigitalClock = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSecondsHandColor = new System.Windows.Forms.Button();
            this.buttonMinutesHandColor = new System.Windows.Forms.Button();
            this.buttonHoursHandColor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonMarkColor = new System.Windows.Forms.Button();
            this.buttonDigitsColor = new System.Windows.Forms.Button();
            this.buttonColorBackgroundClocks = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(221, 585);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Коэффициент скорости \r\nдвижения секундной стрелки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonChangeSecondsCoefficient
            // 
            this.buttonChangeSecondsCoefficient.Location = new System.Drawing.Point(5, 74);
            this.buttonChangeSecondsCoefficient.Name = "buttonChangeSecondsCoefficient";
            this.buttonChangeSecondsCoefficient.Size = new System.Drawing.Size(198, 36);
            this.buttonChangeSecondsCoefficient.TabIndex = 1;
            this.buttonChangeSecondsCoefficient.Text = "Изменить коэффициент";
            this.buttonChangeSecondsCoefficient.UseVisualStyleBackColor = true;
            this.buttonChangeSecondsCoefficient.Click += new System.EventHandler(this.buttonChangeSecondsCoefficient_Click);
            // 
            // textBoxSecondsCoefficient
            // 
            this.textBoxSecondsCoefficient.Location = new System.Drawing.Point(5, 48);
            this.textBoxSecondsCoefficient.Name = "textBoxSecondsCoefficient";
            this.textBoxSecondsCoefficient.Size = new System.Drawing.Size(198, 20);
            this.textBoxSecondsCoefficient.TabIndex = 0;
            // 
            // pictureBoxClock
            // 
            this.pictureBoxClock.Location = new System.Drawing.Point(4, 17);
            this.pictureBoxClock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxClock.Name = "pictureBoxClock";
            this.pictureBoxClock.Size = new System.Drawing.Size(687, 520);
            this.pictureBoxClock.TabIndex = 1;
            this.pictureBoxClock.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Аналоговые часы";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInfo.BackgroundImage")));
            this.buttonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonInfo.Location = new System.Drawing.Point(235, 10);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(33, 32);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цифровые часы";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDigitalClock
            // 
            this.labelDigitalClock.AutoSize = true;
            this.labelDigitalClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDigitalClock.Location = new System.Drawing.Point(69, 44);
            this.labelDigitalClock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDigitalClock.Name = "labelDigitalClock";
            this.labelDigitalClock.Size = new System.Drawing.Size(14, 18);
            this.labelDigitalClock.TabIndex = 2;
            this.labelDigitalClock.Text = "-";
            this.labelDigitalClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxSecondsCoefficient);
            this.groupBox2.Controls.Add(this.buttonChangeSecondsCoefficient);
            this.groupBox2.Location = new System.Drawing.Point(4, 88);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(213, 120);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonColorBackgroundClocks);
            this.groupBox3.Controls.Add(this.buttonDigitsColor);
            this.groupBox3.Controls.Add(this.buttonMarkColor);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(8, 352);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(213, 153);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBoxClock);
            this.groupBox4.Location = new System.Drawing.Point(234, 47);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(695, 541);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelDigitalClock);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(4, 13);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(213, 71);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonHoursHandColor);
            this.groupBox6.Controls.Add(this.buttonMinutesHandColor);
            this.groupBox6.Controls.Add(this.buttonSecondsHandColor);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(4, 212);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(213, 136);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Смена цвета стрелок";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSecondsHandColor
            // 
            this.buttonSecondsHandColor.Location = new System.Drawing.Point(5, 34);
            this.buttonSecondsHandColor.Name = "buttonSecondsHandColor";
            this.buttonSecondsHandColor.Size = new System.Drawing.Size(198, 27);
            this.buttonSecondsHandColor.TabIndex = 3;
            this.buttonSecondsHandColor.Text = "Цвет секундной стрелки";
            this.buttonSecondsHandColor.UseVisualStyleBackColor = true;
            this.buttonSecondsHandColor.Click += new System.EventHandler(this.buttonSecondsHandColor_Click);
            // 
            // buttonMinutesHandColor
            // 
            this.buttonMinutesHandColor.Location = new System.Drawing.Point(5, 67);
            this.buttonMinutesHandColor.Name = "buttonMinutesHandColor";
            this.buttonMinutesHandColor.Size = new System.Drawing.Size(198, 28);
            this.buttonMinutesHandColor.TabIndex = 4;
            this.buttonMinutesHandColor.Text = "Цвет минутной стрелки";
            this.buttonMinutesHandColor.UseVisualStyleBackColor = true;
            this.buttonMinutesHandColor.Click += new System.EventHandler(this.buttonMinutesHandColor_Click);
            // 
            // buttonHoursHandColor
            // 
            this.buttonHoursHandColor.Location = new System.Drawing.Point(5, 101);
            this.buttonHoursHandColor.Name = "buttonHoursHandColor";
            this.buttonHoursHandColor.Size = new System.Drawing.Size(198, 28);
            this.buttonHoursHandColor.TabIndex = 4;
            this.buttonHoursHandColor.Text = "Цвет часовой стрелки";
            this.buttonHoursHandColor.UseVisualStyleBackColor = true;
            this.buttonHoursHandColor.Click += new System.EventHandler(this.buttonHoursHandColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Смена цвета \r\nвнутренних элементов";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMarkColor
            // 
            this.buttonMarkColor.Location = new System.Drawing.Point(5, 50);
            this.buttonMarkColor.Name = "buttonMarkColor";
            this.buttonMarkColor.Size = new System.Drawing.Size(198, 27);
            this.buttonMarkColor.TabIndex = 3;
            this.buttonMarkColor.Text = "Смена цвета засечек";
            this.buttonMarkColor.UseVisualStyleBackColor = true;
            this.buttonMarkColor.Click += new System.EventHandler(this.buttonMarkColor_Click);
            // 
            // buttonDigitsColor
            // 
            this.buttonDigitsColor.Location = new System.Drawing.Point(5, 83);
            this.buttonDigitsColor.Name = "buttonDigitsColor";
            this.buttonDigitsColor.Size = new System.Drawing.Size(198, 27);
            this.buttonDigitsColor.TabIndex = 3;
            this.buttonDigitsColor.Text = "Смена цвета цифр";
            this.buttonDigitsColor.UseVisualStyleBackColor = true;
            this.buttonDigitsColor.Click += new System.EventHandler(this.buttonDigitsColor_Click);
            // 
            // buttonColorBackgroundClocks
            // 
            this.buttonColorBackgroundClocks.Location = new System.Drawing.Point(5, 116);
            this.buttonColorBackgroundClocks.Name = "buttonColorBackgroundClocks";
            this.buttonColorBackgroundClocks.Size = new System.Drawing.Size(196, 27);
            this.buttonColorBackgroundClocks.TabIndex = 4;
            this.buttonColorBackgroundClocks.Text = "Смена цвета фона";
            this.buttonColorBackgroundClocks.UseVisualStyleBackColor = true;
            this.buttonColorBackgroundClocks.Click += new System.EventHandler(this.buttonColorBackgroundClocks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 597);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Старостенок КЭ-403 Индивидуальное задание Вариант 14 \"Часы\"";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxClock;
        private System.Windows.Forms.Button buttonChangeSecondsCoefficient;
        private System.Windows.Forms.TextBox textBoxSecondsCoefficient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label labelDigitalClock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonSecondsHandColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonHoursHandColor;
        private System.Windows.Forms.Button buttonMinutesHandColor;
        private System.Windows.Forms.Button buttonDigitsColor;
        private System.Windows.Forms.Button buttonMarkColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonColorBackgroundClocks;
    }
}

