namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        private string filePath = "history.txt";

        public Form1()
        {
            InitializeComponent();
            LoadHistory();
        }

       


        private void CheckComplexity(string pass)
        {
            int score = 0;
            if (pass.Length >= 8) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(pass, @"[A-Z]") &&
                System.Text.RegularExpressions.Regex.IsMatch(pass, @"[a-z]")) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(pass, @"[0-9]")) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(pass, @"[^a-zA-Z0-9]")) score++;

            if (score <= 1) { label1.Text = "Слабый"; label1.ForeColor = System.Drawing.Color.Red; }
            else if (score <= 3) { label1.Text = "Средний"; label1.ForeColor = System.Drawing.Color.Orange; }
            else { label1.Text = "Сильный"; label1.ForeColor = System.Drawing.Color.Green; }
        }

        private void SavePassword(string pass)
        {
            listBox1.Items.Add(pass);
            System.IO.File.AppendAllLines(filePath, new[] { pass });
        }

      

        private void LoadHistory()
        {
            if (System.IO.File.Exists(filePath))
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);
                listBox1.Items.AddRange(lines);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int length = (int)numericUpDown1.Value;
            string validChars = "";

            if (checkBox1.Checked) validChars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (checkBox2.Checked) validChars += "abcdefghijklmnopqrstuvwxyz";
            if (checkBox3.Checked) validChars += "0123456789";
            if (checkBox4.Checked) validChars += "!@#$%^&*()_+-=";

            if (string.IsNullOrEmpty(validChars) || length <= 0)
            {
                MessageBox.Show("Выберите типы символов!");
                return;
            }

            Random res = new Random();
            string password = "";
            for (int i = 0; i < length; i++)
            {
                password += validChars[res.Next(validChars.Length)];
            }

            textBox1.Text = password;
            CheckComplexity(password);
            SavePassword(password);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                System.Windows.Forms.Clipboard.SetText(textBox1.Text);
                MessageBox.Show("Пароль збереженний");

            } 
            else
            {
                MessageBox.Show("Спочатку згенеруй пароль");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (System.IO.File.Exists(filePath)) System.IO.File.Delete(filePath);
        }
    }
}
