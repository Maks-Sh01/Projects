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
namespace GameComplexMaksymShatalov
{
    public partial class FormHelpUser : MaterialForm
    {
        public FormHelpUser()
        {
            InitializeComponent();
        }

        private void FormHelpUser_Load(object sender, EventArgs e)
        {

        }

        private void materialButtonBack_Click(object sender, EventArgs e)
        {
            FormMenu fm = new FormMenu();
            ActiveForm.Visible = false;
            fm.Show();
        }

        private void materialLabelEmail_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:Maksym.Shatalov@infiz.khpi.edu.ua?subject=Test%20subject");
            Label labelemail = sender as Label;

            if (labelemail != null)
            {
                Clipboard.SetText(labelemail.Text, TextDataFormat.UnicodeText);
            }
        }
    }
}
