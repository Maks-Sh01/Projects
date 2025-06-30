using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;

namespace ShatLightStudio
{
    public partial class FormHTMLCoder : MaterialForm
    {
        private string filePathHTML;
        private string nameProjectHTML;
        private string Output;
        private string output1;
        public FormHTMLCoder(string filePathHTML, string nameProjectHTML)
        {
            InitializeComponent();
            string fileContent = File.ReadAllText(filePathHTML);
            txtCode.Text = fileContent;

            this.filePathHTML = filePathHTML;
            this.nameProjectHTML = nameProjectHTML;

        }

        private void FormHTMLCoder_Load(object sender, EventArgs e)
        {
            timerSaver.Interval = 30000;
            timerSaver.Start();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string HTMLCode = txtCode.Text;
            FormHTMLStart fhs = new FormHTMLStart(HTMLCode);
            fhs.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string contentToSave = txtCode.Text;

            File.WriteAllText(filePathHTML, contentToSave);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialogHTML.ShowDialog() == DialogResult.OK) 
            {
                txtCode.Clear(); 
                openFileDialogHTML.Filter = "Text Files (*.html)|*.html"; 
                string fileName = openFileDialogHTML.FileName; 
                txtCode.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); 
                filePathHTML = fileName;
                string f = Path.GetFileNameWithoutExtension(openFileDialogHTML.FileName);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DocumentName = filePathHTML.Substring(filePathHTML.LastIndexOf(Path.DirectorySeparatorChar));
                printDocument1.Print();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormSettings fsm = new FormSettings();
            fsm.Show();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = txtCode.SelectionFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCode.SelectAll();
                txtCode.SelectionFont = fontDialog1.Font;

            }
        }

       
          

        private void txtCode_TextChanged_1(object sender, EventArgs e)
        {
            Dictionary<string, Color> wordColorMap = new Dictionary<string, Color>
{
    { "<html", Color.Blue },
    { "</html>", Color.Blue },
    { "<head", Color.Blue },
    { "</head>", Color.Blue },
    { "<body", Color.Blue },
    { "</body>", Color.Blue },
    { "<style", Color.Blue },
    { "</style>", Color.Blue },
    { "href", Color.Red },
    { "src", Color.Blue },
    { "<form", Color.Blue },
    { "</form", Color.Blue },
    { "<title", Color.Blue },
    { "</title>", Color.Blue },
    { ">", Color.Blue },
    { "Console", Color.MediumTurquoise },
    { "Stream", Color.MediumTurquoise },
    { "StreamReader", Color.MediumTurquoise },
    { "StreamWriter", Color.MediumTurquoise },
    { "File", Color.MediumTurquoise },
    { "for", Color.Purple },
    { "if", Color.Purple },
    { "else", Color.Purple },
    { "do", Color.Purple },
    { "while", Color.Purple },
    { "break", Color.Purple },
    { "foreach", Color.Purple },



};

            int originalSelectionStart = txtCode.SelectionStart;
            int originalSelectionLength = txtCode.SelectionLength;

            txtCode.SuspendLayout();
            txtCode.SelectionStart = 0;
            txtCode.SelectionLength = txtCode.Text.Length;
            txtCode.SelectionColor = txtCode.ForeColor;

            foreach (var pair in wordColorMap)
            {
                int startIndex = 0;
                while (startIndex < txtCode.TextLength)
                {
                    int wordStart = txtCode.Find(pair.Key, startIndex, RichTextBoxFinds.WholeWord);
                    if (wordStart == -1)
                        break;

                    txtCode.SelectionStart = wordStart;
                    txtCode.SelectionLength = pair.Key.Length;
                    txtCode.SelectionColor = pair.Value;

                    startIndex = wordStart + pair.Key.Length;
                }
            }

            txtCode.SelectionStart = originalSelectionStart;
            txtCode.SelectionLength = originalSelectionLength;
            txtCode.ResumeLayout();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
        }

        private void timerSaver_Tick(object sender, EventArgs e)
        {
            string savercode = txtCode.Text;
            File.WriteAllText(filePathHTML, savercode);
        }
    }
    
}
