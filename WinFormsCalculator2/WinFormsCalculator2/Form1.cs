namespace WinFormsCalculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputNum1 = Num1.Text;
            string inputNum2 = Num2.Text;
            int iNum1 = int.Parse(inputNum1);
            int iNum2 = int.Parse(inputNum2);
            int iresult = iNum1 + iNum2;
            Result.Text = iresult.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputNum1 = Num1.Text;
            string inputNum2 = Num2.Text;
            int iNum1 = int.Parse(inputNum1);
            int iNum2 = int.Parse(inputNum2);
            int iresult = iNum1 - iNum2;
            Result.Text = iresult.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string inputNum1 = Num1.Text;
            string inputNum2 = Num2.Text;
            int iNum1 = int.Parse(inputNum1);
            int iNum2 = int.Parse(inputNum2);
            int iresult = iNum1 * iNum2;
            Result.Text = iresult.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string inputNum1 = Num1.Text;
            string inputNum2 = Num2.Text;
            int iNum1 = int.Parse(inputNum1);
            int iNum2 = int.Parse(inputNum2);
            int iresult = iNum1 / iNum2;
            Result.Text = iresult.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Num1.Clear();
            Num2.Clear();
            Result.Clear();
        }
    }
}
