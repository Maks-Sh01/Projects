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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ShatLightStudio
{
    public partial class FormCreateProjectCSharp : MaterialForm
    {

        public FormCreateProjectCSharp()
        {
            InitializeComponent();

          


        }

        
        public string folderName; 
        public string nameProject;
        
       

        private void materialButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                txtPath.Text = folderBrowserDialog1.SelectedPath;
                nameProject = txtName.Text;
               

             
            }
        }
        public event Action<string> FileCreatedEvent;

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("Введіть назву");
            }
            if (txtPath.Text == "")
            {
                MessageBox.Show("Введіть шлях");
            }
            if (!nameProject.EndsWith(".cs"))
            {
                nameProject += ".cs";
            }
            string fullPath = Path.Combine(folderName, nameProject);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(nameProject);


string templateFile = $@"using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace {fileNameWithoutExtension}
{{
    class Program
    {{
        static void Main(string[] args)
        {{
            Console.WriteLine(""Hello World"");
            Console.ReadKey();
        }}
    }}
}}";

            File.WriteAllText(fullPath, templateFile);
           
            FormCSharpCoder fcsh = new FormCSharpCoder(fullPath, fileNameWithoutExtension);
            fcsh.Show();



        }

        private void FormCreateProjectCSharp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FormCreatePtoject fcp = new FormCreatePtoject();
            fcp.Show(); 
        }
    }
}
