namespace BuldingHouseGUI
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
            this.pictureBoxHouse = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxPlaceForDoor = new System.Windows.Forms.GroupBox();
            this.textBoxHouseHeight = new System.Windows.Forms.TextBox();
            this.textBoxHouseWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRoofHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRoofType = new System.Windows.Forms.ComboBox();
            this.comboBoxPlaceForDoor = new System.Windows.Forms.ComboBox();
            this.comboBoxPlaceForWindows = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBuildHouse = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCountOfWindows = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHouse)).BeginInit();
            this.groupBoxPlaceForDoor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxHouse
            // 
            this.pictureBoxHouse.Location = new System.Drawing.Point(295, 12);
            this.pictureBoxHouse.Name = "pictureBoxHouse";
            this.pictureBoxHouse.Size = new System.Drawing.Size(887, 640);
            this.pictureBoxHouse.TabIndex = 0;
            this.pictureBoxHouse.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(295, 654);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 58);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxPlaceForDoor
            // 
            this.groupBoxPlaceForDoor.Controls.Add(this.buttonBuildHouse);
            this.groupBoxPlaceForDoor.Controls.Add(this.comboBoxCountOfWindows);
            this.groupBoxPlaceForDoor.Controls.Add(this.comboBoxPlaceForWindows);
            this.groupBoxPlaceForDoor.Controls.Add(this.comboBoxPlaceForDoor);
            this.groupBoxPlaceForDoor.Controls.Add(this.comboBoxRoofType);
            this.groupBoxPlaceForDoor.Controls.Add(this.textBoxRoofHeight);
            this.groupBoxPlaceForDoor.Controls.Add(this.label6);
            this.groupBoxPlaceForDoor.Controls.Add(this.label7);
            this.groupBoxPlaceForDoor.Controls.Add(this.label5);
            this.groupBoxPlaceForDoor.Controls.Add(this.label4);
            this.groupBoxPlaceForDoor.Controls.Add(this.label3);
            this.groupBoxPlaceForDoor.Controls.Add(this.label2);
            this.groupBoxPlaceForDoor.Controls.Add(this.label1);
            this.groupBoxPlaceForDoor.Controls.Add(this.textBoxHouseWeight);
            this.groupBoxPlaceForDoor.Controls.Add(this.textBoxHouseHeight);
            this.groupBoxPlaceForDoor.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPlaceForDoor.Name = "groupBoxPlaceForDoor";
            this.groupBoxPlaceForDoor.Size = new System.Drawing.Size(277, 697);
            this.groupBoxPlaceForDoor.TabIndex = 2;
            this.groupBoxPlaceForDoor.TabStop = false;
            // 
            // textBoxHouseHeight
            // 
            this.textBoxHouseHeight.Location = new System.Drawing.Point(6, 45);
            this.textBoxHouseHeight.Name = "textBoxHouseHeight";
            this.textBoxHouseHeight.Size = new System.Drawing.Size(265, 22);
            this.textBoxHouseHeight.TabIndex = 0;
            // 
            // textBoxHouseWeight
            // 
            this.textBoxHouseWeight.Location = new System.Drawing.Point(6, 111);
            this.textBoxHouseWeight.Name = "textBoxHouseWeight";
            this.textBoxHouseWeight.Size = new System.Drawing.Size(265, 22);
            this.textBoxHouseWeight.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Высота дома";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ширина дома";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Высота крыши";
            // 
            // textBoxRoofHeight
            // 
            this.textBoxRoofHeight.Location = new System.Drawing.Point(6, 176);
            this.textBoxRoofHeight.Name = "textBoxRoofHeight";
            this.textBoxRoofHeight.Size = new System.Drawing.Size(265, 22);
            this.textBoxRoofHeight.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Форма крыши";
            // 
            // comboBoxRoofType
            // 
            this.comboBoxRoofType.FormattingEnabled = true;
            this.comboBoxRoofType.Location = new System.Drawing.Point(6, 254);
            this.comboBoxRoofType.Name = "comboBoxRoofType";
            this.comboBoxRoofType.Size = new System.Drawing.Size(265, 24);
            this.comboBoxRoofType.TabIndex = 4;
            // 
            // comboBoxPlaceForDoor
            // 
            this.comboBoxPlaceForDoor.FormattingEnabled = true;
            this.comboBoxPlaceForDoor.Location = new System.Drawing.Point(6, 454);
            this.comboBoxPlaceForDoor.Name = "comboBoxPlaceForDoor";
            this.comboBoxPlaceForDoor.Size = new System.Drawing.Size(265, 24);
            this.comboBoxPlaceForDoor.TabIndex = 5;
            // 
            // comboBoxPlaceForWindows
            // 
            this.comboBoxPlaceForWindows.FormattingEnabled = true;
            this.comboBoxPlaceForWindows.Location = new System.Drawing.Point(6, 388);
            this.comboBoxPlaceForWindows.Name = "comboBoxPlaceForWindows";
            this.comboBoxPlaceForWindows.Size = new System.Drawing.Size(265, 24);
            this.comboBoxPlaceForWindows.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Место расположения окон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Место расположение двери";
            // 
            // buttonBuildHouse
            // 
            this.buttonBuildHouse.Location = new System.Drawing.Point(6, 535);
            this.buttonBuildHouse.Name = "buttonBuildHouse";
            this.buttonBuildHouse.Size = new System.Drawing.Size(265, 44);
            this.buttonBuildHouse.TabIndex = 6;
            this.buttonBuildHouse.Text = "Построить";
            this.buttonBuildHouse.UseVisualStyleBackColor = true;
            this.buttonBuildHouse.Click += new System.EventHandler(this.buttonBuildHouse_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Количество окон";
            // 
            // comboBoxCountOfWindows
            // 
            this.comboBoxCountOfWindows.FormattingEnabled = true;
            this.comboBoxCountOfWindows.Location = new System.Drawing.Point(6, 324);
            this.comboBoxCountOfWindows.Name = "comboBoxCountOfWindows";
            this.comboBoxCountOfWindows.Size = new System.Drawing.Size(265, 24);
            this.comboBoxCountOfWindows.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 721);
            this.Controls.Add(this.groupBoxPlaceForDoor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxHouse);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHouse)).EndInit();
            this.groupBoxPlaceForDoor.ResumeLayout(false);
            this.groupBoxPlaceForDoor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHouse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxPlaceForDoor;
        private System.Windows.Forms.TextBox textBoxHouseHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHouseWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRoofHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRoofType;
        private System.Windows.Forms.ComboBox comboBoxPlaceForWindows;
        private System.Windows.Forms.ComboBox comboBoxPlaceForDoor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonBuildHouse;
        private System.Windows.Forms.ComboBox comboBoxCountOfWindows;
        private System.Windows.Forms.Label label7;
    }
}

