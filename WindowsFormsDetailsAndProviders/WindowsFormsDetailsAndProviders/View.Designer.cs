namespace WindowsFormsDetailsAndProviders
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.tabControlAll = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageProviders = new System.Windows.Forms.TabPage();
            this.tabPageDelivery = new System.Windows.Forms.TabPage();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.tabControlAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAll
            // 
            this.tabControlAll.Controls.Add(this.tabPage1);
            this.tabControlAll.Controls.Add(this.tabPageProviders);
            this.tabControlAll.Controls.Add(this.tabPageDelivery);
            this.tabControlAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlAll.Location = new System.Drawing.Point(0, 0);
            this.tabControlAll.Name = "tabControlAll";
            this.tabControlAll.SelectedIndex = 0;
            this.tabControlAll.ShowToolTips = true;
            this.tabControlAll.Size = new System.Drawing.Size(503, 27);
            this.tabControlAll.TabIndex = 1;
            this.tabControlAll.SelectedIndexChanged += new System.EventHandler(this.tabControlAll_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(495, 1);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Детали";
            this.tabPage1.ToolTipText = "Посмотреть информацию о таблице Детали";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPageProviders
            // 
            this.tabPageProviders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageProviders.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageProviders.Location = new System.Drawing.Point(4, 22);
            this.tabPageProviders.Name = "tabPageProviders";
            this.tabPageProviders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProviders.Size = new System.Drawing.Size(495, 1);
            this.tabPageProviders.TabIndex = 1;
            this.tabPageProviders.Text = "Поставщики";
            this.tabPageProviders.ToolTipText = "Посмотреть информацию о таблице Поставщики";
            this.tabPageProviders.UseVisualStyleBackColor = true;
            // 
            // tabPageDelivery
            // 
            this.tabPageDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageDelivery.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageDelivery.Location = new System.Drawing.Point(4, 22);
            this.tabPageDelivery.Name = "tabPageDelivery";
            this.tabPageDelivery.Size = new System.Drawing.Size(495, 1);
            this.tabPageDelivery.TabIndex = 2;
            this.tabPageDelivery.Text = "Сдача товара";
            this.tabPageDelivery.ToolTipText = "Посмотреть информацию о таблице Сдача";
            this.tabPageDelivery.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackground.BackgroundImage")));
            this.pictureBoxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 27);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(503, 230);
            this.pictureBoxBackground.TabIndex = 2;
            this.pictureBoxBackground.TabStop = false;
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Location = new System.Drawing.Point(22, 43);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.ReadOnly = true;
            this.dataGridViewAll.Size = new System.Drawing.Size(456, 204);
            this.dataGridViewAll.TabIndex = 3;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 257);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.pictureBoxBackground);
            this.Controls.Add(this.tabControlAll);
            this.Name = "View";
            this.Text = "Посмотреть информацию БД";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.View_FormClosed);
            this.tabControlAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAll;
        private System.Windows.Forms.TabPage tabPageProviders;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.DataGridView dataGridViewAll;
        private System.Windows.Forms.TabPage tabPageDelivery;
    }
}