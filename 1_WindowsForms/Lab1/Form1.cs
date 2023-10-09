namespace Lab1
{
    public partial class Form1 : Form
    {
        string author_name = "";

        public Form1()
        {
            InitializeComponent();

            if (author_name == "")
            {
                ToolStripMenuItem_AuthorOfProgram.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Edit_Click(object sender, EventArgs e)
        {
            label_AuthorOfProgram.Visible = false;
            textBox_AuthorName.Visible = false;
            button_Save.Visible = false;
        }

        private void ToolStripMenuItem_AboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лабораторная работа №1\nВерсия 1.0.0", "Сведения о программе");
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (textBox_AuthorName.Text != "")
            {
                author_name = textBox_AuthorName.Text;
                ToolStripMenuItem_AuthorOfProgram.Enabled = true;
            }
            else
            {
                author_name = "";
                ToolStripMenuItem_AuthorOfProgram.Enabled = false;
            }
        }

        private void ToolStripMenuItem_AuthorOfProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Имя автора: " + author_name, "Сведения о авторе");
        }

        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}