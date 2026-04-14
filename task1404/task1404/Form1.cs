namespace task1404
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            button1.MouseEnter += button1_MouseEnter;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;

            int newX = random.Next(0, maxX);
            int newY = random.Next(0, maxY);

            button1.Location = new Point(newX, newY);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
