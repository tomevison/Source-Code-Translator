using Google.Cloud.Translation.V2;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace KUKA.Translate
{
    public partial class Form1 : Form
    {
        String inputFilePath;
        String inputFileName;
        String inputFileExtension;
        char delimiter = ';';
        static String previewTextField;
        String inputLanguage = "German";
        String outputLanguage = "Englinsh";

        BackgroundWorker worker = new BackgroundWorker();

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
                inputFilePath = openFileDialog1.FileName;
                inputFileName = openFileDialog1.SafeFileName;
                textBox1.Text = inputFilePath;

                // update file size and info
                LabelFilename.Text = "Filename: ";
                LabelFileNameUpdate.Text = openFileDialog1.SafeFileName;
                labelFileSize.Text = "Size: ";
                LabelFileSizeUpdate.Text = new FileInfo(inputFilePath).Length.ToString() + " b";
                inputFileExtension = Path.GetExtension(openFileDialog1.FileName);
                LabelExtensionUpdate.Text = inputFileExtension; 
                // show file in preview window
                richTextBoxPreview.Text = File.ReadAllText(inputFilePath);
            }
            Console.WriteLine("input file name: " + inputFilePath); // <-- For debugging use.
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Translating...");
            StreamReader reader = File.OpenText(inputFilePath);
            string line;
            richTextBoxPreview.Text = "";

            while ((line = reader.ReadLine()) != null)
            {
                ParseLine(line);
            }
            Console.WriteLine("Translation complete..");
        }

        private String ParseLine(String input)
        {
            String output = "output";

            if (input.Contains(delimiter.ToString())) // if the line contains a comment
            {
                string[] items = input.Split(delimiter);
                richTextBoxPreview.AppendText(items[0]);

                string translated = translate(items[1]);

                // translate in background thread
                //TranslationBackgroundWorker.RunWorkerAsync();

                if (KeepOriginalComment)
                {
                    richTextBoxPreview.AppendText(delimiter + " " + items[1]);
                    richTextBoxPreview.SelectionBackColor = Color.Gold;
                    richTextBoxPreview.AppendText(" -> " + translated);
                }
                else
                {
                    richTextBoxPreview.SelectionBackColor = Color.Gold;
                    richTextBoxPreview.AppendText(delimiter + " " + translated);
                }
                Console.WriteLine(items[1] + " -> " + translated);
            }
            else
            {
                richTextBoxPreview.AppendText(input); // default statement for non-comment lines
            }
            richTextBoxPreview.AppendText("\r\n");  // insert newline

            return output;
        }

        // returns a translated string
        private String translate(String input)
        {

            TranslationModel model = TranslationModel.ServiceDefault;
            var assembly = Assembly.GetExecutingAssembly();
            StreamReader reader = new StreamReader(assembly.GetManifestResourceStream("KUKA.Translate.Files.apiKey.txt"));
            String apiKey = reader.ReadToEnd();

            TranslationClient client = TranslationClient.CreateFromApiKey(apiKey, model);
            TranslationResult result = client.TranslateText(input, setLanguages(outputLanguage), setLanguages(inputLanguage));

            return result.TranslatedText;
        }

        private string setLanguages(String language)
        {
            switch (language)
            {
                case "English":
                    return LanguageCodes.English;
                case "German":
                    return LanguageCodes.German;
                case "Spanish":
                    return LanguageCodes.Spanish;
                case "Italian":
                    return LanguageCodes.Italian;
                case "Turkish":
                    return LanguageCodes.Turkish;
                default:
                    return LanguageCodes.English;
            }
        }

        private void TextBoxDelimiter_TextChanged(object sender, EventArgs e)
        {
            delimiter = TextBoxDelimiter.Text[0]; // cast string to char
            Console.WriteLine("Delimiter changed to: "+delimiter);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save your translated File";
            saveFileDialog1.Filter = " "+inputFileExtension+"|*"+inputFileExtension+"|Data Files (*.dat)|*.dat| Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FileName = inputFileName; ;
            saveFileDialog1.ShowDialog();
            SaveTranslatedFile();
        }

        private void SaveTranslatedFile()
        {
            // create a new file

            
        }

        // user can save their outputted file
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // get file name
            string name = saveFileDialog1.FileName;

            // create new file
            Console.WriteLine("Create new file");
            StreamWriter writer = new StreamWriter(name);

            // Write to the selected file name
            for (int i = 0; i < richTextBoxPreview.Lines.Length; i++)
            {
                writer.WriteLine(richTextBoxPreview.Lines[i]);
            }

            // close the file
            writer.Close();
        }

        private void TranslationBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("background translation task started..");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void cb_inputLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputLanguage = cb_inputLang.Text;
            Console.WriteLine("inputLanguage = " + inputLanguage);
        }

        private void cb_outputLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputLanguage = cb_outputLang.Text;
            Console.WriteLine("outputLanguage = " + outputLanguage);
        }
    }
}
