namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            a = Convert.ToInt32(textBox1.Text);

            b = Convert.ToInt32(textBox2.Text);

            result = a + b;

            label1.Text = result.ToString();






        }
        int a = 0;
        int b = 0;
        int result = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);

            b = Convert.ToInt32(textBox2.Text);

            if (b == 0)
            {
                label1.Text = "pidor";

            }
            else
            {
                result = a / b;

                label1.Text = result.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);

            b = Convert.ToInt32(textBox2.Text);

            result = a - b;

            label1.Text = result.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {

            a = Convert.ToInt32(textBox1.Text);

            b = Convert.ToInt32(textBox2.Text);

            result = a * b;

            label1.Text = result.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
    }


}