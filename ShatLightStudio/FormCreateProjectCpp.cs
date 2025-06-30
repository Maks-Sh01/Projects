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
using MaterialSkin;
using MaterialSkin.Controls;

namespace ShatLightStudio
{
    public partial class FormCreateProjectCpp : MaterialForm
    {
        public FormCreateProjectCpp()
        {
            InitializeComponent();
          

        }

        private void FormCreateProjectCpp_Load(object sender, EventArgs e)
        {

        }
        public string folderNameCpp; 
        public string nameProjectCpp;
        private void btnCreate_Click(object sender, EventArgs e)
        {

            string fullPathCpp = Path.Combine(folderNameCpp, nameProjectCpp);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(nameProjectCpp);

            if (!nameProjectCpp.EndsWith(".cpp"))
            {
                nameProjectCpp += ".cpp";
            }



            string templateFileCpp = $@"#include <iostream>

using namespace std;
int main()
{{
    cout << ""Hello World!\n"";
    system(""pause"");
}}
";
            File.WriteAllText(fullPathCpp, templateFileCpp);

            FormCppCoder fcppc = new FormCppCoder(fullPathCpp, templateFileCpp);
            fcppc.Show();
        }
        private void materialButton1_Click(object sender, EventArgs e)
                {
                DialogResult result = folderBrowserDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    folderNameCpp = folderBrowserDialog1.SelectedPath;
                    txtPath.Text = folderBrowserDialog1.SelectedPath;
                    nameProjectCpp = txtName.Text;
                }
            }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            FormCreatePtoject fcp = new FormCreatePtoject();
            fcp.Show();
        }
    }
}
