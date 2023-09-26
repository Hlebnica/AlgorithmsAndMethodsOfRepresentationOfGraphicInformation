namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox_LineType = new TextBox();
            button_Add = new Button();
            button_SeeChoice = new Button();
            listBox_ListTypesForLines = new ListBox();
            listBox_UserChoice = new ListBox();
            comboBox_ListTypesGeoFigures = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Тип линии";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 134);
            label2.Name = "label2";
            label2.Size = new Size(180, 20);
            label2.TabIndex = 0;
            label2.Text = "Список типов для линии";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 339);
            label3.Name = "label3";
            label3.Size = new Size(270, 20);
            label3.TabIndex = 0;
            label3.Text = "Список видов геометрических фигур ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 426);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 0;
            label4.Text = "Ваш выбор";
            // 
            // textBox_LineType
            // 
            textBox_LineType.Location = new Point(295, 32);
            textBox_LineType.Name = "textBox_LineType";
            textBox_LineType.Size = new Size(217, 27);
            textBox_LineType.TabIndex = 1;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(295, 66);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(217, 33);
            button_Add.TabIndex = 2;
            button_Add.Text = "Добавить";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_SeeChoice
            // 
            button_SeeChoice.Location = new Point(295, 624);
            button_SeeChoice.Name = "button_SeeChoice";
            button_SeeChoice.Size = new Size(217, 33);
            button_SeeChoice.TabIndex = 2;
            button_SeeChoice.Text = "Посмотреть";
            button_SeeChoice.UseVisualStyleBackColor = true;
            button_SeeChoice.Click += button_SeeChoice_Click;
            // 
            // listBox_ListTypesForLines
            // 
            listBox_ListTypesForLines.FormattingEnabled = true;
            listBox_ListTypesForLines.ItemHeight = 20;
            listBox_ListTypesForLines.Location = new Point(131, 157);
            listBox_ListTypesForLines.Name = "listBox_ListTypesForLines";
            listBox_ListTypesForLines.Size = new Size(553, 164);
            listBox_ListTypesForLines.TabIndex = 3;
            listBox_ListTypesForLines.SelectedIndexChanged += listBox_ListTypesForLines_SelectedIndexChanged;
            // 
            // listBox_UserChoice
            // 
            listBox_UserChoice.FormattingEnabled = true;
            listBox_UserChoice.ItemHeight = 20;
            listBox_UserChoice.Location = new Point(131, 454);
            listBox_UserChoice.Name = "listBox_UserChoice";
            listBox_UserChoice.Size = new Size(553, 164);
            listBox_UserChoice.TabIndex = 3;
            // 
            // comboBox_ListTypesGeoFigures
            // 
            comboBox_ListTypesGeoFigures.FormattingEnabled = true;
            comboBox_ListTypesGeoFigures.Location = new Point(245, 364);
            comboBox_ListTypesGeoFigures.Name = "comboBox_ListTypesGeoFigures";
            comboBox_ListTypesGeoFigures.Size = new Size(306, 28);
            comboBox_ListTypesGeoFigures.TabIndex = 4;
            comboBox_ListTypesGeoFigures.SelectedIndexChanged += comboBox_ListTypesGeoFigures_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 697);
            Controls.Add(comboBox_ListTypesGeoFigures);
            Controls.Add(listBox_UserChoice);
            Controls.Add(listBox_ListTypesForLines);
            Controls.Add(button_SeeChoice);
            Controls.Add(button_Add);
            Controls.Add(textBox_LineType);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Лабораторная работа № 2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_LineType;
        private Button button_Add;
        private Button button_SeeChoice;
        private ListBox listBox_ListTypesForLines;
        private ListBox listBox_UserChoice;
        private ComboBox comboBox_ListTypesGeoFigures;
    }
}