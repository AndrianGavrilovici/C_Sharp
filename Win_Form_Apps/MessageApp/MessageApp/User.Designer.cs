namespace MessageApp {
    partial class User {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AnimatedSideOn = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlUserMenu = new System.Windows.Forms.Panel();
            this.AnimatedSideOff = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.userTitle = new Bunifu.Framework.UI.BunifuTileButton();
            this.setting = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAboutUS = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSidePanel = new Bunifu.Framework.UI.BunifuImageButton();
            this.messages = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnContact = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.subMenu1 = new MessageApp.SubMenu();
            this.TopPanel.SuspendLayout();
            this.pnlUserMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSidePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TopPanel.Controls.Add(this.btnExit);
            this.AnimatedSideOff.SetDecoration(this.TopPanel, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.TopPanel, BunifuAnimatorNS.DecorationType.None);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1092, 16);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // AnimatedSideOn
            // 
            this.AnimatedSideOn.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimatedSideOn.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.AnimatedSideOn.DefaultAnimation = animation3;
            this.AnimatedSideOn.Interval = 9;
            // 
            // pnlUserMenu
            // 
            this.pnlUserMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.pnlUserMenu.Controls.Add(this.userTitle);
            this.pnlUserMenu.Controls.Add(this.setting);
            this.pnlUserMenu.Controls.Add(this.btnAboutUS);
            this.pnlUserMenu.Controls.Add(this.btnSidePanel);
            this.pnlUserMenu.Controls.Add(this.messages);
            this.pnlUserMenu.Controls.Add(this.btnContact);
            this.AnimatedSideOff.SetDecoration(this.pnlUserMenu, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.pnlUserMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlUserMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUserMenu.Location = new System.Drawing.Point(0, 16);
            this.pnlUserMenu.Name = "pnlUserMenu";
            this.pnlUserMenu.Size = new System.Drawing.Size(215, 661);
            this.pnlUserMenu.TabIndex = 1;
            // 
            // AnimatedSideOff
            // 
            this.AnimatedSideOff.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimatedSideOff.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.AnimatedSideOff.DefaultAnimation = animation4;
            // 
            // userTitle
            // 
            this.userTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userTitle.BackColor = System.Drawing.Color.SeaGreen;
            this.userTitle.color = System.Drawing.Color.SeaGreen;
            this.userTitle.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.userTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimatedSideOff.SetDecoration(this.userTitle, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.userTitle, BunifuAnimatorNS.DecorationType.None);
            this.userTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.userTitle.ForeColor = System.Drawing.Color.White;
            this.userTitle.Image = ((System.Drawing.Image)(resources.GetObject("userTitle.Image")));
            this.userTitle.ImagePosition = 2;
            this.userTitle.ImageZoom = 45;
            this.userTitle.LabelPosition = 28;
            this.userTitle.LabelText = "User Name";
            this.userTitle.Location = new System.Drawing.Point(0, 48);
            this.userTitle.Margin = new System.Windows.Forms.Padding(6);
            this.userTitle.Name = "userTitle";
            this.userTitle.Size = new System.Drawing.Size(215, 125);
            this.userTitle.TabIndex = 10;
            this.userTitle.Visible = false;
            // 
            // setting
            // 
            this.setting.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setting.BorderRadius = 0;
            this.setting.ButtonText = "   SETARI";
            this.setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimatedSideOff.SetDecoration(this.setting, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.setting, BunifuAnimatorNS.DecorationType.None);
            this.setting.DisabledColor = System.Drawing.Color.Gray;
            this.setting.Iconcolor = System.Drawing.Color.Transparent;
            this.setting.Iconimage = ((System.Drawing.Image)(resources.GetObject("setting.Iconimage")));
            this.setting.Iconimage_right = null;
            this.setting.Iconimage_right_Selected = null;
            this.setting.Iconimage_Selected = null;
            this.setting.IconMarginLeft = 0;
            this.setting.IconMarginRight = 0;
            this.setting.IconRightVisible = true;
            this.setting.IconRightZoom = 0D;
            this.setting.IconVisible = true;
            this.setting.IconZoom = 70D;
            this.setting.IsTab = false;
            this.setting.Location = new System.Drawing.Point(0, 294);
            this.setting.Name = "setting";
            this.setting.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.setting.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.setting.OnHoverTextColor = System.Drawing.Color.White;
            this.setting.selected = false;
            this.setting.Size = new System.Drawing.Size(216, 50);
            this.setting.TabIndex = 5;
            this.setting.Text = "   SETARI";
            this.setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setting.Textcolor = System.Drawing.Color.White;
            this.setting.TextFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // btnAboutUS
            // 
            this.btnAboutUS.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAboutUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAboutUS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAboutUS.BorderRadius = 0;
            this.btnAboutUS.ButtonText = "   DESPRE NOI";
            this.btnAboutUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimatedSideOff.SetDecoration(this.btnAboutUS, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.btnAboutUS, BunifuAnimatorNS.DecorationType.None);
            this.btnAboutUS.DisabledColor = System.Drawing.Color.Gray;
            this.btnAboutUS.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAboutUS.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAboutUS.Iconimage")));
            this.btnAboutUS.Iconimage_right = null;
            this.btnAboutUS.Iconimage_right_Selected = null;
            this.btnAboutUS.Iconimage_Selected = null;
            this.btnAboutUS.IconMarginLeft = 0;
            this.btnAboutUS.IconMarginRight = 0;
            this.btnAboutUS.IconRightVisible = true;
            this.btnAboutUS.IconRightZoom = 0D;
            this.btnAboutUS.IconVisible = true;
            this.btnAboutUS.IconZoom = 70D;
            this.btnAboutUS.IsTab = false;
            this.btnAboutUS.Location = new System.Drawing.Point(0, 350);
            this.btnAboutUS.Name = "btnAboutUS";
            this.btnAboutUS.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAboutUS.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAboutUS.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAboutUS.selected = false;
            this.btnAboutUS.Size = new System.Drawing.Size(216, 50);
            this.btnAboutUS.TabIndex = 6;
            this.btnAboutUS.Text = "   DESPRE NOI";
            this.btnAboutUS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUS.Textcolor = System.Drawing.Color.White;
            this.btnAboutUS.TextFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAboutUS.Click += new System.EventHandler(this.btnAboutUS_Click);
            // 
            // btnSidePanel
            // 
            this.btnSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSidePanel.BackColor = System.Drawing.Color.Transparent;
            this.btnSidePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimatedSideOff.SetDecoration(this.btnSidePanel, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.btnSidePanel, BunifuAnimatorNS.DecorationType.None);
            this.btnSidePanel.Image = ((System.Drawing.Image)(resources.GetObject("btnSidePanel.Image")));
            this.btnSidePanel.ImageActive = null;
            this.btnSidePanel.Location = new System.Drawing.Point(168, 0);
            this.btnSidePanel.Name = "btnSidePanel";
            this.btnSidePanel.Size = new System.Drawing.Size(44, 39);
            this.btnSidePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSidePanel.TabIndex = 8;
            this.btnSidePanel.TabStop = false;
            this.btnSidePanel.Zoom = 10;
            this.btnSidePanel.Click += new System.EventHandler(this.btnSidePanel_Click);
            // 
            // messages
            // 
            this.messages.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.messages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.messages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.messages.BorderRadius = 0;
            this.messages.ButtonText = "   MESAGE";
            this.messages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimatedSideOff.SetDecoration(this.messages, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.messages, BunifuAnimatorNS.DecorationType.None);
            this.messages.DisabledColor = System.Drawing.Color.Gray;
            this.messages.Iconcolor = System.Drawing.Color.Transparent;
            this.messages.Iconimage = ((System.Drawing.Image)(resources.GetObject("messages.Iconimage")));
            this.messages.Iconimage_right = null;
            this.messages.Iconimage_right_Selected = null;
            this.messages.Iconimage_Selected = null;
            this.messages.IconMarginLeft = 0;
            this.messages.IconMarginRight = 0;
            this.messages.IconRightVisible = true;
            this.messages.IconRightZoom = 0D;
            this.messages.IconVisible = true;
            this.messages.IconZoom = 70D;
            this.messages.IsTab = false;
            this.messages.Location = new System.Drawing.Point(0, 182);
            this.messages.Name = "messages";
            this.messages.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.messages.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.messages.OnHoverTextColor = System.Drawing.Color.White;
            this.messages.selected = false;
            this.messages.Size = new System.Drawing.Size(216, 50);
            this.messages.TabIndex = 7;
            this.messages.Text = "   MESAGE";
            this.messages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.messages.Textcolor = System.Drawing.Color.White;
            this.messages.TextFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messages.Click += new System.EventHandler(this.messages_Click);
            // 
            // btnContact
            // 
            this.btnContact.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContact.BorderRadius = 0;
            this.btnContact.ButtonText = "   CONTACTE";
            this.btnContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimatedSideOff.SetDecoration(this.btnContact, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.btnContact, BunifuAnimatorNS.DecorationType.None);
            this.btnContact.DisabledColor = System.Drawing.Color.Gray;
            this.btnContact.Iconcolor = System.Drawing.Color.Transparent;
            this.btnContact.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnContact.Iconimage")));
            this.btnContact.Iconimage_right = null;
            this.btnContact.Iconimage_right_Selected = null;
            this.btnContact.Iconimage_Selected = null;
            this.btnContact.IconMarginLeft = 0;
            this.btnContact.IconMarginRight = 0;
            this.btnContact.IconRightVisible = true;
            this.btnContact.IconRightZoom = 0D;
            this.btnContact.IconVisible = true;
            this.btnContact.IconZoom = 70D;
            this.btnContact.IsTab = false;
            this.btnContact.Location = new System.Drawing.Point(0, 238);
            this.btnContact.Name = "btnContact";
            this.btnContact.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnContact.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnContact.OnHoverTextColor = System.Drawing.Color.White;
            this.btnContact.selected = false;
            this.btnContact.Size = new System.Drawing.Size(216, 50);
            this.btnContact.TabIndex = 7;
            this.btnContact.Text = "   CONTACTE";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.Textcolor = System.Drawing.Color.White;
            this.btnContact.TextFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimatedSideOff.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.Image = global::MessageApp.Properties.Resources.Close;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(1070, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(14, 14);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // subMenu1
            // 
            this.AnimatedSideOn.SetDecoration(this.subMenu1, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.subMenu1, BunifuAnimatorNS.DecorationType.None);
            this.subMenu1.Location = new System.Drawing.Point(219, 23);
            this.subMenu1.Name = "subMenu1";
            this.subMenu1.Size = new System.Drawing.Size(215, 661);
            this.subMenu1.TabIndex = 2;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 677);
            this.Controls.Add(this.subMenu1);
            this.Controls.Add(this.pnlUserMenu);
            this.Controls.Add(this.TopPanel);
            this.AnimatedSideOn.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainProgram";
            this.TopPanel.ResumeLayout(false);
            this.pnlUserMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSidePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private BunifuAnimatorNS.BunifuTransition AnimatedSideOff;
        private BunifuAnimatorNS.BunifuTransition AnimatedSideOn;
        private System.Windows.Forms.Panel pnlUserMenu;
        private Bunifu.Framework.UI.BunifuFlatButton setting;
        private Bunifu.Framework.UI.BunifuFlatButton btnAboutUS;
        private Bunifu.Framework.UI.BunifuImageButton btnSidePanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnContact;
        private Bunifu.Framework.UI.BunifuFlatButton messages;
        private Bunifu.Framework.UI.BunifuTileButton userTitle;
        private SubMenu subMenu1;
    }
}

