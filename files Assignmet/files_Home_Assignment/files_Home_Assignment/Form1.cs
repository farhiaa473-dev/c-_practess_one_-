using Microsoft.VisualBasic.ApplicationServices;

namespace files_Home_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter Write;

            Write = new StreamWriter(@"file.txt");

            Write.WriteLine("Welcome to File System");
            Write.WriteLine("This is my C# assignment");

            Write.Close();

            MessageBox.Show("File created successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader reads;
            string path = "C:\\Users\\pc\\OneDrive\\Desktop\\c#_practess_one_#\\c#_practess_one_#\\files Assignmet\\files_Home_Assignment\\files_Home_Assignment\\files_Home_Assignment.csproj";

            StreamWriter Write = new StreamWriter(path);

            Write.WriteLine("Welcome to File System");
            Write.WriteLine("This is my C# assignment");

            Write.Close();

            MessageBox.Show("File created successfully");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter Write;

            Write = new StreamWriter(@"MyFile.txt", true);

            Write.WriteLine("This is new text");

            Write.Close();

            MessageBox.Show("Text added successfully");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\pc\OneDrive\Desktop\c#_practess_one_#\c#_practess_one_#\files Assignmet\files_Home_Assignment\files_Home_Assignment\files_Home_Assignment.csproj";

            string lines = File.ReadAllText(path);

            listBox1.Items.Add(lines);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader Reads;

            Reads = File.OpenText(@"MyFile.txt");

            string lines;
            lines = Reads.ReadLine();

            listBox1.Items.Add(lines);

            Reads.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamReader Reads;

            Reads = File.OpenText(@"MyFile.txt");

            int character;
            character = Reads.Read();

            if (character != -1)
            {
                listBox1.Items.Add((char)character);
            }

            Reads.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamReader Reads;

            // Open the file
            Reads = File.OpenText(@"MyFile.txt");

            // Process the file using ReadToEnd
            string lines;
            lines = Reads.ReadToEnd();

            listBox1.Items.Add(lines);

            // Close the file
            Reads.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\pc\OneDrive\Desktop\c#_practess_one_#\c#_practess_one_#\files Assignmet\files_Home_Assignment\files_Home_Assignment\files_Home_Assignment.csproj";

            string[] lines;

            // Read all lines
            lines = File.ReadAllLines(path);

            // Display lines
            listBox1.Items.AddRange(lines);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\pc\OneDrive\Desktop\c#_practess_one_#\c#_practess_one_#\files Assignmet\files_Home_Assignment\files_Home_Assignment\files_Home_Assignment.csproj";

            StreamReader Reads = new StreamReader(path);

            // Read the next character without moving forward
            int character = Reads.Peek();

            if (character != -1)
            {
                listBox1.Items.Add((char)character);
            }
            else
            {
                listBox1.Items.Add("End of file");
            }

            Reads.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\pc\OneDrive\Desktop\c#_practess_one_#\c#_practess_one_#\files Assignmet\files_Home_Assignment\files_Home_Assignment\files_Home_Assignment.csproj";

            // Read all bytes
            byte[] bytes = File.ReadAllBytes(path);

            // Display bytes
            listBox1.Items.Add("Total Bytes: " + bytes.Length);

            listBox1.Items.Add(BitConverter.ToString(bytes));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"MyFile.txt"))
            {
                File.Delete(@"MyFile.txt");

                MessageBox.Show("File deleted successfully");
            }
            else
            {
                MessageBox.Show("File does not exist");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //usig ReadAllText

            string path = @"";

            string lines = File.ReadAllText(path);

            listBox1.Items.Clear();
            listBox1.Items.Add(lines);

        }
    }
}
