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

namespace ITSIContaDesktopClient
{
    public partial class Login : Form
    {
        public Login()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }



        private void Login_Shown(object sender, EventArgs e)
        {
            CheckingConnectionForm checkingConnectionDLG = new CheckingConnectionForm();
            checkingConnectionDLG.FormBorderStyle = FormBorderStyle.FixedDialog;
            checkingConnectionDLG.MaximizeBox = false;
            checkingConnectionDLG.MinimizeBox = false;
            checkingConnectionDLG.StartPosition = FormStartPosition.CenterScreen;
            checkingConnectionDLG.ShowDialog();
        }
    }
}
