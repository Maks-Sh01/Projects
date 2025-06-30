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
using System.Diagnostics;



namespace ShatLightStudio
{
    public partial class FormContactInformation : MaterialForm
    {
        public FormContactInformation()
        {
            InitializeComponent();
        }

        private void FormContactInformation_Load(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:Maksym.Shatalov@infiz.khpi.edu.ua?subject=Test%20subject");
            Label lblemail = sender as Label;

            if (lblemail != null)
            {
                Clipboard.SetText(lblemail.Text, TextDataFormat.UnicodeText);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
