using ITSIContaDesktopClient.FormsViews.ConnectionForms;
using ITSIContaDesktopClient.FormsViews.MaterialSkinConfig;
using ITSIContaDesktopClient.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSIContaDesktopClient.FormsViews.LoginViews
{
    public partial class CheckingConnectionForm : MaterialForm
    {
        public CheckingConnectionForm()
        {
            InitializeComponent();
            BeforeShown();
        }

        private void BeforeShown()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            MaterialFormManager.FormConfig(this);
        }

        private void CheckingConnectionForm_Load(object sender, EventArgs e)
        {
            loadingPicBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void CheckingConnectionForm_Shown(object sender, EventArgs e)
        {
            CheckConnection();
        }

        public async void CheckConnection()
        {
            APIService connectionCheckr = new APIService();
            if (await connectionCheckr.IsServerUp())
            {
                this.Close();
            }
            else
            {
                ConnectionFailedForm connectionFailedForm = new ConnectionFailedForm();
                connectionFailedForm.ShowDialog();

            }
        }

        private void CheckingConnectionForm_Activated(object sender, EventArgs e)
        {
            CheckConnection();
        }
    }
}
