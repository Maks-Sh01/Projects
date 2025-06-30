using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using Microsoft.Win32;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;
using CppSharp;
using System.Security.Cryptography;
using System.Numerics;

namespace ShatLightStudio
{
    public partial class FormCppCoder : MaterialForm
    {
        private string filePathCpp;
        private string nameProjectCpp;
        Process compilerProcess = new Process();
        public FormCppCoder(string filePathCpp, string nameProjectCpp)
        {
            InitializeComponent();
            string fileContent = File.ReadAllText(filePathCpp);
            txtCode.Text = fileContent;

            this.filePathCpp = filePathCpp;
            this.nameProjectCpp = nameProjectCpp;

        }

        private void FormCppCoder_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string cppCode = txtCode.Text;
            string fileName = "temp.cpp";
            string exeName = "temp.exe";

            File.WriteAllText(fileName, cppCode);
            File.WriteAllText(filePathCpp, cppCode);
            compilerProcess.StartInfo.FileName = "g++.exe";
            compilerProcess.StartInfo.Arguments = $"{fileName} -o {exeName}";
            compilerProcess.StartInfo.RedirectStandardOutput = true;
            compilerProcess.StartInfo.RedirectStandardError = true;
            compilerProcess.StartInfo.UseShellExecute = false;
            compilerProcess.StartInfo.CreateNoWindow = true;

            compilerProcess.Start();

            compilerProcess.WaitForExit();

            string output = compilerProcess.StandardOutput.ReadToEnd();
            string errors = compilerProcess.StandardError.ReadToEnd();

            compilerProcess.Close();

            StatusBox.Text = errors;

            if (File.Exists(exeName))
            {
                StatusBox.ForeColor = Color.Blue;
                StatusBox.Text = "Success!";
                Process.Start(exeName);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string contentToSave = txtCode.Text;

            File.WriteAllText(filePathCpp, contentToSave);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DocumentName = filePathCpp.Substring(filePathCpp.LastIndexOf(Path.DirectorySeparatorChar));
                printDocument1.Print();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                txtCode.Clear();
                openFileDialog1.Filter = "Text Files (*.cs)|*.cs"; 
                string fileNameCpp = openFileDialog1.FileName;
                txtCode.Text = File.ReadAllText(fileNameCpp, Encoding.GetEncoding(1251)); 
                filePathCpp = fileNameCpp;
                string f = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                
            }
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

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, Color> dictcolor = new Dictionary<string, Color>
{
    { "using", Color.Blue },
    { "int", Color.Blue },
    { "double", Color.Blue },
    { "float", Color.Blue },
    { "var", Color.Blue },
    { "namespace", Color.Blue },
    { "new", Color.Blue },
    { "public", Color.Blue },
    { "static", Color.Blue },
    { "private", Color.Blue },
    { "this", Color.Blue },
    { "class", Color.Blue },
    { "struct", Color.Blue },
    { "string", Color.Blue },
    { "void", Color.Blue },
    { "system", Color.Blue },
    { "cout", Color.MediumTurquoise },
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
    { "#", Color.Gray },
    { "include", Color.Red },





};

            int originalSelectionStart = txtCode.SelectionStart;
            int originalSelectionLength = txtCode.SelectionLength;

            txtCode.SuspendLayout();
            txtCode.SelectionStart = 0;
            txtCode.SelectionLength = txtCode.Text.Length;
            txtCode.SelectionColor = txtCode.ForeColor;

            foreach (var pair in dictcolor)
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

        private void timerSaver_Tick(object sender, EventArgs e)
        {
            string savercode = txtCode.Text;
            File.WriteAllText(filePathCpp, savercode);
        }
    }
}
