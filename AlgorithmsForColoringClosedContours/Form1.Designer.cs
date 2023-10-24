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
            this.buttonLineByLineFilling = new System.Windows.Forms.Button();
            this.buttonSeedFilling = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonColorPicker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForFigure)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxForFigure
            // 
            this.pictureBoxForFigure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxForFigure.Location = new System.Drawing.Point(214, 18);
            this.pictureBoxForFigure.Name = "pictureBoxForFigure";
            this.pictureBoxForFigure.Size = new System.Drawing.Size(747, 603);
            this.pictureBoxForFigure.TabIndex = 2;
            this.pictureBoxForFigure.TabStop = false;
            this.pictureBoxForFigure.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxForFigure_MouseClick);
            // 
            // buttonCreateFigure
            // 
            this.buttonCreateFigure.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateFigure.Location = new System.Drawing.Point(5, 18);
            this.buttonCreateFigure.Name = "buttonCreateFigure";
            this.buttonCreateFigure.Size = new System.Drawing.Size(190, 44);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(200, 612);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // buttonLineByLineFilling
            // 
            this.buttonLineByLineFilling.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLineByLineFilling.Location = new System.Drawing.Point(4, 228);
            this.buttonLineByLineFilling.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLineByLineFilling.Name = "buttonLineByLineFilling";
            this.buttonLineByLineFilling.Size = new System.Drawing.Size(190, 57);
            this.buttonLineByLineFilling.TabIndex = 7;
            this.buttonLineByLineFilling.Text = "Построчное сканирование";
            this.buttonLineByLineFilling.UseVisualStyleBackColor = true;
            this.buttonLineByLineFilling.Click += new System.EventHandler(this.buttonLineByLineFilling_Click);
            // 
            // buttonSeedFilling
            // 
            this.buttonSeedFilling.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeedFilling.Location = new System.Drawing.Point(4, 166);
            this.buttonSeedFilling.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSeedFilling.Name = "buttonSeedFilling";
            this.buttonSeedFilling.Size = new System.Drawing.Size(190, 48);
            this.buttonSeedFilling.TabIndex = 6;
            this.buttonSeedFilling.Text = "Заливка с затравкой";
            this.buttonSeedFilling.UseVisualStyleBackColor = true;
            this.buttonSeedFilling.Click += new System.EventHandler(this.buttonSeedFilling_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Виды заливки";
            // 
            // buttonColorPicker
            // 
            this.buttonColorPicker.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColorPicker.Location = new System.Drawing.Point(4, 67);
            this.buttonColorPicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonColorPicker.Name = "buttonColorPicker";
            this.buttonColorPicker.Size = new System.Drawing.Size(190, 44);
            this.buttonColorPicker.TabIndex = 4;
            this.buttonColorPicker.Text = "Выбрать цвет";
            this.buttonColorPicker.UseVisualStyleBackColor = true;
            this.buttonColorPicker.Click += new System.EventHandler(this.buttonColorPicker_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 632);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxForFigure);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

