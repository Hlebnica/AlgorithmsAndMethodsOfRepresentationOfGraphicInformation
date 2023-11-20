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
            this.buttonBuildHouse = new System.Windows.Forms.Button();
            this.comboBoxCountOfWindows = new System.Windows.Forms.ComboBox();
            this.comboBoxPlaceForWindows = new System.Windows.Forms.ComboBox();
            this.comboBoxPlaceForDoor = new System.Windows.Forms.ComboBox();
            this.comboBoxRoofType = new System.Windows.Forms.ComboBox();
            this.textBoxRoofHeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHouseWeight = new System.Windows.Forms.TextBox();
            this.textBoxHouseHeight = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonChangeHouseColor = new System.Windows.Forms.Button();
            this.buttonChangeRoofColor = new System.Windows.Forms.Button();
            this.buttonChangeDoorColor = new System.Windows.Forms.Button();
            this.buttonChangeWindowColor = new System.Windows.Forms.Button();
            this.buttonDestroyHouse = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHouse)).BeginInit();
            this.groupBoxPlaceForDoor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxHouse
            // 
            this.pictureBoxHouse.Location = new System.Drawing.Point(259, 10);
            this.pictureBoxHouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxHouse.Name = "pictureBoxHouse";
            this.pictureBoxHouse.Size = new System.Drawing.Size(627, 565);
            this.pictureBoxHouse.TabIndex = 0;
            this.pictureBoxHouse.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(259, 522);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 53);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxPlaceForDoor
            // 
            this.groupBoxPlaceForDoor.Controls.Add(this.buttonInfo);
            this.groupBoxPlaceForDoor.Controls.Add(this.buttonDestroyHouse);
            this.groupBoxPlaceForDoor.Controls.Add(this.groupBox2);
            this.groupBoxPlaceForDoor.Controls.Add(this.groupBox1);
            this.groupBoxPlaceForDoor.Controls.Add(this.buttonBuildHouse);
            this.groupBoxPlaceForDoor.Location = new System.Drawing.Point(9, 10);
            this.groupBoxPlaceForDoor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPlaceForDoor.Name = "groupBoxPlaceForDoor";
            this.groupBoxPlaceForDoor.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPlaceForDoor.Size = new System.Drawing.Size(246, 566);
            this.groupBoxPlaceForDoor.TabIndex = 2;
            this.groupBoxPlaceForDoor.TabStop = false;
            // 
            // buttonBuildHouse
            // 
            this.buttonBuildHouse.Location = new System.Drawing.Point(8, 438);
            this.buttonBuildHouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBuildHouse.Name = "buttonBuildHouse";
            this.buttonBuildHouse.Size = new System.Drawing.Size(221, 36);
            this.buttonBuildHouse.TabIndex = 6;
            this.buttonBuildHouse.Text = "Построить";
            this.buttonBuildHouse.UseVisualStyleBackColor = true;
            this.buttonBuildHouse.Click += new System.EventHandler(this.buttonBuildHouse_Click);
            // 
            // comboBoxCountOfWindows
            // 
            this.comboBoxCountOfWindows.FormattingEnabled = true;
            this.comboBoxCountOfWindows.Location = new System.Drawing.Point(5, 164);
            this.comboBoxCountOfWindows.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCountOfWindows.Name = "comboBoxCountOfWindows";
            this.comboBoxCountOfWindows.Size = new System.Drawing.Size(106, 21);
            this.comboBoxCountOfWindows.TabIndex = 5;
            this.comboBoxCountOfWindows.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountOfWindows_SelectedIndexChanged);
            // 
            // comboBoxPlaceForWindows
            // 
            this.comboBoxPlaceForWindows.FormattingEnabled = true;
            this.comboBoxPlaceForWindows.Location = new System.Drawing.Point(118, 164);
            this.comboBoxPlaceForWindows.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPlaceForWindows.Name = "comboBoxPlaceForWindows";
            this.comboBoxPlaceForWindows.Size = new System.Drawing.Size(109, 21);
            this.comboBoxPlaceForWindows.TabIndex = 5;
            // 
            // comboBoxPlaceForDoor
            // 
            this.comboBoxPlaceForDoor.FormattingEnabled = true;
            this.comboBoxPlaceForDoor.Location = new System.Drawing.Point(5, 220);
            this.comboBoxPlaceForDoor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPlaceForDoor.Name = "comboBoxPlaceForDoor";
            this.comboBoxPlaceForDoor.Size = new System.Drawing.Size(222, 21);
            this.comboBoxPlaceForDoor.TabIndex = 5;
            // 
            // comboBoxRoofType
            // 
            this.comboBoxRoofType.FormattingEnabled = true;
            this.comboBoxRoofType.Location = new System.Drawing.Point(118, 91);
            this.comboBoxRoofType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxRoofType.Name = "comboBoxRoofType";
            this.comboBoxRoofType.Size = new System.Drawing.Size(109, 21);
            this.comboBoxRoofType.TabIndex = 4;
            // 
            // textBoxRoofHeight
            // 
            this.textBoxRoofHeight.Location = new System.Drawing.Point(5, 91);
            this.textBoxRoofHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRoofHeight.Name = "textBoxRoofHeight";
            this.textBoxRoofHeight.Size = new System.Drawing.Size(109, 20);
            this.textBoxRoofHeight.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Место расположение двери";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Количество окон";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 39);
            this.label5.TabIndex = 2;
            this.label5.Text = "Место \r\nрасположения\r\nокон";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Форма крыши";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Высота крыши (от до)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ширина дома ( от до)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Высота дома (от до)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxHouseWeight
            // 
            this.textBoxHouseWeight.Location = new System.Drawing.Point(118, 43);
            this.textBoxHouseWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxHouseWeight.Name = "textBoxHouseWeight";
            this.textBoxHouseWeight.Size = new System.Drawing.Size(109, 20);
            this.textBoxHouseWeight.TabIndex = 1;
            // 
            // textBoxHouseHeight
            // 
            this.textBoxHouseHeight.Location = new System.Drawing.Point(5, 43);
            this.textBoxHouseHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxHouseHeight.Name = "textBoxHouseHeight";
            this.textBoxHouseHeight.Size = new System.Drawing.Size(109, 20);
            this.textBoxHouseHeight.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxPlaceForWindows);
            this.groupBox1.Controls.Add(this.textBoxHouseHeight);
            this.groupBox1.Controls.Add(this.comboBoxCountOfWindows);
            this.groupBox1.Controls.Add(this.textBoxHouseWeight);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxPlaceForDoor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxRoofType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxRoofHeight);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(3, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 251);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки дома";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonChangeWindowColor);
            this.groupBox2.Controls.Add(this.buttonChangeDoorColor);
            this.groupBox2.Controls.Add(this.buttonChangeRoofColor);
            this.groupBox2.Controls.Add(this.buttonChangeHouseColor);
            this.groupBox2.Location = new System.Drawing.Point(3, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 158);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки цвета";
            // 
            // buttonChangeHouseColor
            // 
            this.buttonChangeHouseColor.Location = new System.Drawing.Point(6, 19);
            this.buttonChangeHouseColor.Name = "buttonChangeHouseColor";
            this.buttonChangeHouseColor.Size = new System.Drawing.Size(221, 28);
            this.buttonChangeHouseColor.TabIndex = 0;
            this.buttonChangeHouseColor.Text = "Смена цвета дома";
            this.buttonChangeHouseColor.UseVisualStyleBackColor = true;
            this.buttonChangeHouseColor.Click += new System.EventHandler(this.buttonChangeHouseColor_Click);
            // 
            // buttonChangeRoofColor
            // 
            this.buttonChangeRoofColor.Location = new System.Drawing.Point(6, 53);
            this.buttonChangeRoofColor.Name = "buttonChangeRoofColor";
            this.buttonChangeRoofColor.Size = new System.Drawing.Size(221, 28);
            this.buttonChangeRoofColor.TabIndex = 0;
            this.buttonChangeRoofColor.Text = "Смена цвета крыши";
            this.buttonChangeRoofColor.UseVisualStyleBackColor = true;
            this.buttonChangeRoofColor.Click += new System.EventHandler(this.buttonChangeRoofColor_Click);
            // 
            // buttonChangeDoorColor
            // 
            this.buttonChangeDoorColor.Location = new System.Drawing.Point(6, 87);
            this.buttonChangeDoorColor.Name = "buttonChangeDoorColor";
            this.buttonChangeDoorColor.Size = new System.Drawing.Size(221, 28);
            this.buttonChangeDoorColor.TabIndex = 0;
            this.buttonChangeDoorColor.Text = "Смена цвета двери";
            this.buttonChangeDoorColor.UseVisualStyleBackColor = true;
            this.buttonChangeDoorColor.Click += new System.EventHandler(this.buttonChangeDoorColor_Click);
            // 
            // buttonChangeWindowColor
            // 
            this.buttonChangeWindowColor.Location = new System.Drawing.Point(6, 121);
            this.buttonChangeWindowColor.Name = "buttonChangeWindowColor";
            this.buttonChangeWindowColor.Size = new System.Drawing.Size(221, 28);
            this.buttonChangeWindowColor.TabIndex = 0;
            this.buttonChangeWindowColor.Text = "Смена цвета окон";
            this.buttonChangeWindowColor.UseVisualStyleBackColor = true;
            this.buttonChangeWindowColor.Click += new System.EventHandler(this.buttonChangeWindowColor_Click);
            // 
            // buttonDestroyHouse
            // 
            this.buttonDestroyHouse.Location = new System.Drawing.Point(8, 479);
            this.buttonDestroyHouse.Name = "buttonDestroyHouse";
            this.buttonDestroyHouse.Size = new System.Drawing.Size(221, 36);
            this.buttonDestroyHouse.TabIndex = 9;
            this.buttonDestroyHouse.Text = "Уничтожить дом";
            this.buttonDestroyHouse.UseVisualStyleBackColor = true;
            this.buttonDestroyHouse.Click += new System.EventHandler(this.buttonDestroyHouse_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(9, 521);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(221, 36);
            this.buttonInfo.TabIndex = 10;
            this.buttonInfo.Text = "Справка";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 586);
            this.Controls.Add(this.groupBoxPlaceForDoor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxHouse);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHouse)).EndInit();
            this.groupBoxPlaceForDoor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonChangeWindowColor;
        private System.Windows.Forms.Button buttonChangeDoorColor;
        private System.Windows.Forms.Button buttonChangeRoofColor;
        private System.Windows.Forms.Button buttonChangeHouseColor;
        private System.Windows.Forms.Button buttonDestroyHouse;
        private System.Windows.Forms.Button buttonInfo;
    }
}

