namespace payrol_with_ovreytime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double hoursWorked;
                double hourlyPayRate;
                double grossPay;

                // Check hours worked
                if (double.TryParse(txthours.Text, out hoursWorked))
                {
                    // Nested if: check hourly pay rate
                    if (double.TryParse(txtrate.Text, out hourlyPayRate))
                    {
                        // Check that values are not negative
                        if (hoursWorked >= 0 && hourlyPayRate >= 0)
                        {
                            // Check for overtime
                            if (hoursWorked <= 40)
                            {
                                grossPay = hoursWorked * hourlyPayRate;
                            }
                            else
                            {
                                double regularPay = 40 * hourlyPayRate;
                                double overtimeHours = hoursWorked - 40;
                                double overtimePay = overtimeHours * hourlyPayRate * 1.5;

                                grossPay = regularPay + overtimePay;
                            }

                            txtgross.Text = grossPay.ToString("C2");
                        }
                        else
                        {
                            MessageBox.Show("Hours and pay rate cannot be negative.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid hourly pay rate.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid hours worked.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("try a gaine");
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txthours.Clear();
            txtrate.Clear();
            txtgross.Text = "";

            txtrate.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
