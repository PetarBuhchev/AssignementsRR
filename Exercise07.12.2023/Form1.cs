namespace Exercise07._12._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTypeNumberAsText_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            switch (input)
            {
                case "1":
                    labelOutput.Text = "едно";
                    break;
                case "2":
                    labelOutput.Text = "две";
                    break;
                case "3":
                    labelOutput.Text = "три";
                    break;
                case "4":
                    labelOutput.Text = "четири";
                    break;
                case "5":
                    labelOutput.Text = "пет";
                    break;
                case "6":
                    labelOutput.Text = "шест";
                    break;
                case "7":
                    labelOutput.Text = "седем";
                    break;
                case "8":
                    labelOutput.Text = "осем";
                    break;
                case "9":
                    labelOutput.Text = "девет";
                    break;
                default:
                    labelOutput.Text = "Не знам!";
                    break;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = string.Empty;
            labelOutput.Text = string.Empty;
        }
    }
}