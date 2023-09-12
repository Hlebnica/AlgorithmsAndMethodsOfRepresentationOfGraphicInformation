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
            label1 = new Label();
            button_Save = new Button();
            menuStrip1 = new MenuStrip();
            ToolStripMenuItem_File = new ToolStripMenuItem();
            ToolStripMenuItem_Edit = new ToolStripMenuItem();
            ToolStripMenuItem_Exit = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_AuthorName
            // 
            textBox_AuthorName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_AuthorName.Location = new Point(227, 188);
            textBox_AuthorName.Name = "textBox_AuthorName";
            textBox_AuthorName.Size = new Size(261, 32);
            textBox_AuthorName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(261, 137);
            label1.Name = "label1";
            label1.Size = new Size(203, 23);
            label1.TabIndex = 1;
            label1.Text = "Автор программы:";
            // 
            // button_Save
            // 
            button_Save.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Save.Location = new Point(227, 240);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(261, 45);
            button_Save.TabIndex = 2;
            button_Save.Text = "Сохранить";
            button_Save.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem_File });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_File
            // 
            ToolStripMenuItem_File.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem_Edit, ToolStripMenuItem_Exit });
            ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            ToolStripMenuItem_File.Size = new Size(59, 24);
            ToolStripMenuItem_File.Text = "Файл";
            // 
            // ToolStripMenuItem_Edit
            // 
            ToolStripMenuItem_Edit.Name = "ToolStripMenuItem_Edit";
            ToolStripMenuItem_Edit.Size = new Size(224, 26);
            ToolStripMenuItem_Edit.Text = "Редактировать";
            // 
            // ToolStripMenuItem_Exit
            // 
            ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            ToolStripMenuItem_Exit.Size = new Size(224, 26);
            ToolStripMenuItem_Exit.Text = "Выход";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 377);
            Controls.Add(button_Save);
            Controls.Add(label1);
            Controls.Add(textBox_AuthorName);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_AuthorName;
        private Label label1;
        private Button button_Save;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMenuItem_File;
        private ToolStripMenuItem ToolStripMenuItem_Edit;
        private ToolStripMenuItem ToolStripMenuItem_Exit;
    }
}