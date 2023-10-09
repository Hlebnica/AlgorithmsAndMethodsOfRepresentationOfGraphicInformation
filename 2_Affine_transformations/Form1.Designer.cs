namespace _2_Affine_transformations
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
            this.buttonCreateFigure = new System.Windows.Forms.Button();
            this.textBoxX_Move = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMoveFigure = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxY_Move = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_Rotate = new System.Windows.Forms.TextBox();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxY_Scale = new System.Windows.Forms.TextBox();
            this.textBoxX_Scale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonScale = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxForFigure = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForFigure)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.buttonCreateFigure);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 525);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonCreateFigure
            // 
            this.buttonCreateFigure.Location = new System.Drawing.Point(6, 14);
            this.buttonCreateFigure.Name = "buttonCreateFigure";
            this.buttonCreateFigure.Size = new System.Drawing.Size(133, 49);
            this.buttonCreateFigure.TabIndex = 0;
            this.buttonCreateFigure.Text = "Создать фигуру";
            this.buttonCreateFigure.UseVisualStyleBackColor = true;
            this.buttonCreateFigure.Click += new System.EventHandler(this.buttonCreateFigure_Click);
            // 
            // textBoxX_Move
            // 
            this.textBoxX_Move.Location = new System.Drawing.Point(6, 31);
            this.textBoxX_Move.Name = "textBoxX_Move";
            this.textBoxX_Move.Size = new System.Drawing.Size(117, 20);
            this.textBoxX_Move.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // buttonMoveFigure
            // 
            this.buttonMoveFigure.Location = new System.Drawing.Point(6, 100);
            this.buttonMoveFigure.Name = "buttonMoveFigure";
            this.buttonMoveFigure.Size = new System.Drawing.Size(117, 43);
            this.buttonMoveFigure.TabIndex = 3;
            this.buttonMoveFigure.Text = "Переместить";
            this.buttonMoveFigure.UseVisualStyleBackColor = true;
            this.buttonMoveFigure.Click += new System.EventHandler(this.buttonMoveFigure_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxY_Move);
            this.groupBox2.Controls.Add(this.textBoxX_Move);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonMoveFigure);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 157);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Перемещение";
            // 
            // textBoxY_Move
            // 
            this.textBoxY_Move.Location = new System.Drawing.Point(6, 74);
            this.textBoxY_Move.Name = "textBoxY_Move";
            this.textBoxY_Move.Size = new System.Drawing.Size(117, 20);
            this.textBoxY_Move.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_Rotate);
            this.groupBox3.Controls.Add(this.buttonRotate);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(133, 120);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поворот";
            // 
            // textBox_Rotate
            // 
            this.textBox_Rotate.Location = new System.Drawing.Point(6, 36);
            this.textBox_Rotate.Name = "textBox_Rotate";
            this.textBox_Rotate.Size = new System.Drawing.Size(117, 20);
            this.textBox_Rotate.TabIndex = 1;
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(6, 67);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(117, 43);
            this.buttonRotate.TabIndex = 3;
            this.buttonRotate.Text = "Повернуть";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Угол поворота";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxY_Scale);
            this.groupBox4.Controls.Add(this.textBoxX_Scale);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.buttonScale);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(6, 358);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(133, 157);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Масштабирование";
            // 
            // textBoxY_Scale
            // 
            this.textBoxY_Scale.Location = new System.Drawing.Point(6, 74);
            this.textBoxY_Scale.Name = "textBoxY_Scale";
            this.textBoxY_Scale.Size = new System.Drawing.Size(117, 20);
            this.textBoxY_Scale.TabIndex = 1;
            // 
            // textBoxX_Scale
            // 
            this.textBoxX_Scale.Location = new System.Drawing.Point(6, 31);
            this.textBoxX_Scale.Name = "textBoxX_Scale";
            this.textBoxX_Scale.Size = new System.Drawing.Size(117, 20);
            this.textBoxX_Scale.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y";
            // 
            // buttonScale
            // 
            this.buttonScale.Location = new System.Drawing.Point(6, 100);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(117, 43);
            this.buttonScale.TabIndex = 3;
            this.buttonScale.Text = "Растянуть/Сжать";
            this.buttonScale.UseVisualStyleBackColor = true;
            this.buttonScale.Click += new System.EventHandler(this.buttonScale_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "X";
            // 
            // pictureBoxForFigure
            // 
            this.pictureBoxForFigure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxForFigure.Location = new System.Drawing.Point(174, 12);
            this.pictureBoxForFigure.Name = "pictureBoxForFigure";
            this.pictureBoxForFigure.Size = new System.Drawing.Size(1093, 585);
            this.pictureBoxForFigure.TabIndex = 1;
            this.pictureBoxForFigure.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 607);
            this.Controls.Add(this.pictureBoxForFigure);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Аффинные преобразования Lab2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForFigure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCreateFigure;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonMoveFigure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxX_Move;
        private System.Windows.Forms.TextBox textBoxY_Move;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_Rotate;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxY_Scale;
        private System.Windows.Forms.TextBox textBoxX_Scale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonScale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxForFigure;
    }
}

