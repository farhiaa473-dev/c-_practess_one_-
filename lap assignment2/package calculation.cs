namespace lap_assignment
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
                int Nopackages;
                double pricePerpackage;

                // Read and validate input
                if (!int.TryParse(txtpackage.Text, out Nopackages))
                {
                    MessageBox.Show("Please enter a valid number of packages.");
                    return;
                }

                if (!double.TryParse(txtpricepackage.Text, out pricePerpackage))
                {
                    MessageBox.Show("Please enter a valid price per package.");
                    return;
                }

                if (Nopackages <= 0 || pricePerpackage <= 0)
                {
                    MessageBox.Show("Values must be greater than zero.");
                    return;
                }

                // Calculate subtotal
                double subtotal = Nopackages * pricePerpackage;

                // Determine discount rate
                double rate;

                if (Nopackages >= 40 && Nopackages <= 49)
                    rate = 50;
                else if (Nopackages >= 30 && Nopackages <= 39)
                    rate = 40;
                else if (Nopackages >= 20 && Nopackages <= 29)
                    rate = 30;
                else if (Nopackages >= 10 && Nopackages <= 19)
                    rate = 20;
                else
                    rate = 0;

                // Calculate discount and total
                double discount = subtotal * rate / 100;
                double total = subtotal - discount;

                // Display results in ListBox
                listshow.Items.Clear();

               listshow.Items.Add("Number of Packages: " + Nopackages);
                listshow.Items.Add("Price per Package: $" + pricePerpackage.ToString("F2"));
                listshow.Items.Add("Subtotal: $" + subtotal.ToString("F2"));
                listshow.Items.Add("Discount Rate: " + rate + "%");
                listshow.Items.Add("Discount: $" + discount.ToString("F2"));
               listshow.Items.Add("Total: $" + total.ToString("F2"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpackage.Clear();
            listshow.Items.Clear();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          listshow.Items.Clear();
           


        }
    }
}
