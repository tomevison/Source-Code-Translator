using Google.Cloud.Translation.V2;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KUKA.Translate
{
    public partial class Form1 : Form
    {
        String inputFilename;
        String delimiter;

        // options
        bool KeepOriginalComment = false;
        bool OverwriteOriginalFile = false;

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

        private void OptionKeepOriginalComment_CheckedChanged(object sender, EventArgs e)
        {
            KeepOriginalComment = OptionKeepOriginalComment.Checked;
            Console.WriteLine("Option: KeepOriginalComment = " + KeepOriginalComment);
        }

        private void OptionOverwriteOriginalFile_CheckedChanged(object sender, EventArgs e)
        {
            OverwriteOriginalFile = OptionOverwriteOriginalFile.Checked;
            Console.WriteLine("Option: OverwriteOriginalFile = " + OverwriteOriginalFile);
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
                LabelFilename.Text = "Filename: " + openFileDialog1.SafeFileName;
                richTextBoxPreview.Text = File.ReadAllText(inputFilename); // show file in preview window
                LabelFileSizeUpdate.Text = new FileInfo(inputFilename).Length.ToString() + " b";
                labelFileSize.Text = "Size";
            }
            Console.WriteLine("input file name: " + inputFilename); // <-- For debugging use.
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            StreamReader reader = File.OpenText(inputFilename);
            string line;
            richTextBoxPreview.Text = "";

            while ((line = reader.ReadLine()) != null)
            {                
                if (line.Contains(";")) // if the line contains a comment
                {
                    string[] items = line.Split(';');
                    string translated = translate(items[1]);

                    richTextBoxPreview.AppendText(items[0]);

                    if (KeepOriginalComment)
                    {
                        richTextBoxPreview.AppendText("; " + items[1]);
                        richTextBoxPreview.SelectionBackColor = Color.Gold;
                        richTextBoxPreview.AppendText(" -> " +translated);
                    }
                    else
                    {
                        richTextBoxPreview.SelectionBackColor = Color.Gold;
                        richTextBoxPreview.AppendText("; " + translated);
                    }
                    Console.WriteLine(items[1]+ " -> " +  translated );
                }
                else
                {
                    richTextBoxPreview.AppendText(line); // default statement for non commented lines
                }
                richTextBoxPreview.AppendText("\r\n");  // insert newline
            }            
        }

        // returns a translated string
        private String translate(String input)
        {
            // google translate API key
            string credential_path = @"C:\Users\tomevo\Source\Repos\Translate\KUKA.Translate\googleApplicationCredentials.json";
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credential_path);

            TranslationClient client = TranslationClient.Create();
            TranslationResult result = client.TranslateText(input, LanguageCodes.English, LanguageCodes.German);
            // Console.WriteLine($"Result: {result.TranslatedText}; detected language {result.DetectedSourceLanguage}");

            return result.TranslatedText;
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

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            // todo information msg on hover
        }

        private void TextBoxDelimiter_TextChanged(object sender, EventArgs e)
        {
            delimiter = TextBoxDelimiter.Text;
            Console.WriteLine("Delimiter changed to: "+delimiter);
        }


    }
}
