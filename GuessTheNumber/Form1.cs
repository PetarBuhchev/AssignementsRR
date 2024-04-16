namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int number;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = string.Empty;
            number = r.Next(1, 101);
            textBoxInput.Enabled = true;
            labelUpDown.Text = string.Empty;
            labelCount.Text = string.Empty;
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            count++;
            int guessedNum = int.Parse(textBoxInput.Text);

            if (guessedNum == number)
            {
                labelUpDown.Text = "Поздравления, познахте числото!";
                labelCount.Text = "Твоите ходове: " + count.ToString();
                textBoxInput.Enabled = false;
            }
            else if (guessedNum < number)
            {
                labelUpDown.Text = "Нагоре :)";
            }
            else
            {
                labelUpDown.Text = "Надолу :)";
            }
        }
    }
}