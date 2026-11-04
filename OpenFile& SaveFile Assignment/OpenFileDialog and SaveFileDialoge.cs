using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace file_save_DIALOGE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //import class
            
            StreamReader reader;

            DialogResult Result;
            Result = OpenFile.ShowDialog();

            if (Result == DialogResult.OK)
            {
                // Open the file
                reader = File.OpenText(OpenFile.FileName);

                // Process file
                string lines;

                while (reader.EndOfStream == false)
                {
                    lines = reader.ReadLine();

                    listview.Items.Add(lines);
                }

                // Close the file
                reader.Close();
            }
            else if (Result == DialogResult.Cancel)

                MessageBox.Show("Not open the file");
        }




        private void button2_Click(object sender, EventArgs e)
        {
            // Import class
            StreamWriter writes;

            DialogResult result;
            result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Open the file - Append
                writes = File.AppendText(saveFileDialog.FileName);

                // Process the file - Writing
                writes.WriteLine(txtinput.Text);
                writes.WriteLine("ali");

                // Close the file
                writes.Close();

                MessageBox.Show("File Saved Successfully");

                txtinput.Clear();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Not saved the file");
            }
        }

        private void listview_SelectedIndexChanged(object sender, EventArgs e)
        {
            listview.Items.Clear();
        }
    }
}
