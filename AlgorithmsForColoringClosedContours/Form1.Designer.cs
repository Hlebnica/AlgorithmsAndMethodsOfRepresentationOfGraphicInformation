namespace AlgorithmsForColoringClosedContours
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
            this.pictureBoxForFigure = new System.Windows.Forms.PictureBox();
            this.buttonCreateFigure = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonColorPicker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSeedFilling = new System.Windows.Forms.Button();
            this.buttonLineByLineFilling = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForFigure)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxForFigure
            // 
            this.pictureBoxForFigure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxForFigure.Location = new System.Drawing.Point(286, 22);
            this.pictureBoxForFigure.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxForFigure.Name = "pictureBoxForFigure";
            this.pictureBoxForFigure.Size = new System.Drawing.Size(996, 742);
            this.pictureBoxForFigure.TabIndex = 2;
            this.pictureBoxForFigure.TabStop = false;
            // 
            // buttonCreateFigure
            // 
            this.buttonCreateFigure.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateFigure.Location = new System.Drawing.Point(7, 22);
            this.buttonCreateFigure.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateFigure.Name = "buttonCreateFigure";
            this.buttonCreateFigure.Size = new System.Drawing.Size(253, 54);
            this.buttonCreateFigure.TabIndex = 3;
            this.buttonCreateFigure.Text = "Создать фигуру";
            this.buttonCreateFigure.UseVisualStyleBackColor = true;
            this.buttonCreateFigure.Click += new System.EventHandler(this.buttonCreateFigure_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLineByLineFilling);
            this.groupBox1.Controls.Add(this.buttonSeedFilling);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonColorPicker);
            this.groupBox1.Controls.Add(this.buttonCreateFigure);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 753);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // buttonColorPicker
            // 
            this.buttonColorPicker.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColorPicker.Location = new System.Drawing.Point(6, 83);
            this.buttonColorPicker.Name = "buttonColorPicker";
            this.buttonColorPicker.Size = new System.Drawing.Size(253, 54);
            this.buttonColorPicker.TabIndex = 4;
            this.buttonColorPicker.Text = "Выбрать цвет";
            this.buttonColorPicker.UseVisualStyleBackColor = true;
            this.buttonColorPicker.Click += new System.EventHandler(this.buttonColorPicker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Виды заливки";
            // 
            // buttonSeedFilling
            // 
            this.buttonSeedFilling.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeedFilling.Location = new System.Drawing.Point(6, 204);
            this.buttonSeedFilling.Name = "buttonSeedFilling";
            this.buttonSeedFilling.Size = new System.Drawing.Size(253, 59);
            this.buttonSeedFilling.TabIndex = 6;
            this.buttonSeedFilling.Text = "Заливка с затравкой";
            this.buttonSeedFilling.UseVisualStyleBackColor = true;
            this.buttonSeedFilling.Click += new System.EventHandler(this.buttonSeedFilling_Click);
            // 
            // buttonLineByLineFilling
            // 
            this.buttonLineByLineFilling.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLineByLineFilling.Location = new System.Drawing.Point(6, 281);
            this.buttonLineByLineFilling.Name = "buttonLineByLineFilling";
            this.buttonLineByLineFilling.Size = new System.Drawing.Size(253, 70);
            this.buttonLineByLineFilling.TabIndex = 7;
            this.buttonLineByLineFilling.Text = "Построчное сканирование";
            this.buttonLineByLineFilling.UseVisualStyleBackColor = true;
            this.buttonLineByLineFilling.Click += new System.EventHandler(this.buttonLineByLineFilling_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 778);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxForFigure);
            this.Name = "Form1";
            this.Text = "Старостенок КЭ-403 Алгоритмы закраски замкнутых контуров";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForFigure)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxForFigure;
        private System.Windows.Forms.Button buttonCreateFigure;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonColorPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLineByLineFilling;
        private System.Windows.Forms.Button buttonSeedFilling;
    }
}

