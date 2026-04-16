namespace галерею_із_мемів_кнопки_вперед_назад
{
    public partial class Form1 : Form
    {
        string[] images;
        int index = 0;

        public Form1()
        {
            InitializeComponent();

            
            string folder = Path.Combine(Application.StartupPath, "memes");

            images = Directory.GetFiles(folder, "*.jpg");

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            ShowImage();

            button1.Click += buttonNext_Click;
            button2.Click += buttonPrev_Click;
        }

        private void ShowImage()
        {
            try
            {
                if (images.Length == 0)
                {
                    MessageBox.Show("Немає зображень!");
                    return;
                }

                using (var imgTemp = Image.FromFile(images[index]))
                {
                    pictureBox1.Image = new Bitmap(imgTemp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            index++;

            if (index >= images.Length)
                index = 0;

            ShowImage();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            index--;

            if (index < 0)
                index = images.Length - 1;

            ShowImage();
        }
    }
}