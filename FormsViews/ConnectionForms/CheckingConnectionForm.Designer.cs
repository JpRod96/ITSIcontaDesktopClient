namespace ITSIContaDesktopClient.FormsViews.LoginViews
{
    partial class CheckingConnectionForm
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
            this.loadingPicBox = new System.Windows.Forms.PictureBox();
            this.MsgLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingPicBox
            // 
            this.loadingPicBox.Image = global::ITSIContaDesktopClient.Properties.Resources.loadingGif;
            this.loadingPicBox.Location = new System.Drawing.Point(62, 12);
            this.loadingPicBox.Name = "loadingPicBox";
            this.loadingPicBox.Size = new System.Drawing.Size(185, 116);
            this.loadingPicBox.TabIndex = 0;
            this.loadingPicBox.TabStop = false;
            // 
            // MsgLbl
            // 
            this.MsgLbl.AutoSize = true;
            this.MsgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgLbl.Location = new System.Drawing.Point(12, 143);
            this.MsgLbl.Name = "MsgLbl";
            this.MsgLbl.Size = new System.Drawing.Size(284, 34);
            this.MsgLbl.TabIndex = 1;
            this.MsgLbl.Text = "Comprobando su conexión a internet. \r\n           Un momento, por favor...";
            // 
            // CheckingConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(314, 207);
            this.ControlBox = false;
            this.Controls.Add(this.MsgLbl);
            this.Controls.Add(this.loadingPicBox);
            this.Name = "CheckingConnectionForm";
            this.Text = "Comprobando la conexión a internet";
            this.Activated += new System.EventHandler(this.CheckingConnectionForm_Activated);
            this.Load += new System.EventHandler(this.CheckingConnectionForm_Load);
            this.Shown += new System.EventHandler(this.CheckingConnectionForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.loadingPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loadingPicBox;
        private System.Windows.Forms.Label MsgLbl;
    }
}