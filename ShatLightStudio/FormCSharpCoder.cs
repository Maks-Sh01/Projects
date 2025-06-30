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
using System.IO.Ports;
using System.Diagnostics;
using System.CodeDom.Compiler;
using Microsoft.Win32;
using Microsoft.CSharp;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;
using IWshRuntimeLibrary;
using System.IO.Compression;
using File = System.IO.File;

namespace ShatLightStudio
{
    public partial class FormCSharpCoder : MaterialForm
    {
        private string filePath;
        private string nameProject;
        private string Output;
        private string output1;
        private Process compile;


        public FormCSharpCoder(string filePath, string nameProject)
        {
            InitializeComponent();
            string fileContent = File.ReadAllText(filePath);
            txtCode.Text = fileContent;
            this.filePath = filePath;
            this.nameProject = nameProject;
            Output = nameProject + ".exe";

        }




        private void FormCSharpCoder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

     








        private void FormCSharpCoder_Load(object sender, EventArgs e)
        {
            timerSaver.Interval = 300000;
            timerSaver.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string savecode = txtCode.Text;

            File.WriteAllText(filePath, savecode);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();
            this.output1 = Output;
            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = Output;
            CompilerResults results = icc.CompileAssemblyFromSource(parameters, txtCode.Text);

            if (results.Errors.Count > 0)
            {
                StatusBox.ForeColor = Color.Red;
                foreach (CompilerError CompErr in results.Errors)
                {
                    StatusBox.Text = StatusBox.Text +
                                "Line number " + CompErr.Line +
                                ", Error Number: " + CompErr.ErrorNumber +
                                ", '" + CompErr.ErrorText + ";" +
                                Environment.NewLine + Environment.NewLine;
                }
            }
        
            else
            {
          


                //Successful Compile
                StatusBox.ForeColor = Color.Blue;
                StatusBox.Text = "Success!";

                compile = Process.Start(Output);
                



            }
        }
     
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (compile != null && !compile.HasExited)
            {
                compile.Kill();
                compile = null;
            }
          


        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                txtCode.Clear(); 
                openFileDialog1.Filter = "Text Files (*.cs)|*.cs"; 
                string fileName = openFileDialog1.FileName; 
                txtCode.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); 
                filePath = fileName;
                string f = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                Output = f + ".exe";
            }
        }

       

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormSettings fsm = new FormSettings();
            fsm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtCode.Undo();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            txtCode.Redo();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DocumentName = filePath.Substring(filePath.LastIndexOf(Path.DirectorySeparatorChar));
                printDocument1.Print();
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

     

        private void txtA_TextChanged(object sender, EventArgs e)
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

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtCode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
          
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void timerSaver_Tick(object sender, EventArgs e)
        {
            string savercode = txtCode.Text;
            File.WriteAllText(filePath, savercode);
        }
    }
}
