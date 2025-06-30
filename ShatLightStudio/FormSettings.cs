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
    public partial class FormSettings : MaterialForm
    {
        public event Action<bool> DarkModeStateChanged; 


        public FormSettings()
        {
            InitializeComponent();
            bool isDarkModeEnabled = Switch_DM.Checked;
            DarkModeStateChanged?.Invoke(isDarkModeEnabled); 

            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            Switch_DM.Checked = Properties.Settings.Default.DM;

        }



        private void Switch_DM_CheckedChanged(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.Theme = Switch_DM.Checked ? MaterialSkin.MaterialSkinManager.Themes.DARK : MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            Properties.Settings.Default.DM = Switch_DM.Checked;
            Properties.Settings.Default.Save();
        }


        }
 }
    





































