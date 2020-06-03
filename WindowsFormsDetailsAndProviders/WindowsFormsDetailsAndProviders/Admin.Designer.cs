namespace WindowsFormsDetailsAndProviders
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grBHello = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabControlAll = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageProviders = new System.Windows.Forms.TabPage();
            this.tabPageDelivery = new System.Windows.Forms.TabPage();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grBHello.SuspendLayout();
            this.tabControlAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(736, 312);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grBHello
            // 
            this.grBHello.BackColor = System.Drawing.Color.DimGray;
            this.grBHello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grBHello.Controls.Add(this.btnDel);
            this.grBHello.Controls.Add(this.btnSave);
            this.grBHello.Controls.Add(this.btnAdd);
            this.grBHello.Dock = System.Windows.Forms.DockStyle.Left;
            this.grBHello.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBHello.ForeColor = System.Drawing.Color.White;
            this.grBHello.Location = new System.Drawing.Point(0, 0);
            this.grBHello.Name = "grBHello";
            this.grBHello.Size = new System.Drawing.Size(190, 312);
            this.grBHello.TabIndex = 5;
            this.grBHello.TabStop = false;
            // 
            // btnDel
            // 
            this.btnDel.ForeColor = System.Drawing.Color.Black;
            this.btnDel.Location = new System.Drawing.Point(12, 149);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(159, 40);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(12, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(159, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(12, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabControlAll
            // 
            this.tabControlAll.Controls.Add(this.tabPage1);
            this.tabControlAll.Controls.Add(this.tabPageProviders);
            this.tabControlAll.Controls.Add(this.tabPageDelivery);
            this.tabControlAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlAll.Location = new System.Drawing.Point(190, 0);
            this.tabControlAll.Name = "tabControlAll";
            this.tabControlAll.SelectedIndex = 0;
            this.tabControlAll.ShowToolTips = true;
            this.tabControlAll.Size = new System.Drawing.Size(546, 27);
            this.tabControlAll.TabIndex = 6;
            this.tabControlAll.SelectedIndexChanged += new System.EventHandler(this.tabControlAll_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(538, 1);
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
            this.tabPageProviders.Size = new System.Drawing.Size(538, 1);
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
            this.tabPageDelivery.Size = new System.Drawing.Size(538, 1);
            this.tabPageDelivery.TabIndex = 2;
            this.tabPageDelivery.Text = "Сдача товара";
            this.tabPageDelivery.ToolTipText = "Посмотреть информацию о таблице Сдача";
            this.tabPageDelivery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAll.Location = new System.Drawing.Point(190, 27);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.Size = new System.Drawing.Size(546, 285);
            this.dataGridViewAll.TabIndex = 7;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 312);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.tabControlAll);
            this.Controls.Add(this.grBHello);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin";
            this.Text = "Система БД";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grBHello.ResumeLayout(false);
            this.tabControlAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grBHello;
        private System.Windows.Forms.TabControl tabControlAll;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageProviders;
        private System.Windows.Forms.TabPage tabPageDelivery;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewAll;
    }
}