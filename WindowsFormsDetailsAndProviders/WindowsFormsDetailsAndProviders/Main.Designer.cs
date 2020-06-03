namespace WindowsFormsDetailsAndProviders
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.picBoxBackground = new System.Windows.Forms.PictureBox();
            this.picBoxEnter = new System.Windows.Forms.PictureBox();
            this.picBoxView = new System.Windows.Forms.PictureBox();
            this.picBoxExit = new System.Windows.Forms.PictureBox();
            this.grBAutorization = new System.Windows.Forms.GroupBox();
            this.chBView = new System.Windows.Forms.CheckBox();
            this.linkLblForget = new System.Windows.Forms.LinkLabel();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtBLogin = new System.Windows.Forms.TextBox();
            this.masktxtBPass = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).BeginInit();
            this.grBAutorization.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxBackground
            // 
            this.picBoxBackground.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picBoxBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxBackground.BackgroundImage")));
            this.picBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxBackground.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBackground.Image")));
            this.picBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.picBoxBackground.Name = "picBoxBackground";
            this.picBoxBackground.Size = new System.Drawing.Size(675, 403);
            this.picBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBackground.TabIndex = 0;
            this.picBoxBackground.TabStop = false;
            // 
            // picBoxEnter
            // 
            this.picBoxEnter.BackColor = System.Drawing.Color.Silver;
            this.picBoxEnter.Image = ((System.Drawing.Image)(resources.GetObject("picBoxEnter.Image")));
            this.picBoxEnter.Location = new System.Drawing.Point(349, 76);
            this.picBoxEnter.Name = "picBoxEnter";
            this.picBoxEnter.Size = new System.Drawing.Size(176, 68);
            this.picBoxEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxEnter.TabIndex = 1;
            this.picBoxEnter.TabStop = false;
            this.picBoxEnter.Click += new System.EventHandler(this.picBoxEnter_Click);
            this.picBoxEnter.MouseLeave += new System.EventHandler(this.picBoxEnter_MouseLeave);
            this.picBoxEnter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxEnter_MouseMove);
            // 
            // picBoxView
            // 
            this.picBoxView.BackColor = System.Drawing.Color.Silver;
            this.picBoxView.Image = ((System.Drawing.Image)(resources.GetObject("picBoxView.Image")));
            this.picBoxView.Location = new System.Drawing.Point(349, 160);
            this.picBoxView.Name = "picBoxView";
            this.picBoxView.Size = new System.Drawing.Size(176, 68);
            this.picBoxView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxView.TabIndex = 2;
            this.picBoxView.TabStop = false;
            this.picBoxView.Click += new System.EventHandler(this.picBoxView_Click);
            this.picBoxView.MouseLeave += new System.EventHandler(this.picBoxView_MouseLeave);
            this.picBoxView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxView_MouseMove);
            // 
            // picBoxExit
            // 
            this.picBoxExit.BackColor = System.Drawing.Color.Silver;
            this.picBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("picBoxExit.Image")));
            this.picBoxExit.Location = new System.Drawing.Point(349, 245);
            this.picBoxExit.Name = "picBoxExit";
            this.picBoxExit.Size = new System.Drawing.Size(176, 68);
            this.picBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxExit.TabIndex = 3;
            this.picBoxExit.TabStop = false;
            this.picBoxExit.Click += new System.EventHandler(this.picBoxExit_Click);
            this.picBoxExit.MouseLeave += new System.EventHandler(this.picBoxExit_MouseLeave);
            this.picBoxExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxExit_MouseMove);
            // 
            // grBAutorization
            // 
            this.grBAutorization.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grBAutorization.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grBAutorization.Controls.Add(this.chBView);
            this.grBAutorization.Controls.Add(this.linkLblForget);
            this.grBAutorization.Controls.Add(this.lblPass);
            this.grBAutorization.Controls.Add(this.lblLogin);
            this.grBAutorization.Controls.Add(this.txtBLogin);
            this.grBAutorization.Controls.Add(this.masktxtBPass);
            this.grBAutorization.Dock = System.Windows.Forms.DockStyle.Left;
            this.grBAutorization.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBAutorization.ForeColor = System.Drawing.Color.White;
            this.grBAutorization.Location = new System.Drawing.Point(0, 0);
            this.grBAutorization.Name = "grBAutorization";
            this.grBAutorization.Size = new System.Drawing.Size(213, 403);
            this.grBAutorization.TabIndex = 4;
            this.grBAutorization.TabStop = false;
            this.grBAutorization.Text = "Авторизация";
            this.grBAutorization.Visible = false;
            // 
            // chBView
            // 
            this.chBView.AutoSize = true;
            this.chBView.Location = new System.Drawing.Point(185, 190);
            this.chBView.Name = "chBView";
            this.chBView.Size = new System.Drawing.Size(15, 14);
            this.chBView.TabIndex = 5;
            this.chBView.UseVisualStyleBackColor = true;
            this.chBView.CheckedChanged += new System.EventHandler(this.chBView_CheckedChanged);
            // 
            // linkLblForget
            // 
            this.linkLblForget.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLblForget.AutoSize = true;
            this.linkLblForget.LinkColor = System.Drawing.Color.White;
            this.linkLblForget.Location = new System.Drawing.Point(3, 221);
            this.linkLblForget.Name = "linkLblForget";
            this.linkLblForget.Size = new System.Drawing.Size(207, 20);
            this.linkLblForget.TabIndex = 4;
            this.linkLblForget.TabStop = true;
            this.linkLblForget.Text = "Забыли логин или пароль?";
            this.linkLblForget.VisitedLinkColor = System.Drawing.Color.Fuchsia;
            this.linkLblForget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblForget_LinkClicked);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(6, 160);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(127, 20);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Введите пароль";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(6, 94);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(114, 20);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Введите логин";
            // 
            // txtBLogin
            // 
            this.txtBLogin.Location = new System.Drawing.Point(6, 118);
            this.txtBLogin.Name = "txtBLogin";
            this.txtBLogin.Size = new System.Drawing.Size(171, 26);
            this.txtBLogin.TabIndex = 0;
            // 
            // masktxtBPass
            // 
            this.masktxtBPass.Location = new System.Drawing.Point(6, 183);
            this.masktxtBPass.Name = "masktxtBPass";
            this.masktxtBPass.Size = new System.Drawing.Size(171, 26);
            this.masktxtBPass.TabIndex = 1;
            this.masktxtBPass.UseSystemPasswordChar = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 403);
            this.Controls.Add(this.grBAutorization);
            this.Controls.Add(this.picBoxExit);
            this.Controls.Add(this.picBoxView);
            this.Controls.Add(this.picBoxEnter);
            this.Controls.Add(this.picBoxBackground);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Главное меню";
            this.Activated += new System.EventHandler(this.Main_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).EndInit();
            this.grBAutorization.ResumeLayout(false);
            this.grBAutorization.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxBackground;
        private System.Windows.Forms.PictureBox picBoxEnter;
        private System.Windows.Forms.PictureBox picBoxView;
        private System.Windows.Forms.PictureBox picBoxExit;
        private System.Windows.Forms.GroupBox grBAutorization;
        private System.Windows.Forms.LinkLabel linkLblForget;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtBLogin;
        private System.Windows.Forms.MaskedTextBox masktxtBPass;
        private System.Windows.Forms.CheckBox chBView;
    }
}