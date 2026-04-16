namespace гра_сапер
{
    public partial class Form1 : Form
    {
        int[,] pole = new int[10, 10];
        public Form1()
        {
            InitializeComponent();

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (rnd.Next(0, 10) < 2)
                    {
                        pole[i, j] = 1;
                    }
                    else
                    {
                        pole[i, j] = 0;
                    }
                    Button b = new Button();
                    b.Width = 35;
                    b.Height = 35;
                    b.Left = i * 35;
                    b.Top = j * 35;
                    b.Name = i + "_" + j;

                    b.Click += button_click;
                    this.Controls.Add(b);
                }
            }
        }

        void button_click(object sender, EventArgs e)
        {
            Button but = (Button)sender;

            string[] parts = but.Name.Split('_');
            int x = int.Parse(parts[0]);
            int y = int.Parse(parts[1]);

            if (pole[x, y] == 1)
            {
                but.Text = "X";
                MessageBox.Show("бум");
                Application.Exit();
            }
            else
            {
                but.Text = "O";

            }
        }
    }
}
