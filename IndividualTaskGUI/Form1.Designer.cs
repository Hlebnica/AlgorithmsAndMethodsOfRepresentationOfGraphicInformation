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
            this.buttonResetSettings = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSecondsCoefficient = new System.Windows.Forms.TextBox();
            this.buttonChangeSecondsCoefficient = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelDigitalClock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonHoursHandColor = new System.Windows.Forms.Button();
            this.buttonMinutesHandColor = new System.Windows.Forms.Button();
            this.buttonSecondsHandColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonColorBackgroundClocks = new System.Windows.Forms.Button();
            this.buttonDigitsColor = new System.Windows.Forms.Button();
            this.buttonMarkColor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxClock = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonResetSettings);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(295, 720);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonResetSettings
            // 
            this.buttonResetSettings.Location = new System.Drawing.Point(12, 677);
            this.buttonResetSettings.Name = "buttonResetSettings";
            this.buttonResetSettings.Size = new System.Drawing.Size(263, 33);
            this.buttonResetSettings.TabIndex = 1;
            this.buttonResetSettings.Text = "Сбросить все настройки";
            this.buttonResetSettings.UseVisualStyleBackColor = true;
            this.buttonResetSettings.Click += new System.EventHandler(this.buttonResetSettings_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxSecondsCoefficient);
            this.groupBox2.Controls.Add(this.buttonChangeSecondsCoefficient);
            this.groupBox2.Location = new System.Drawing.Point(5, 97);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(284, 180);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Коэффициент скорости \r\nдвижения секундной стрелки\r\n(от -100 000 до 100 000)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSecondsCoefficient
            // 
            this.textBoxSecondsCoefficient.Location = new System.Drawing.Point(7, 87);
            this.textBoxSecondsCoefficient.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSecondsCoefficient.Name = "textBoxSecondsCoefficient";
            this.textBoxSecondsCoefficient.Size = new System.Drawing.Size(263, 22);
            this.textBoxSecondsCoefficient.TabIndex = 0;
            // 
            // buttonChangeSecondsCoefficient
            // 
            this.buttonChangeSecondsCoefficient.Location = new System.Drawing.Point(7, 117);
            this.buttonChangeSecondsCoefficient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChangeSecondsCoefficient.Name = "buttonChangeSecondsCoefficient";
            this.buttonChangeSecondsCoefficient.Size = new System.Drawing.Size(264, 44);
            this.buttonChangeSecondsCoefficient.TabIndex = 1;
            this.buttonChangeSecondsCoefficient.Text = "Изменить коэффициент";
            this.buttonChangeSecondsCoefficient.UseVisualStyleBackColor = true;
            this.buttonChangeSecondsCoefficient.Click += new System.EventHandler(this.buttonChangeSecondsCoefficient_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelDigitalClock);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(5, 16);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(284, 77);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // labelDigitalClock
            // 
            this.labelDigitalClock.AutoSize = true;
            this.labelDigitalClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDigitalClock.Location = new System.Drawing.Point(92, 45);
            this.labelDigitalClock.Name = "labelDigitalClock";
            this.labelDigitalClock.Size = new System.Drawing.Size(17, 24);
            this.labelDigitalClock.TabIndex = 2;
            this.labelDigitalClock.Text = "-";
            this.labelDigitalClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цифровые часы";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonHoursHandColor);
            this.groupBox6.Controls.Add(this.buttonMinutesHandColor);
            this.groupBox6.Controls.Add(this.buttonSecondsHandColor);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(6, 281);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(284, 167);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // buttonHoursHandColor
            // 
            this.buttonHoursHandColor.Location = new System.Drawing.Point(7, 124);
            this.buttonHoursHandColor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHoursHandColor.Name = "buttonHoursHandColor";
            this.buttonHoursHandColor.Size = new System.Drawing.Size(264, 34);
            this.buttonHoursHandColor.TabIndex = 4;
            this.buttonHoursHandColor.Text = "Цвет часовой стрелки";
            this.buttonHoursHandColor.UseVisualStyleBackColor = true;
            this.buttonHoursHandColor.Click += new System.EventHandler(this.buttonHoursHandColor_Click);
            // 
            // buttonMinutesHandColor
            // 
            this.buttonMinutesHandColor.Location = new System.Drawing.Point(7, 82);
            this.buttonMinutesHandColor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMinutesHandColor.Name = "buttonMinutesHandColor";
            this.buttonMinutesHandColor.Size = new System.Drawing.Size(264, 34);
            this.buttonMinutesHandColor.TabIndex = 4;
            this.buttonMinutesHandColor.Text = "Цвет минутной стрелки";
            this.buttonMinutesHandColor.UseVisualStyleBackColor = true;
            this.buttonMinutesHandColor.Click += new System.EventHandler(this.buttonMinutesHandColor_Click);
            // 
            // buttonSecondsHandColor
            // 
            this.buttonSecondsHandColor.Location = new System.Drawing.Point(7, 42);
            this.buttonSecondsHandColor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSecondsHandColor.Name = "buttonSecondsHandColor";
            this.buttonSecondsHandColor.Size = new System.Drawing.Size(264, 33);
            this.buttonSecondsHandColor.TabIndex = 3;
            this.buttonSecondsHandColor.Text = "Цвет секундной стрелки";
            this.buttonSecondsHandColor.UseVisualStyleBackColor = true;
            this.buttonSecondsHandColor.Click += new System.EventHandler(this.buttonSecondsHandColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Смена цвета стрелок";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonColorBackgroundClocks);
            this.groupBox3.Controls.Add(this.buttonDigitsColor);
            this.groupBox3.Controls.Add(this.buttonMarkColor);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(5, 452);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(284, 188);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // buttonColorBackgroundClocks
            // 
            this.buttonColorBackgroundClocks.Location = new System.Drawing.Point(7, 143);
            this.buttonColorBackgroundClocks.Margin = new System.Windows.Forms.Padding(4);
            this.buttonColorBackgroundClocks.Name = "buttonColorBackgroundClocks";
            this.buttonColorBackgroundClocks.Size = new System.Drawing.Size(264, 33);
            this.buttonColorBackgroundClocks.TabIndex = 4;
            this.buttonColorBackgroundClocks.Text = "Смена цвета фона";
            this.buttonColorBackgroundClocks.UseVisualStyleBackColor = true;
            this.buttonColorBackgroundClocks.Click += new System.EventHandler(this.buttonColorBackgroundClocks_Click);
            // 
            // buttonDigitsColor
            // 
            this.buttonDigitsColor.Location = new System.Drawing.Point(7, 102);
            this.buttonDigitsColor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDigitsColor.Name = "buttonDigitsColor";
            this.buttonDigitsColor.Size = new System.Drawing.Size(264, 33);
            this.buttonDigitsColor.TabIndex = 3;
            this.buttonDigitsColor.Text = "Смена цвета цифр";
            this.buttonDigitsColor.UseVisualStyleBackColor = true;
            this.buttonDigitsColor.Click += new System.EventHandler(this.buttonDigitsColor_Click);
            // 
            // buttonMarkColor
            // 
            this.buttonMarkColor.Location = new System.Drawing.Point(7, 62);
            this.buttonMarkColor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMarkColor.Name = "buttonMarkColor";
            this.buttonMarkColor.Size = new System.Drawing.Size(264, 33);
            this.buttonMarkColor.TabIndex = 3;
            this.buttonMarkColor.Text = "Смена цвета засечек";
            this.buttonMarkColor.UseVisualStyleBackColor = true;
            this.buttonMarkColor.Click += new System.EventHandler(this.buttonMarkColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "Смена цвета \r\nвнутренних элементов";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxClock
            // 
            this.pictureBoxClock.Location = new System.Drawing.Point(5, 21);
            this.pictureBoxClock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxClock.Name = "pictureBoxClock";
            this.pictureBoxClock.Size = new System.Drawing.Size(916, 640);
            this.pictureBoxClock.TabIndex = 1;
            this.pictureBoxClock.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(627, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Аналоговые часы";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInfo.BackgroundImage")));
            this.buttonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonInfo.Location = new System.Drawing.Point(313, 12);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(44, 39);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBoxClock);
            this.groupBox4.Location = new System.Drawing.Point(312, 58);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(927, 666);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 735);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Старостенок КЭ-403 Индивидуальное задание Вариант 14 \"Часы\"";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).EndInit();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonResetSettings;
        private System.Windows.Forms.Label labelDigitalClock;
        private System.Windows.Forms.Label label3;
    }
}

