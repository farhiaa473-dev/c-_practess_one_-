namespace Airlan_Booking_System_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string passengerName = txtpassagename.Text.Trim();

                int passengerAge;
                int numberOfTickets;
                double baggageWeight;

                if (passengerName == "")
                {
                    MessageBox.Show("Please enter passenger name.");
                    return;
                }

                if (!int.TryParse(txtpassageAge.Text, out passengerAge) ||
                    passengerAge < 1 || passengerAge > 100)
                {
                    MessageBox.Show("Enter a valid age between 1 and 100.");
                    return;
                }

                if (!int.TryParse(txtNnTickets.Text, out numberOfTickets) ||
                    numberOfTickets < 1 || numberOfTickets > 5)
                {
                    MessageBox.Show("Tickets must be between 1 and 5.");
                    return;
                }

                if (!double.TryParse(txtWaights.Text, out baggageWeight) ||
                    baggageWeight < 0 || baggageWeight > 50)
                {
                    MessageBox.Show("Baggage weight must be between 0 and 50 kg.");
                    return;
                }

                string travelClass;
                double ticketPrice;

                if (rbfirst.Checked)
                {
                    travelClass = "First Class";
                    ticketPrice = 500;
                }
                else if (rbnormal.Checked)
                {
                    travelClass = "Normal Class";
                    ticketPrice = 200;
                }
                else if (rbbussiness.Checked)
                {
                    travelClass = "Business Class";
                    ticketPrice = 350;
                }
                else
                {
                    MessageBox.Show("Please select a travel class.");
                    return;
                }

                if (passengerAge < 12 && rbfirst.Checked)
                {
                    MessageBox.Show("Children under 12 cannot book First Class.");
                    return;
                }

                double basicTicketCost = ticketPrice * numberOfTickets;

                double ticketDiscountRate = 0;

                if (numberOfTickets >= 3 && numberOfTickets <= 4)
                {
                    ticketDiscountRate = 0.05;
                }
                else if (numberOfTickets == 5)
                {
                    ticketDiscountRate = 0.10;
                }

                double ticketDiscount =
                    basicTicketCost * ticketDiscountRate;

                double childDiscount = 0;
                double seniorDiscount = 0;

                if (passengerAge < 12)
                {
                    childDiscount = basicTicketCost * 0.20;
                }
                else if (passengerAge >= 60)
                {
                    seniorDiscount = basicTicketCost * 0.10;
                }

                double baggageFee = 0;

                if (baggageWeight > 20)
                {
                    baggageFee = (baggageWeight - 20) * 10;
                }

                double insuranceFee = 0;

                if (checkInsurance.Checked)
                {
                    insuranceFee = 25 * numberOfTickets;
                }

                double finalCost = basicTicketCost
                    - ticketDiscount
                    - childDiscount
                    - seniorDiscount
                    + baggageFee
                    + insuranceFee;

                listBox1.Items.Clear();

                listBox1.Items.Add("===== BOOKING APPROVED =====");
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("Passenger Name: " + passengerName);
                listBox1.Items.Add("Passenger Age: " + passengerAge);
                listBox1.Items.Add("Travel Class: " + travelClass);
                listBox1.Items.Add("Ticket Price: " + ticketPrice.ToString("C2"));
                listBox1.Items.Add("Number of Tickets: " + numberOfTickets);
                listBox1.Items.Add("Baggage Weight: " + baggageWeight + " kg");
                listBox1.Items.Add("Basic Ticket Cost: " + basicTicketCost.ToString("C2"));
                listBox1.Items.Add("Ticket Discount: " + ticketDiscount.ToString("C2"));
                listBox1.Items.Add("Child Discount: " + childDiscount.ToString("C2"));
                listBox1.Items.Add("Senior Discount: " + seniorDiscount.ToString("C2"));
                listBox1.Items.Add("Baggage Fee: " + baggageFee.ToString("C2"));
                listBox1.Items.Add("Travel Insurance: " + insuranceFee.ToString("C2"));
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("FINAL BOOKING COST: " + finalCost.ToString("C2"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred: " + ex.Message,
                    "Booking Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpassagename.Clear();
            txtpassageAge.Clear();
            txtNnTickets.Clear();
            txtWaights.Clear();

            rbfirst.Checked = false;
            rbnormal.Checked = false;
            rbbussiness.Checked = false;
            checkInsurance.Checked = false;

            listBox1.Items.Clear();

            txtpassagename.Focus();
        }





    }
    }

