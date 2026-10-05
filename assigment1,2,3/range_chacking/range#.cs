namespace Range_chacker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;

            // Check integer
            if (int.TryParse(txtintiger.Text, out number))
            {
                // Check range
                if (number >= 1 && number <= 10)
                {
                    txtrange.Text = "The number is within the range.";
                }
                else
                {
                    txtrange.Text = "The number is outside the range.";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtintiger.Clear();
            txtrange.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
