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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonChangeSecondsCoefficient = new System.Windows.Forms.Button();
            this.textBoxSecondsCoefficient = new System.Windows.Forms.TextBox();
            this.pictureBoxClock = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonChangeSecondsCoefficient);
            this.groupBox1.Controls.Add(this.textBoxSecondsCoefficient);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(263, 711);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonChangeSecondsCoefficient
            // 
            this.buttonChangeSecondsCoefficient.Location = new System.Drawing.Point(9, 87);
            this.buttonChangeSecondsCoefficient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonChangeSecondsCoefficient.Name = "buttonChangeSecondsCoefficient";
            this.buttonChangeSecondsCoefficient.Size = new System.Drawing.Size(236, 44);
            this.buttonChangeSecondsCoefficient.TabIndex = 1;
            this.buttonChangeSecondsCoefficient.Text = "Изменить коэффициент";
            this.buttonChangeSecondsCoefficient.UseVisualStyleBackColor = true;
            this.buttonChangeSecondsCoefficient.Click += new System.EventHandler(this.buttonChangeSecondsCoefficient_Click);
            // 
            // textBoxSecondsCoefficient
            // 
            this.textBoxSecondsCoefficient.Location = new System.Drawing.Point(9, 57);
            this.textBoxSecondsCoefficient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSecondsCoefficient.Name = "textBoxSecondsCoefficient";
            this.textBoxSecondsCoefficient.Size = new System.Drawing.Size(236, 22);
            this.textBoxSecondsCoefficient.TabIndex = 0;
            // 
            // pictureBoxClock
            // 
            this.pictureBoxClock.Location = new System.Drawing.Point(281, 58);
            this.pictureBoxClock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxClock.Name = "pictureBoxClock";
            this.pictureBoxClock.Size = new System.Drawing.Size(960, 665);
            this.pictureBoxClock.TabIndex = 1;
            this.pictureBoxClock.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Коэффициент скорости \r\nдвижения секундной стрелки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(707, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Часы";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 735);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxClock);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Старостенок КЭ-403 Индивидуальное задание Вариант 14 \"Часы\"";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).EndInit();
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
    }
}

