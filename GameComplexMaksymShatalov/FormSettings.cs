using MaterialSkin.Controls;
using MaterialSkin;
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

namespace GameComplexMaksymShatalov
{
    public partial class FormSettings : MaterialForm
    {
        public FormSettings()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            materialSwitch1.Checked = Properties.Settings.Default.IsRemember;

        }

        private void materialButtonBack_Click(object sender, EventArgs e)
        {
            FormMenu fm = new FormMenu();
            fm.Show();
            this.Hide();
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.Theme = materialSwitch1.Checked ? MaterialSkin.MaterialSkinManager.Themes.DARK : MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            
            Properties.Settings.Default.IsRemember = materialSwitch1.Checked;
            Properties.Settings.Default.Save();
            



        }
      
    }
}
