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
            this.pictureBoxClock = new System.Windows.Forms.PictureBox();
            this.textBoxSecondsCoefficient = new System.Windows.Forms.TextBox();
            this.buttonChangeSecondsCoefficient = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonChangeSecondsCoefficient);
            this.groupBox1.Controls.Add(this.textBoxSecondsCoefficient);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(922, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBoxClock
            // 
            this.pictureBoxClock.Location = new System.Drawing.Point(9, 120);
            this.pictureBoxClock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxClock.Name = "pictureBoxClock";
            this.pictureBoxClock.Size = new System.Drawing.Size(922, 467);
            this.pictureBoxClock.TabIndex = 1;
            this.pictureBoxClock.TabStop = false;
            this.pictureBoxClock.Click += new System.EventHandler(this.pictureBoxClock_Click);
            // 
            // textBoxSecondsCoefficient
            // 
            this.textBoxSecondsCoefficient.Location = new System.Drawing.Point(5, 29);
            this.textBoxSecondsCoefficient.Name = "textBoxSecondsCoefficient";
            this.textBoxSecondsCoefficient.Size = new System.Drawing.Size(179, 20);
            this.textBoxSecondsCoefficient.TabIndex = 0;
            // 
            // buttonChangeSecondsCoefficient
            // 
            this.buttonChangeSecondsCoefficient.Location = new System.Drawing.Point(5, 55);
            this.buttonChangeSecondsCoefficient.Name = "buttonChangeSecondsCoefficient";
            this.buttonChangeSecondsCoefficient.Size = new System.Drawing.Size(179, 40);
            this.buttonChangeSecondsCoefficient.TabIndex = 1;
            this.buttonChangeSecondsCoefficient.Text = "Изменить коэффициент";
            this.buttonChangeSecondsCoefficient.UseVisualStyleBackColor = true;
            this.buttonChangeSecondsCoefficient.Click += new System.EventHandler(this.buttonChangeSecondsCoefficient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 597);
            this.Controls.Add(this.pictureBoxClock);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Старостенок КЭ-403 Индивидуальное задание Вариант 14 \"Часы\"";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxClock;
        private System.Windows.Forms.Button buttonChangeSecondsCoefficient;
        private System.Windows.Forms.TextBox textBoxSecondsCoefficient;
    }
}

