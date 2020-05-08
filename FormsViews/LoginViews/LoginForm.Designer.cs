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
            this.generalPnl = new System.Windows.Forms.Panel();
            this.passwordTxtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.userNameTxtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.presIconPicBox = new System.Windows.Forms.PictureBox();
            this.logInBtn = new System.Windows.Forms.Button();
            this.generalPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presIconPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // generalPnl
            // 
            this.generalPnl.BackColor = System.Drawing.SystemColors.Window;
            this.generalPnl.Controls.Add(this.logInBtn);
            this.generalPnl.Controls.Add(this.passwordTxtBox);
            this.generalPnl.Controls.Add(this.userNameTxtBox);
            this.generalPnl.Controls.Add(this.presIconPicBox);
            this.generalPnl.Location = new System.Drawing.Point(1, 60);
            this.generalPnl.Name = "generalPnl";
            this.generalPnl.Size = new System.Drawing.Size(400, 482);
            this.generalPnl.TabIndex = 5;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.passwordTxtBox.Depth = 0;
            this.passwordTxtBox.Hint = "";
            this.passwordTxtBox.Location = new System.Drawing.Point(115, 363);
            this.passwordTxtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '\0';
            this.passwordTxtBox.SelectedText = "";
            this.passwordTxtBox.SelectionLength = 0;
            this.passwordTxtBox.SelectionStart = 0;
            this.passwordTxtBox.Size = new System.Drawing.Size(176, 23);
            this.passwordTxtBox.TabIndex = 7;
            this.passwordTxtBox.UseSystemPasswordChar = false;
            this.passwordTxtBox.Click += new System.EventHandler(this.PasswordTxtBox_Click);
            this.passwordTxtBox.Leave += new System.EventHandler(this.PasswordTxtBox_Leave);
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.userNameTxtBox.Depth = 0;
            this.userNameTxtBox.Hint = "";
            this.userNameTxtBox.Location = new System.Drawing.Point(115, 322);
            this.userNameTxtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.PasswordChar = '\0';
            this.userNameTxtBox.SelectedText = "";
            this.userNameTxtBox.SelectionLength = 0;
            this.userNameTxtBox.SelectionStart = 0;
            this.userNameTxtBox.Size = new System.Drawing.Size(176, 23);
            this.userNameTxtBox.TabIndex = 6;
            this.userNameTxtBox.UseSystemPasswordChar = false;
            this.userNameTxtBox.Click += new System.EventHandler(this.UserNameTxtBox_Click);
            this.userNameTxtBox.Leave += new System.EventHandler(this.UserNameTxtBox_Leave);
            // 
            // presIconPicBox
            // 
            this.presIconPicBox.Image = global::ITSIContaDesktopClient.Properties.Resources.presentationIcon;
            this.presIconPicBox.Location = new System.Drawing.Point(69, 29);
            this.presIconPicBox.Name = "presIconPicBox";
            this.presIconPicBox.Size = new System.Drawing.Size(260, 260);
            this.presIconPicBox.TabIndex = 5;
            this.presIconPicBox.TabStop = false;
            // 
            // logInBtn
            // 
            this.logInBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.logInBtn.FlatAppearance.BorderSize = 0;
            this.logInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logInBtn.Location = new System.Drawing.Point(144, 416);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(100, 40);
            this.logInBtn.TabIndex = 3;
            this.logInBtn.Text = "Entrar";
            this.logInBtn.UseVisualStyleBackColor = false;
            this.logInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 540);
            this.Controls.Add(this.generalPnl);
            this.Name = "LoginForm";
            this.Text = "Iniciar Sesión";
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.generalPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.presIconPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel generalPnl;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTxtBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField userNameTxtBox;
        private System.Windows.Forms.PictureBox presIconPicBox;
        private System.Windows.Forms.Button logInBtn;
    }
}

