using MaterialSkin;
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
using Tetris;
namespace GameComplexMaksymShatalov
{
    public partial class FormGamesMenu : MaterialForm
    {
        public FormGamesMenu()
        {
            InitializeComponent();
        
        }

        private void materialButtonBack_Click(object sender, EventArgs e)
        {
            FormMenu fm = new FormMenu();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            fm.Show();
            this.Hide();
        }

   
        private void FormGamesMenu_Load(object sender, EventArgs e)
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this); 
            
        }

        private void btnTicTacToe_Click(object sender, EventArgs e)
        {
            FormTicTacToe TicTacToe = new FormTicTacToe();
            TicTacToe.Show();
        }

 
    


     

        private void btnWeFromUkraine_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://stream4.nadaje.com:9889/lux?nocache=2933";
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormGamesMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Application.Exit();

        }

        private void btnHitFm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://www.hitfm.ua/HitFM.m3u";
        }

        private void btnKISSFm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://www.kissfm.ua/KissFM.m3u";
        }

        private void btnAutoRadio_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://cast.radiogroup.com.ua/avtoradio";
        }

        private void btnSuspilne_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://91.218.213.49:8000/ur1-mp3";
        }

        private void btnRoksfm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://online.radioroks.ua/RadioROKS";
        }

        private void btnNasheRadio_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://online.nasheradio.ua/NasheRadio";
        }

        private void btnPershefm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://live.radiopershe.com/liveradio320";
        }

        private void btnProminFm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://91.218.213.49:8000/ur2-mp3";
        }

        private void btnClassicRadiofm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://online.classicradio.com.ua/ClassicRadio";
        }

        private void btnWeFromUkraine_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://stream4.nadaje.com:9889/lux?nocache=2933";
        }

        private void btnChoseMyMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Audio Files|*.wav;*.mp3;*.aac|All Files|*.*";
            openFileDialog.Title = "Оберіть мелодію";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                axWindowsMediaPlayer1.URL = fileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void btnMaximumfm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://streamvideo.luxnet.ua/maximum/smil:maximum.stream.smil/playlist.m3u8";
        }

        private void btnTetrisButton_Click(object sender, EventArgs e)
        {
            FormTetris ft = new FormTetris();
            ft.Show();
        }
    }
}
