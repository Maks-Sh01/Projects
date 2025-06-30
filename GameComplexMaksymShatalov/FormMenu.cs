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
namespace GameComplexMaksymShatalov
{
    public partial class FormMenu : MaterialForm
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            FormSettings fs = new FormSettings();
            fs.Show();
            this.Hide();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            FormHelpUser fh = new FormHelpUser();
            fh.Show();
            this.Hide();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            FormGamesMenu fg = new FormGamesMenu();
            fg.Show();
            this.Hide();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
