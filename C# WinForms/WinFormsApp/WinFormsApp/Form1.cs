namespace WinFormsApp
{
    public partial class Calc : Form
    {

        public string calcOperation;
        public string number;
        bool num;

        public Calc()
        {
            num = false;
            InitializeComponent();
        }

        private void resultTextBox_Click(object sender, EventArgs e)
        {
            if (num)
            {
                num = false;
                resultTextBox.Text = "0";
            }

            Button button = (Button)sender;
            if (resultTextBox.Text == "0")
                resultTextBox.Text = button.Text;
            else
                resultTextBox.Text = resultTextBox.Text + button.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "0";
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calcOperation = button.Text;
            number = resultTextBox.Text;
            num = true;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            double firstNumber;
            double secondNumber;
            double result = 0;

            firstNumber = Convert.ToDouble(number);
            secondNumber = Convert.ToDouble(resultTextBox.Text);

            if (calcOperation == "+")
            {
                result = firstNumber + secondNumber;
            }
            if (calcOperation == "-")
            {
                result = firstNumber - secondNumber;
            }
            if (calcOperation == "x")
            {
                result = firstNumber * secondNumber;
            }
            if (calcOperation == "/")
            {
                result = firstNumber / secondNumber;
            }

            calcOperation = "=";
            num = true;
            resultTextBox.Text = result.ToString();
        }

        private void commaButton_Click(object sender, EventArgs e)
        {
            if (!resultTextBox.Text.Contains(","))
                resultTextBox.Text = resultTextBox.Text + ",";
        }
    }
}