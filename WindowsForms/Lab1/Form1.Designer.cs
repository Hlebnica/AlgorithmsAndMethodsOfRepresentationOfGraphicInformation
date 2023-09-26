namespace Lab1
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
            textBox_AuthorName = new TextBox();
            label_AuthorOfProgram = new Label();
            button_Save = new Button();
            menuStrip1 = new MenuStrip();
            ToolStripMenuItem_File = new ToolStripMenuItem();
            ToolStripMenuItem_Edit = new ToolStripMenuItem();
            ToolStripMenuItem_Exit = new ToolStripMenuItem();
            ToolStripMenuItem_Information = new ToolStripMenuItem();
            ToolStripMenuItem_AuthorOfProgram = new ToolStripMenuItem();
            ToolStripMenuItem_AboutProgram = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_AuthorName
            // 
            textBox_AuthorName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_AuthorName.Location = new Point(65, 122);
            textBox_AuthorName.Margin = new Padding(4, 3, 4, 3);
            textBox_AuthorName.Name = "textBox_AuthorName";
            textBox_AuthorName.Size = new Size(390, 32);
            textBox_AuthorName.TabIndex = 0;
            // 
            // label_AuthorOfProgram
            // 
            label_AuthorOfProgram.AutoSize = true;
            label_AuthorOfProgram.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_AuthorOfProgram.Location = new Point(159, 75);
            label_AuthorOfProgram.Margin = new Padding(4, 0, 4, 0);
            label_AuthorOfProgram.Name = "label_AuthorOfProgram";
            label_AuthorOfProgram.Size = new Size(203, 23);
            label_AuthorOfProgram.TabIndex = 1;
            label_AuthorOfProgram.Text = "Автор программы:";
            // 
            // button_Save
            // 
            button_Save.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Save.Location = new Point(65, 181);
            button_Save.Margin = new Padding(4, 3, 4, 3);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(392, 52);
            button_Save.TabIndex = 2;
            button_Save.Text = "Сохранить";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem_File, ToolStripMenuItem_Information });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 2, 0, 2);
            menuStrip1.Size = new Size(534, 31);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_File
            // 
            ToolStripMenuItem_File.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_Edit, ToolStripMenuItem_Exit });
            ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            ToolStripMenuItem_File.Size = new Size(78, 27);
            ToolStripMenuItem_File.Text = "Файл";
            // 
            // ToolStripMenuItem_Edit
            // 
            ToolStripMenuItem_Edit.Name = "ToolStripMenuItem_Edit";
            ToolStripMenuItem_Edit.Size = new Size(262, 28);
            ToolStripMenuItem_Edit.Text = "Редактирование";
            ToolStripMenuItem_Edit.Click += ToolStripMenuItem_Edit_Click;
            // 
            // ToolStripMenuItem_Exit
            // 
            ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            ToolStripMenuItem_Exit.Size = new Size(262, 28);
            ToolStripMenuItem_Exit.Text = "Выход";
            ToolStripMenuItem_Exit.Click += ToolStripMenuItem_Exit_Click;
            // 
            // ToolStripMenuItem_Information
            // 
            ToolStripMenuItem_Information.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_AuthorOfProgram, ToolStripMenuItem_AboutProgram });
            ToolStripMenuItem_Information.Name = "ToolStripMenuItem_Information";
            ToolStripMenuItem_Information.Size = new Size(113, 27);
            ToolStripMenuItem_Information.Text = "Справка";
            // 
            // ToolStripMenuItem_AuthorOfProgram
            // 
            ToolStripMenuItem_AuthorOfProgram.Name = "ToolStripMenuItem_AuthorOfProgram";
            ToolStripMenuItem_AuthorOfProgram.Size = new Size(268, 28);
            ToolStripMenuItem_AuthorOfProgram.Text = "Автор пограммы";
            ToolStripMenuItem_AuthorOfProgram.Click += ToolStripMenuItem_AuthorOfProgram_Click;
            // 
            // ToolStripMenuItem_AboutProgram
            // 
            ToolStripMenuItem_AboutProgram.Name = "ToolStripMenuItem_AboutProgram";
            ToolStripMenuItem_AboutProgram.Size = new Size(268, 28);
            ToolStripMenuItem_AboutProgram.Text = "О программе";
            ToolStripMenuItem_AboutProgram.Click += ToolStripMenuItem_AboutProgram_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 281);
            Controls.Add(button_Save);
            Controls.Add(label_AuthorOfProgram);
            Controls.Add(textBox_AuthorName);
            Controls.Add(menuStrip1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Лабораторная работа № 1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_AuthorName;
        private Label label_AuthorOfProgram;
        private Button button_Save;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItem_File;
        private ToolStripMenuItem ToolStripMenuItem_Edit;
        private ToolStripMenuItem ToolStripMenuItem_Exit;
        private ToolStripMenuItem ToolStripMenuItem_Information;
        private ToolStripMenuItem ToolStripMenuItem_AuthorOfProgram;
        private ToolStripMenuItem ToolStripMenuItem_AboutProgram;
    }
}