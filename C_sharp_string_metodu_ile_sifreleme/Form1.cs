namespace C_sharp_string_metodu_ile_sifreleme
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace('M', '6');
            textBox1.Text = textBox1.Text.Replace('E', '9');
            textBox1.Text = textBox1.Text.Replace('R', '.');
            textBox1.Text = textBox1.Text.Replace('V', '2');
            textBox1.Text = textBox1.Text.Replace('K', 'd');
            textBox1.Text = textBox1.Text.Replace('S', '0');




        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text.Replace('6', 'M');
            textBox1.Text = textBox1.Text.Replace('9', 'E');
            textBox1.Text = textBox1.Text.Replace('.', 'R');
            textBox1.Text = textBox1.Text.Replace('2', 'V');
            textBox1.Text = textBox1.Text.Replace('d', 'K');
            textBox1.Text = textBox1.Text.Replace('0', 'S');
        }



    }
}
      