﻿namespace lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_DrawingObject = new System.Windows.Forms.ComboBox();
            this.button_ClearForm = new System.Windows.Forms.Button();
            this.button_CreateObject = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Width = new System.Windows.Forms.TextBox();
            this.textBox_TextObject = new System.Windows.Forms.TextBox();
            this.textBox_Height = new System.Windows.Forms.TextBox();
            this.textBox_Y2 = new System.Windows.Forms.TextBox();
            this.textBox_Y1 = new System.Windows.Forms.TextBox();
            this.textBox_X2 = new System.Windows.Forms.TextBox();
            this.textBox_X1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_DrawingObject);
            this.groupBox1.Controls.Add(this.button_ClearForm);
            this.groupBox1.Controls.Add(this.button_CreateObject);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Width);
            this.groupBox1.Controls.Add(this.textBox_TextObject);
            this.groupBox1.Controls.Add(this.textBox_Height);
            this.groupBox1.Controls.Add(this.textBox_Y2);
            this.groupBox1.Controls.Add(this.textBox_Y1);
            this.groupBox1.Controls.Add(this.textBox_X2);
            this.groupBox1.Controls.Add(this.textBox_X1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Работа с объектами";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox_DrawingObject
            // 
            this.comboBox_DrawingObject.FormattingEnabled = true;
            this.comboBox_DrawingObject.Location = new System.Drawing.Point(420, 97);
            this.comboBox_DrawingObject.Name = "comboBox_DrawingObject";
            this.comboBox_DrawingObject.Size = new System.Drawing.Size(121, 21);
            this.comboBox_DrawingObject.TabIndex = 3;
            this.comboBox_DrawingObject.SelectedIndexChanged += new System.EventHandler(this.comboBox_DrawingObject_SelectedIndexChanged);
            // 
            // button_ClearForm
            // 
            this.button_ClearForm.Location = new System.Drawing.Point(577, 81);
            this.button_ClearForm.Name = "button_ClearForm";
            this.button_ClearForm.Size = new System.Drawing.Size(235, 41);
            this.button_ClearForm.TabIndex = 2;
            this.button_ClearForm.Text = "Очистить форму";
            this.button_ClearForm.UseVisualStyleBackColor = true;
            this.button_ClearForm.Click += new System.EventHandler(this.button_ClearForm_Click);
            // 
            // button_CreateObject
            // 
            this.button_CreateObject.Location = new System.Drawing.Point(577, 20);
            this.button_CreateObject.Name = "button_CreateObject";
            this.button_CreateObject.Size = new System.Drawing.Size(235, 41);
            this.button_CreateObject.TabIndex = 2;
            this.button_CreateObject.Text = "Создать объект";
            this.button_CreateObject.UseVisualStyleBackColor = true;
            this.button_CreateObject.Click += new System.EventHandler(this.button_CreateObject_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ширина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Y2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Объект для рисования";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Текст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Высота";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Y1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X1";
            // 
            // textBox_Width
            // 
            this.textBox_Width.Location = new System.Drawing.Point(286, 97);
            this.textBox_Width.Name = "textBox_Width";
            this.textBox_Width.Size = new System.Drawing.Size(100, 20);
            this.textBox_Width.TabIndex = 0;
            // 
            // textBox_TextObject
            // 
            this.textBox_TextObject.Location = new System.Drawing.Point(420, 41);
            this.textBox_TextObject.Name = "textBox_TextObject";
            this.textBox_TextObject.Size = new System.Drawing.Size(120, 20);
            this.textBox_TextObject.TabIndex = 0;
            // 
            // textBox_Height
            // 
            this.textBox_Height.Location = new System.Drawing.Point(286, 41);
            this.textBox_Height.Name = "textBox_Height";
            this.textBox_Height.Size = new System.Drawing.Size(100, 20);
            this.textBox_Height.TabIndex = 0;
            // 
            // textBox_Y2
            // 
            this.textBox_Y2.Location = new System.Drawing.Point(149, 97);
            this.textBox_Y2.Name = "textBox_Y2";
            this.textBox_Y2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Y2.TabIndex = 0;
            // 
            // textBox_Y1
            // 
            this.textBox_Y1.Location = new System.Drawing.Point(19, 97);
            this.textBox_Y1.Name = "textBox_Y1";
            this.textBox_Y1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Y1.TabIndex = 0;
            // 
            // textBox_X2
            // 
            this.textBox_X2.Location = new System.Drawing.Point(149, 41);
            this.textBox_X2.Name = "textBox_X2";
            this.textBox_X2.Size = new System.Drawing.Size(100, 20);
            this.textBox_X2.TabIndex = 0;
            // 
            // textBox_X1
            // 
            this.textBox_X1.Location = new System.Drawing.Point(22, 41);
            this.textBox_X1.Name = "textBox_X1";
            this.textBox_X1.Size = new System.Drawing.Size(100, 20);
            this.textBox_X1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(818, 371);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 537);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа № 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Width;
        private System.Windows.Forms.TextBox textBox_Height;
        private System.Windows.Forms.TextBox textBox_Y2;
        private System.Windows.Forms.TextBox textBox_Y1;
        private System.Windows.Forms.TextBox textBox_X2;
        private System.Windows.Forms.TextBox textBox_X1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_ClearForm;
        private System.Windows.Forms.Button button_CreateObject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_TextObject;
        private System.Windows.Forms.ComboBox comboBox_DrawingObject;
        private System.Windows.Forms.Label label8;
    }
}

