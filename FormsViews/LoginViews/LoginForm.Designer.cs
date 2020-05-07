namespace ITSIContaDesktopClient
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.presIconPicBox = new System.Windows.Forms.PictureBox();
            this.userNameTxtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordTxtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.presIconPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // presIconPicBox
            // 
            this.presIconPicBox.Image = global::ITSIContaDesktopClient.Properties.Resources.presentationIcon;
            this.presIconPicBox.Location = new System.Drawing.Point(69, 99);
            this.presIconPicBox.Name = "presIconPicBox";
            this.presIconPicBox.Size = new System.Drawing.Size(260, 260);
            this.presIconPicBox.TabIndex = 4;
            this.presIconPicBox.TabStop = false;
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.userNameTxtBox.Depth = 0;
            this.userNameTxtBox.Hint = "";
            this.userNameTxtBox.Location = new System.Drawing.Point(106, 395);
            this.userNameTxtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.PasswordChar = '\0';
            this.userNameTxtBox.SelectedText = "";
            this.userNameTxtBox.SelectionLength = 0;
            this.userNameTxtBox.SelectionStart = 0;
            this.userNameTxtBox.Size = new System.Drawing.Size(176, 23);
            this.userNameTxtBox.TabIndex = 1;
            this.userNameTxtBox.UseSystemPasswordChar = false;
            this.userNameTxtBox.Click += new System.EventHandler(this.UserNameTxtBox_Click);
            this.userNameTxtBox.Leave += new System.EventHandler(this.UserNameTxtBox_Leave);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.passwordTxtBox.Depth = 0;
            this.passwordTxtBox.Hint = "";
            this.passwordTxtBox.Location = new System.Drawing.Point(106, 434);
            this.passwordTxtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '\0';
            this.passwordTxtBox.SelectedText = "";
            this.passwordTxtBox.SelectionLength = 0;
            this.passwordTxtBox.SelectionStart = 0;
            this.passwordTxtBox.Size = new System.Drawing.Size(176, 23);
            this.passwordTxtBox.TabIndex = 2;
            this.passwordTxtBox.UseSystemPasswordChar = false;
            this.passwordTxtBox.Click += new System.EventHandler(this.PasswordTxtBox_Click);
            this.passwordTxtBox.Leave += new System.EventHandler(this.PasswordTxtBox_Leave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.presIconPicBox);
            this.Name = "LoginForm";
            this.Text = "Iniciar Sesión";
            this.Shown += new System.EventHandler(this.Login_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.presIconPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox presIconPicBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField userNameTxtBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTxtBox;
    }
}

