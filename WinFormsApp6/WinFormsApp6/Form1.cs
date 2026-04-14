namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mark;
            if (int.TryParse(textBox1.Text,out mark))
            { if(mark>=1 && mark<=3)
                { 
                    label1.Text = "Початковий рівень";
                }
            else if (mark>=4 && mark<=6)
                {
                    label1.Text = "Середній рівень";
                }
                else if(mark>=7 && mark<=9)
                {
                    label1.Text = "Достатній рівень";
                }
                else if(mark==10)
                {
                    label1.Text = "Високий рівень";
                }
               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
