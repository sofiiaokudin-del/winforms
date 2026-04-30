using System.Windows.Forms;

namespace WinFormsApp61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1(object sender, EventArgs e)
namespace MemeGallery
    {
        public partial class Form1 : Form
        {
            List<string> memes = new List<string>()
        {
            "абдул.jpg",
            "мем.jpg",
            "паляніца.jpg"
        };

            int index = 0;

            public Form1()
            {
                InitializeComponent();
                ShowMeme();
            }

            void ShowMeme()
            {
                pictureBox1.ImageLocation = memes[index];
            }

            private void btnNext_Click(object sender, EventArgs e)
            {
                index = (index + 1) % memes.Count;
                ShowMeme();
            }

            private void btnPrev_Click(object sender, EventArgs e)
            {
                index = (index - 1 + memes.Count) % memes.Count;
                ShowMeme();
            }
        }
    }
}
 
