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
    public partial class FormCreateHTML : MaterialForm
    {
        public FormCreateHTML()
        {
            InitializeComponent();
        }
        public string folderNameHTML; 
        public string nameProjectHTML;
        private void FormCreateHTML_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!nameProjectHTML.EndsWith(".html"))
            {
                nameProjectHTML += ".html";
            }
            string fullPathHTML = Path.Combine(folderNameHTML, nameProjectHTML);
            string fileTitleHTML = Path.GetFileNameWithoutExtension(nameProjectHTML);


            string templateFileHTML = $@"<!DOCTYPE html>
<html>
<head>
 <meta charset=""utf-8"">
 <link rel=""stylesheet"" href=""style.css"">
 <script src=""script.js""></script>
<title> {fileTitleHTML} </title>
</head>

 <body>
     Вітаю, це моя сторінка
 </body>
</html>";

            File.WriteAllText(fullPathHTML, templateFileHTML);
            FormHTMLCoder ftmlf = new FormHTMLCoder(fullPathHTML, templateFileHTML);
            ftmlf.Show();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                folderNameHTML = folderBrowserDialog1.SelectedPath;
                txtPath.Text = folderBrowserDialog1.SelectedPath;
                nameProjectHTML = txtName.Text;
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
