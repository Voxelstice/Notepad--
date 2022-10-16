namespace Notepad__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength >= 32)
            {
                System.Environment.FailFast("Stack overflow");
            }
        }

        private void Form1_Closed(object sender, FormClosedEventArgs e) { }
        private void Form1_Closing(object sender, FormClosingEventArgs e) { }
    }
}