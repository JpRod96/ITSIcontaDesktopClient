using ITSIContaDesktopClient.FormsViews.ConnectionForms;
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
            MaterialConfig();
        }

        private void MaterialConfig()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void CheckingConnectionForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
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
