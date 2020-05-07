namespace ITSIContaDesktopClient.FormsViews.ConnectionForms
{
    partial class ConnectionFailedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionFailedForm));
            this.MsgLbl = new System.Windows.Forms.Label();
            this.tryAgainBtn = new System.Windows.Forms.Button();
            this.tittleLbl = new System.Windows.Forms.Label();
            this.exitProgramBtn = new System.Windows.Forms.Button();
            this.serverLinkLbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // MsgLbl
            // 
            this.MsgLbl.AutoSize = true;
            this.MsgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgLbl.Location = new System.Drawing.Point(29, 127);
            this.MsgLbl.Name = "MsgLbl";
            this.MsgLbl.Size = new System.Drawing.Size(311, 136);
            this.MsgLbl.TabIndex = 2;
            this.MsgLbl.Text = resources.GetString("MsgLbl.Text");
            // 
            // tryAgainBtn
            // 
            this.tryAgainBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.tryAgainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tryAgainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryAgainBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tryAgainBtn.Location = new System.Drawing.Point(117, 292);
            this.tryAgainBtn.Name = "tryAgainBtn";
            this.tryAgainBtn.Size = new System.Drawing.Size(133, 36);
            this.tryAgainBtn.TabIndex = 3;
            this.tryAgainBtn.Text = "Volver a intentar";
            this.tryAgainBtn.UseVisualStyleBackColor = false;
            this.tryAgainBtn.Click += new System.EventHandler(this.TryAgainBtn_Click);
            // 
            // tittleLbl
            // 
            this.tittleLbl.AutoSize = true;
            this.tittleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittleLbl.Location = new System.Drawing.Point(12, 86);
            this.tittleLbl.Name = "tittleLbl";
            this.tittleLbl.Size = new System.Drawing.Size(351, 24);
            this.tittleLbl.TabIndex = 4;
            this.tittleLbl.Text = "No se logró conectar con el servidor";
            // 
            // exitProgramBtn
            // 
            this.exitProgramBtn.BackColor = System.Drawing.Color.Red;
            this.exitProgramBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitProgramBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitProgramBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitProgramBtn.Location = new System.Drawing.Point(107, 344);
            this.exitProgramBtn.Name = "exitProgramBtn";
            this.exitProgramBtn.Size = new System.Drawing.Size(153, 36);
            this.exitProgramBtn.TabIndex = 5;
            this.exitProgramBtn.Text = "Salir del programa";
            this.exitProgramBtn.UseVisualStyleBackColor = false;
            this.exitProgramBtn.Click += new System.EventHandler(this.ExitProgramBtn_Click);
            // 
            // serverLinkLbl
            // 
            this.serverLinkLbl.AutoSize = true;
            this.serverLinkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverLinkLbl.Location = new System.Drawing.Point(102, 211);
            this.serverLinkLbl.Name = "serverLinkLbl";
            this.serverLinkLbl.Size = new System.Drawing.Size(101, 17);
            this.serverLinkLbl.TabIndex = 6;
            this.serverLinkLbl.TabStop = true;
            this.serverLinkLbl.Tag = "";
            this.serverLinkLbl.Text = "www.itsisrl.com";
            this.serverLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ServerLinkLbl_LinkClicked);
            // 
            // ConnectionFailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 415);
            this.ControlBox = false;
            this.Controls.Add(this.serverLinkLbl);
            this.Controls.Add(this.exitProgramBtn);
            this.Controls.Add(this.tittleLbl);
            this.Controls.Add(this.tryAgainBtn);
            this.Controls.Add(this.MsgLbl);
            this.Name = "ConnectionFailedForm";
            this.Text = "Conexión fallida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MsgLbl;
        private System.Windows.Forms.Button tryAgainBtn;
        private System.Windows.Forms.Label tittleLbl;
        private System.Windows.Forms.Button exitProgramBtn;
        private System.Windows.Forms.LinkLabel serverLinkLbl;
    }
}