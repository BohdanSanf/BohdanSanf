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

        private void btnTest2_Click(object sender, EventArgs e)
        {
            lblResult2.Text = "";
          
            switch (cbTest2.SelectedIndex)
            {
                case 0:
                    ForMethod();
                    break;
                case 1:
                    WhileMethod();
                    break;
                case 2:
                    DoWhileMethod();
                    break;
                default:
                    MessageBox.Show("OH MY GOD!!!!!");
                    break;  
            }
            
        }

        #region Members

        private void ForMethod()
        {
            for (int i = 0; i <= nudTest1.Value; i += 2)
            {
                lblResult2.Text += i.ToString();
            }
        }

        private void WhileMethod()
        {
            int index = 0;

            while (index <= nudTest1.Value)
            {
                lblResult2.Text += index.ToString();

                index++;
            }
        }

        private void DoWhileMethod()
        {
            int index = 7;

            do
            {
                lblResult2.Text += index.ToString();

                index++;
            }
            while (index <= nudTest1.Value);
        }

        #endregion Members

    }


}