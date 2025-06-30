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
    public partial class FormHTMLStart : MaterialForm
    {
        private string HTMLCoder;

        public FormHTMLStart(string HTMLCode)
        {
            InitializeComponent();
            this.HTMLCoder = HTMLCode;

        }

        private void FormHTMLStart_Load(object sender, EventArgs e)
        {
            webBrowserHTML.DocumentText = HTMLCoder.ToString();
            webBrowserHTML.ScriptErrorsSuppressed = true;


        }

        private void webBrowserHTML_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
