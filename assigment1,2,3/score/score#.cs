namespace score
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)

        {
            try
            {


                double score1, score2, score3, average;

                if (double.TryParse(txtscore1.Text, out score1) &&
                    double.TryParse(txtscore2.Text, out score2) &&
                    double.TryParse(txtscore3.Text, out score3))
                {
                    average = (score1 + score2 + score3) / 3;

                    txtavarage.Text = average.ToString("0.0");
                }
                else
                {
                    MessageBox.Show("Please enter valid test scores.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("please try again");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtscore1.Clear();
            txtscore2.Clear();
            txtscore3.Clear();
            txtavarage.Clear();

            txtscore1.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
