namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привіт");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
           
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);

               
                double sum = num1 + num2;

             
                label1.Text = "Результат: " + sum.ToString();
            }
            catch (FormatException)
            {
                
                MessageBox.Show("Будь ласка, введіть коректні числа!");
            }
        }
    }
}
