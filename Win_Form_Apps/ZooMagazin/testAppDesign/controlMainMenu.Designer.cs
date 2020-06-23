﻿namespace testAppDesign
{
    partial class controlMainMenu
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlMainMenu));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.activeBar = new System.Windows.Forms.Panel();
            this.btnUserMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdminMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textHome = new System.Windows.Forms.Label();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.SuspendLayout();
            // 
            // activeBar
            // 
            this.activeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(79)))), ((int)(((byte)(58)))));
            this.activeBar.Location = new System.Drawing.Point(0, 185);
            this.activeBar.Name = "activeBar";
            this.activeBar.Size = new System.Drawing.Size(7, 52);
            this.activeBar.TabIndex = 7;
            // 
            // btnUserMenu
            // 
            this.btnUserMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnUserMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnUserMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserMenu.BorderRadius = 0;
            this.btnUserMenu.ButtonText = "User Menu";
            this.btnUserMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnUserMenu.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUserMenu.ForeColor = System.Drawing.Color.White;
            this.btnUserMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUserMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUserMenu.Iconimage")));
            this.btnUserMenu.Iconimage_right = null;
            this.btnUserMenu.Iconimage_right_Selected = null;
            this.btnUserMenu.Iconimage_Selected = null;
            this.btnUserMenu.IconMarginLeft = 0;
            this.btnUserMenu.IconMarginRight = 0;
            this.btnUserMenu.IconRightVisible = true;
            this.btnUserMenu.IconRightZoom = 0D;
            this.btnUserMenu.IconVisible = true;
            this.btnUserMenu.IconZoom = 40D;
            this.btnUserMenu.IsTab = false;
            this.btnUserMenu.Location = new System.Drawing.Point(7, 238);
            this.btnUserMenu.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnUserMenu.Name = "btnUserMenu";
            this.btnUserMenu.Normalcolor = System.Drawing.Color.Transparent;
            this.btnUserMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnUserMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUserMenu.selected = false;
            this.btnUserMenu.Size = new System.Drawing.Size(257, 53);
            this.btnUserMenu.TabIndex = 8;
            this.btnUserMenu.Tag = "";
            this.btnUserMenu.Text = "User Menu";
            this.btnUserMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserMenu.Textcolor = System.Drawing.Color.White;
            this.btnUserMenu.TextFont = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.btnUserMenu.Click += new System.EventHandler(this.btnUserMenu_Click);
            // 
            // btnAdminMenu
            // 
            this.btnAdminMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnAdminMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdminMenu.BorderRadius = 0;
            this.btnAdminMenu.ButtonText = "Admin Menu";
            this.btnAdminMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdminMenu.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdminMenu.ForeColor = System.Drawing.Color.White;
            this.btnAdminMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdminMenu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdminMenu.Iconimage")));
            this.btnAdminMenu.Iconimage_right = null;
            this.btnAdminMenu.Iconimage_right_Selected = null;
            this.btnAdminMenu.Iconimage_Selected = null;
            this.btnAdminMenu.IconMarginLeft = 0;
            this.btnAdminMenu.IconMarginRight = 0;
            this.btnAdminMenu.IconRightVisible = true;
            this.btnAdminMenu.IconRightZoom = 0D;
            this.btnAdminMenu.IconVisible = true;
            this.btnAdminMenu.IconZoom = 40D;
            this.btnAdminMenu.IsTab = false;
            this.btnAdminMenu.Location = new System.Drawing.Point(7, 291);
            this.btnAdminMenu.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnAdminMenu.Name = "btnAdminMenu";
            this.btnAdminMenu.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAdminMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnAdminMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdminMenu.selected = false;
            this.btnAdminMenu.Size = new System.Drawing.Size(257, 53);
            this.btnAdminMenu.TabIndex = 9;
            this.btnAdminMenu.Text = "Admin Menu";
            this.btnAdminMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminMenu.Textcolor = System.Drawing.Color.White;
            this.btnAdminMenu.TextFont = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.btnAdminMenu.Click += new System.EventHandler(this.btnAdminMenu_Click);
            // 
            // textHome
            // 
            this.textHome.AutoSize = true;
            this.textHome.BackColor = System.Drawing.Color.Transparent;
            this.textHome.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textHome.ForeColor = System.Drawing.Color.White;
            this.textHome.Location = new System.Drawing.Point(99, 114);
            this.textHome.Name = "textHome";
            this.textHome.Size = new System.Drawing.Size(67, 29);
            this.textHome.TabIndex = 22;
            this.textHome.Text = "Home";
            // 
            // pictureHome
            // 
            this.pictureHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureHome.BackgroundImage")));
            this.pictureHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureHome.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureHome.InitialImage")));
            this.pictureHome.Location = new System.Drawing.Point(7, 3);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(240, 108);
            this.pictureHome.TabIndex = 21;
            this.pictureHome.TabStop = false;
            this.pictureHome.WaitOnLoad = true;
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 40D;
            this.btnHome.IsTab = false;
            this.btnHome.Location = new System.Drawing.Point(7, 185);
            this.btnHome.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(257, 53);
            this.btnHome.TabIndex = 8;
            this.btnHome.Tag = "";
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.White;
            this.btnHome.TextFont = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // controlMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.textHome);
            this.Controls.Add(this.pictureHome);
            this.Controls.Add(this.btnAdminMenu);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnUserMenu);
            this.Controls.Add(this.activeBar);
            this.Name = "controlMainMenu";
            this.Size = new System.Drawing.Size(264, 648);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel activeBar;
        private Bunifu.Framework.UI.BunifuFlatButton btnUserMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdminMenu;
        private System.Windows.Forms.Label textHome;
        private System.Windows.Forms.PictureBox pictureHome;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
    }
}
