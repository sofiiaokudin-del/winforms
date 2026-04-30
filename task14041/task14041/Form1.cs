namespace task14041
public partial class Form1 : Form
{
    bool isX = true;
    bool gameOver = false;

    public Form1()
    {
        InitializeComponent();

        // 100% рабочее подключение
        button1.Click += Button_Click;
        button2.Click += Button_Click;
        button3.Click += Button_Click;
        button4.Click += Button_Click;
        button5.Click += Button_Click;
        button6.Click += Button_Click;
        button7.Click += Button_Click;
        button8.Click += Button_Click;
        button9.Click += Button_Click;
    }

    private void Button_Click(object sender, EventArgs e)
    {
        if (gameOver) return;

        Button btn = (Button)sender;

        if (btn.Text != "") return;

        btn.Text = isX ? "X" : "O";
        isX = !isX;

        CheckWinner();
    }

    private void CheckWinner()
    {
        if (button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
            Win(button1.Text);

        else if (button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text)
            Win(button4.Text);

        else if (button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text)
            Win(button7.Text);

        else if (button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text)
            Win(button1.Text);

        else if (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text)
            Win(button2.Text);

        else if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text)
            Win(button3.Text);

        else if (button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text)
            Win(button1.Text);

        else if (button3.Text != "" && button3.Text == button5.Text && button5.Text == button7.Text)
            Win(button3.Text);
    }

    private void Win(string w)
    {
        gameOver = true;
        MessageBox.Show("Победил: " + w);
        Reset();
    }

    private void Reset()
    {
        button1.Text = "";
        button2.Text = "";
        button3.Text = "";
        button4.Text = "";
        button5.Text = "";
        button6.Text = "";
        button7.Text = "";
        button8.Text = "";
        button9.Text = "";

        isX = true;
        gameOver = false;
    }
}
}
