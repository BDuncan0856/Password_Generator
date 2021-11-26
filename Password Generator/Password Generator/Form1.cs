using System.Text;

namespace Password_Generator
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PassGenerator(8);
            }
            else if (checkBox2.Checked)
            {
                PassGenerator(16);
            }
            else if (checkBox3.Checked)
            {
                PassGenerator(24);
            }
            else
            {
                PassGenerator(8);
            }
            
        }

        public void PassGenerator(int len)
        {
            const string ValidChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&*?";
            StringBuilder result = new StringBuilder();
            Random r = new Random();
            while (0 < len--)
            {
                result.Append(ValidChar[r.Next(ValidChar.Length)]);
            }  
            textBox1.Text = result.ToString();
        }
    }
}