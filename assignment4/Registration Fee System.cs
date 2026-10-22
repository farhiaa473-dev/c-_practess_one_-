using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cmblevel = new ComboBox();
            cmblevel.Name = "cmbLevel";

            cmblevel.Items.AddRange(new object[]
            {
                "Year 1",
                "Year 2",
                "Year 3",
                "Year 4"
            });

           cmblevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmblevel.Location = new Point(150, 150);
            cmblevel.Width = 150;

            this.Controls.Add(cmblevel);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string studentName = txtsname.Text.Trim();
            string studentID = txtid.Text.Trim();

            int courses;

            if (studentName == "" || studentID == "")
            {
                MessageBox.Show("Please enter student name and ID.");
                return;
            }

            if (!int.TryParse(txtcources.Text, out courses))
            {
                MessageBox.Show("Please enter a valid number of courses.");
                return;
            }

            if (courses < 1 || courses > 8)
            {
                MessageBox.Show("Number of courses must be between 1 and 8.");
                return;
            }

            if (cmblevel.SelectedIndex == -1)
            {
                MessageBox.Show("Please select study level.");
                return;
            }

            string studyLevel = cmblevel.Text;
            decimal feePerCourse = 0;

            if (studyLevel == "Year 1")
                feePerCourse = 40;
            else if (studyLevel == "Year 2")
                feePerCourse = 45;
            else if (studyLevel == "Year 3")
                feePerCourse = 50;
            else if (studyLevel == "Year 4")
                feePerCourse = 55;

            decimal tuition = courses * feePerCourse;
            decimal transportFee = 0;
            decimal discount = 0;

            if (checktransport.Checked)
            {
                transportFee = 50;
            }

            if (courses >= 6)
            {
                discount = tuition * 0.10m;
            }

            if (checktransport.Checked)
            {
                if (courses >= 5)
                {
                    discount += tuition * 0.05m;
                }
            }

            decimal finalAmount = tuition + transportFee - discount;

            lblname.Text = "Student Name: " + studentName;
            lblstudyYear.Text = "Study Level: " + studyLevel;
          lblTuitionFee.Text = "Tuition Fee: $" + tuition.ToString("N2");
            lblTrnsfee.Text = "Transport Fee: $" + transportFee.ToString("N2");
            lblDiscount.Text = "Discount Amount: $" + discount.ToString("N2");
            lblFinalAmount.Text = "Final Amount: $" + finalAmount.ToString("N2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtsname.Clear();
            txtid.Clear();
            txtcources.Clear();

            cmblevel.SelectedIndex = -1;
            checktransport.Checked = false;

            lblname.Text = "Student Name:";
            lblstudyYear.Text = "Study Level:";
           lblTuitionFee.Text = "Tuition Fee:";
            lblTrnsfee.Text = "Transport Fee:";
            lblDiscount.Text = "Discount Amount:";
            lblFinalAmount.Text = "Final Amount:";

            txtsname.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
    }


