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
    public partial class FormCreatePtoject : MaterialForm
    {
        public FormCreatePtoject()
        {
            InitializeComponent();


        }

     

        private void btnNext_Click(object sender, EventArgs e)
        {
           
            string selectedValue = listboxchoice.SelectedItem.ToString();

            int lang = listboxchoice.SelectedIndex;

            if (lang >= 0)
            {
                if (lang == 0)
                {
                    FormCreateProjectCSharp fcpcs = new FormCreateProjectCSharp();
                    fcpcs.Show();
                    this.Hide();
                }
                else if (lang == 1)
                {
                    FormCreateProjectCpp fcpc = new FormCreateProjectCpp();
                    fcpc.Show();
                    this.Hide();
                }
                else if (lang == 2)
                {
                    FormCreateHTML fgtml = new FormCreateHTML();
                    fgtml.Show();
                    this.Hide();
                }
            }



        }

        
    }
}
