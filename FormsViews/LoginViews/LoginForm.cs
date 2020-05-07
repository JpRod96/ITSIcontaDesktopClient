using ITSIContaDesktopClient.Controllers;
using ITSIContaDesktopClient.FormsViews.LoginViews;
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

namespace ITSIContaDesktopClient
{
    public partial class LoginForm : MaterialForm
    {
        private readonly UserController userController;
        private const string EMPTY_TEXT = "";
        private const string USERNAME_DEFAULT_TEXT = "Nombre de usuario";
        private const string PASSWORD_DEFAULT_TEXT = "Contraseña";
        private string passwordContent;

        public LoginForm()
        {
            userController = new UserController();
            InitializeComponent();
            BeforeShown();
        }

        private void BeforeShown()
        {
            MaterialConfig();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            presIconPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            userNameTxtBox.Text = USERNAME_DEFAULT_TEXT;
            passwordTxtBox.Text = PASSWORD_DEFAULT_TEXT;
            passwordContent = "";
        }

        private void MaterialConfig()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            CheckForConnection();
        }

        private void CheckForConnection()
        {
            CheckingConnectionForm checkingConnectionDLG = new CheckingConnectionForm();
            checkingConnectionDLG.ShowDialog();
        }

        private void UserNameTxtBox_Click(object sender, EventArgs e)
        {
            TextBoxPlaceholderContent(userNameTxtBox, USERNAME_DEFAULT_TEXT, true);
        }

        private void PasswordTxtBox_Click(object sender, EventArgs e)
        {
            TextBoxPlaceholderContent(passwordTxtBox, PASSWORD_DEFAULT_TEXT, true);
        }

        private void UserNameTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxPlaceholderContent(userNameTxtBox, USERNAME_DEFAULT_TEXT, false);
        }

        private void PasswordTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxPlaceholderContent(passwordTxtBox, PASSWORD_DEFAULT_TEXT, false);
        }

        private void TextBoxPlaceholderContent(MaterialSingleLineTextField textBox, string defaultText, bool isClicking)
        {
            string content = textBox.Text;
            if (isClicking)
            {
                content = content.Equals(defaultText) ? EMPTY_TEXT : content;
            }
            else
            {
                content = content.Equals(EMPTY_TEXT) ? defaultText : content;
            }
            textBox.Text = content;
        }
    }
}
