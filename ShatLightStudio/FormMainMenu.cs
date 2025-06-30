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

namespace ShatLightStudio
{
    public partial class FormMainMenu : MaterialForm
    {
        private string filePath;
        private string nameProject;

        public FormMainMenu()
        {
            InitializeComponent();
        }
    

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void проектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreatePtoject fcp = new FormCreatePtoject();
            fcp.Show();
            
        }

        private void FormMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void налаштуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings fs = new FormSettings();
            fs.Show();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void проПроєктToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutProject fap = new FormAboutProject();
            fap.Show();
        }

        private void контактнаІнформаціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContactInformation fci = new FormContactInformation();
            fci.Show();
        }

        private void CSharpOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.cs)|*.cs"; 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName; 
    
            }
           
           
            FormCSharpCoder fcss = new FormCSharpCoder(filePath, nameProject);
            fcss.Show();

        }

        private void HTMLOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.html)|*.html|Text Files (*.txt)|*.txt"; 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName; 

            }


            FormHTMLCoder fhtmlc = new FormHTMLCoder(filePath, nameProject);
            fhtmlc.Show();
        }

        private void CppOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.cpp)|*.cpp"; 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName; 

            }


            FormCppCoder fccp = new FormCppCoder(filePath, nameProject);
            fccp.Show();
        }
    }
}
