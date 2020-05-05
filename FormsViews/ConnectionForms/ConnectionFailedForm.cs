using ITSIContaDesktopClient.FormsViews.LoginViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSIContaDesktopClient.FormsViews.ConnectionForms
{
    public partial class ConnectionFailedForm : Form
    {
        public ConnectionFailedForm()
        {
            InitializeComponent();
            BeforeShown();
        }

        private void BeforeShown()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void TryAgainBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitProgramBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ServerLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Global.APIURL);
        }
    }
}
