using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUKA.Translate
{
    public partial class Form1 : Form
    {
        String inputFilename;
        String inputFileSize;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e){
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e){

        }

        private void textBox2_TextChanged(object sender, EventArgs e){
            
        }

        // displays the 'About' window
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }

        // Selects the file to be translated, saves path to "inputFileName"
        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)// Test result.
            {
                inputFilename = openFileDialog1.FileName;
                textBox1.Text = inputFilename;
                textBox2.Text = File.ReadAllText(inputFilename); // show file in preview window
                LabelFileSizeUpdate.Text = new FileInfo(inputFilename).Length.ToString() + " b";
                labelFileSize.Text = "Size";
            }
            Console.WriteLine("input file name: " + inputFilename); // <-- For debugging use.
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            

            StreamReader reader = File.OpenText(inputFilename);
            string line;

            while ((line = reader.ReadLine()) != null)
            {                
                if (line.Contains(";")) // if the line contains a comment
                {
                    string[] items = line.Split(';');
                    Console.WriteLine(items[1]);
                }
            }
            
        }

        private String translate(String input)
        {
            // google translate API key
            string googleApiKey = "AIzaSyDzi81Uoe7nvalfTOTwfyWsgYHKXvUOW6M";
            return "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
