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
using System.Drawing;
using System.Drawing.Drawing2D;
using MaterialSkin;
namespace GameComplexMaksymShatalov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mProgressBar1.Value == 100)
            {
                timer1.Enabled = false;

                FormMenu fm = new FormMenu();
                fm.Show();
                this.Hide();
                

            }
            else
            {
                mProgressBar1.Value += 20;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }
    }
    
}
