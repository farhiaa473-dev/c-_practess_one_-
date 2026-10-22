namespace Hotel_Booking_System
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
            bool bookingApproved = false;

            string guestName = txtGessName.Text.Trim();

            int age, nights, guests;

            if (guestName == "")
            {
                MessageBox.Show("Please enter guest name.");
                return;
            }

            if (!int.TryParse(txtGessAge.Text, out age) ||
                !int.TryParse(txtNoNights.Text, out nights) ||
                !int.TryParse(txtGessName.Text, out guests))
            {
                MessageBox.Show("Please enter valid numeric values.");
                return;
            }

            if (age < 18 || age > 90)
            {
                MessageBox.Show("Age must be between 18 and 90.");
                return;
            }

            if (nights < 1 || nights > 30)
            {
                MessageBox.Show("Nights must be between 1 and 30.");
                return;
            }

            if (guests < 1 || guests > 6)
            {
                MessageBox.Show("Guests must be between 1 and 6.");
                return;
            }

            string roomType = "";
            int maxGuests = 0;
            double rate = 0;

            if (rdstanderd.Checked)
            {
                roomType = "Standard";
                maxGuests = 2;
            }
            else if (rdnormal.Checked)
            {
                roomType = "Normal";
                maxGuests = 4;
            }
            else if (rdhight.Checked)
            {
                roomType = "Hight";
                maxGuests = 6;
            }
            else
            {
                MessageBox.Show("Please select a room type.");
                return;
            }

            if (guests > maxGuests)
            {
                MessageBox.Show(
                    roomType + " room allows a maximum of "
                    + maxGuests + " guests.");
                return;
            }

            switch (roomType)
            {
                case "Standard":
                    rate = 50;
                    break;

                case "Normal":
                    rate = 80;
                    break;

                case "Hight":
                    rate = 130;
                    break;
            }

            bookingApproved = true;

            double roomCost = rate * nights;
            double nightDiscountRate = 0;

            if (nights >= 5 && nights <= 9)
            {
                nightDiscountRate = 0.05;
            }
            else if (nights >= 10)
            {
                nightDiscountRate = 0.12;
            }

            double nightDiscount =
                roomCost * nightDiscountRate;

            double remainingRoomCost =
                roomCost - nightDiscount;

            double seniorDiscount = 0;

            if (age >= 60)
            {
                seniorDiscount = remainingRoomCost * 0.05;
            }

            remainingRoomCost -= seniorDiscount;

            double breakfastCost = 0;

            if (checkBreakfast.Checked)
            {
                breakfastCost = 10 * guests * nights;
            }

            double serviceSurcharge = 0;

            if (guests > 4)
            {
                serviceSurcharge = remainingRoomCost * 0.05;
            }

            double total = remainingRoomCost
                         + breakfastCost
                         + serviceSurcharge;

            if (bookingApproved)
            {
                BookingDetailListBox.Text =
                    "BOOKING APPROVED\n" +
                    "------------------------------\r\n" +
                    "Guest Name: " + guestName + "\r\n" +
                    "Guest Age: " + age + "\r\n" +
                    "Room Type: " + roomType + "\r\n" +
                    "Rate Per Night: " + rate.ToString("C2") + "\r\n" +
                    "Number of Nights: " + nights + "\r\n" +
                    "Number of Guests: " + guests + "\r\n" +
                    "Room Cost: " + roomCost.ToString("C2") + "\r\n" +
                    "Night Discount: -" +
                        nightDiscount.ToString("C2") + "\r\n" +
                    "Senior Discount: -" +
                        seniorDiscount.ToString("C2") + "\r\n" +
                    "Breakfast: " + breakfastCost.ToString("C2") + "\r\n" +
                    "Service Surcharge: " +
                        serviceSurcharge.ToString("C2") + "\r\n" +
                    "------------------------------\r\n" +
                    "TOTAL: " + total.ToString("C2");
            }
            else
            {
                BookingDetailListBox.Text = "BOOKING REJECTED";
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
           txtGessAge.Clear();
           txtGessAge.Clear();
          txtNoNights.Clear();
            NoGesst.Clear();
            BookingDetailListBox.Items.Clear();

            rdstanderd.Checked = true;
           rdnormal.Checked = false;
            rdhight.Checked = false;

            checkBreakfast.Checked = false;

            txtGessAge.Focus();
        }
    }
}
