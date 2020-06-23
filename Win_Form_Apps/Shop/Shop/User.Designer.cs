namespace Shop {
    partial class User {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ExitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.AnimatedSideOn = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlUserMenu = new System.Windows.Forms.Panel();
            this.btnSidePanel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAboutUS = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnContact = new Bunifu.Framework.UI.BunifuFlatButton();
            this.userLogo = new System.Windows.Forms.PictureBox();
            this.btnProgram = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCastelMIMI = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGallery = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRestaurant = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEvents = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnWine = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnResort = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnsContent = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.castelMIMIContent1 = new Shop.CastelMIMIContent();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.AnimatedSideOff = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimatedContentOnOffSide = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.pnlUserMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSidePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).BeginInit();
            this.BtnsContent.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TopPanel.Controls.Add(this.ExitBtn);
            this.AnimatedSideOn.SetDecoration(this.TopPanel, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.TopPanel, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedContentOnOffSide.SetDecoration(this.TopPanel, BunifuAnimatorNS.DecorationType.None);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1327, 20);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimatedSideOn.SetDecoration(this.ExitBtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.ExitBtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedContentOnOffSide.SetDecoration(this.ExitBtn, BunifuAnimatorNS.DecorationType.None);
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageActive = null;
            this.ExitBtn.Location = new System.Drawing.Point(1306, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(15, 15);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Zoom = 10;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // AnimatedSideOn
            // 
            this.AnimatedSideOn.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.AnimatedSideOn.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.AnimatedSideOn.DefaultAnimation = animation1;
            this.AnimatedSideOn.Interval = 9;
            // 
            // pnlUserMenu
            // 
            this.pnlUserMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.pnlUserMenu.Controls.Add(this.btnSidePanel);
            this.pnlUserMenu.Controls.Add(this.btnAboutUS);
            this.pnlUserMenu.Controls.Add(this.btnContact);
            this.pnlUserMenu.Controls.Add(this.userLogo);
            this.pnlUserMenu.Controls.Add(this.btnProgram);
            this.pnlUserMenu.Controls.Add(this.btnCastelMIMI);
            this.pnlUserMenu.Controls.Add(this.btnGallery);
            this.pnlUserMenu.Controls.Add(this.btnRestaurant);
            this.pnlUserMenu.Controls.Add(this.btnEvents);
            this.pnlUserMenu.Controls.Add(this.btnWine);
            this.pnlUserMenu.Controls.Add(this.btnResort);
            this.AnimatedSideOn.SetDecoration(this.pnlUserMenu, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.pnlUserMenu, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedContentOnOffSide.SetDecoration(this.pnlUserMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlUserMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUserMenu.Location = new System.Drawing.Point(0, 20);
            this.pnlUserMenu.Name = "pnlUserMenu";
            this.pnlUserMenu.Size = new System.Drawing.Size(50, 721);
            this.pnlUserMenu.TabIndex = 4;
            // 
            // btnSidePanel
            // 
            this.btnSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSidePanel.BackColor = System.Drawing.Color.Transparent;
            this.btnSidePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimatedSideOn.SetDecoration(this.btnSidePanel, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.btnSidePanel, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedContentOnOffSide.SetDecoration(this.btnSidePanel, BunifuAnimatorNS.DecorationType.None);
            this.btnSidePanel.Image = ((System.Drawing.Image)(resources.GetObject("btnSidePanel.Image")));
            this.btnSidePanel.ImageActive = null;
            this.btnSidePanel.Location = new System.Drawing.Point(4, 3);
            this.btnSidePanel.Name = "btnSidePanel";
            this.btnSidePanel.Size = new System.Drawing.Size(43, 35);
            this.btnSidePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSidePanel.TabIndex = 2;
            this.btnSidePanel.TabStop = false;
            this.btnSidePanel.Zoom = 10;
            this.btnSidePanel.Click += new System.EventHandler(this.btnSidePanel_Click);
            // 
            // btnAboutUS
            // 
            this.btnAboutUS.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnAboutUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAboutUS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAboutUS.BorderRadius = 0;
            this.btnAboutUS.ButtonText = "   DESPRE NOI";
            this.btnAboutUS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimatedContentOnOffSide.SetDecoration(this.btnAboutUS, BunifuAnimatorNS.DecorationType.None);
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
            this.btnAboutUS.IconZoom = 55D;
            this.btnAboutUS.IsTab = false;
            this.btnAboutUS.Location = new System.Drawing.Point(0, 562);
            this.btnAboutUS.Name = "btnAboutUS";
            this.btnAboutUS.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAboutUS.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAboutUS.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAboutUS.selected = false;
            this.btnAboutUS.Size = new System.Drawing.Size(275, 50);
            this.btnAboutUS.TabIndex = 1;
            this.btnAboutUS.Tag = "8";
            this.btnAboutUS.Text = "   DESPRE NOI";
            this.btnAboutUS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUS.Textcolor = System.Drawing.Color.White;
            this.btnAboutUS.TextFont = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAboutUS.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnContact
            // 
            this.btnContact.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContact.BorderRadius = 0;
            this.btnContact.ButtonText = "   CONTACTE";
            this.btnContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimatedContentOnOffSide.SetDecoration(this.btnContact, BunifuAnimatorNS.DecorationType.None);
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
            this.btnContact.IconZoom = 55D;
            this.btnContact.IsTab = false;
            this.btnContact.Location = new System.Drawing.Point(0, 506);
            this.btnContact.Name = "btnContact";
            this.btnContact.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnContact.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnContact.OnHoverTextColor = System.Drawing.Color.White;
            this.btnContact.selected = false;
            this.btnContact.Size = new System.Drawing.Size(275, 50);
            this.btnContact.TabIndex = 1;
            this.btnContact.Tag = "7";
            this.btnContact.Text = "   CONTACTE";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.Textcolor = System.Drawing.Color.White;
            this.btnContact.TextFont = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContact.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // userLogo
            // 
            this.userLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimatedContentOnOffSide.SetDecoration(this.userLogo, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.userLogo, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.userLogo, BunifuAnimatorNS.DecorationType.None);
            this.userLogo.Image = ((System.Drawing.Image)(resources.GetObject("userLogo.Image")));
            this.userLogo.Location = new System.Drawing.Point(3, 20);
            this.userLogo.Name = "userLogo";
            this.userLogo.Size = new System.Drawing.Size(47, 88);
            this.userLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userLogo.TabIndex = 0;
            this.userLogo.TabStop = false;
            // 
            // btnProgram
            // 
            this.btnProgram.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProgram.BorderRadius = 0;
            this.btnProgram.ButtonText = "   PROGRAM";
            this.btnProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimatedContentOnOffSide.SetDecoration(this.btnProgram, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.btnProgram, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.btnProgram, BunifuAnimatorNS.DecorationType.None);
            this.btnProgram.DisabledColor = System.Drawing.Color.Gray;
            this.btnProgram.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProgram.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProgram.Iconimage")));
            this.btnProgram.Iconimage_right = null;
            this.btnProgram.Iconimage_right_Selected = null;
            this.btnProgram.Iconimage_Selected = null;
            this.btnProgram.IconMarginLeft = 0;
            this.btnProgram.IconMarginRight = 0;
            this.btnProgram.IconRightVisible = true;
            this.btnProgram.IconRightZoom = 0D;
            this.btnProgram.IconVisible = true;
            this.btnProgram.IconZoom = 55D;
            this.btnProgram.IsTab = false;
            this.btnProgram.Location = new System.Drawing.Point(0, 450);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnProgram.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnProgram.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProgram.selected = false;
            this.btnProgram.Size = new System.Drawing.Size(275, 50);
            this.btnProgram.TabIndex = 1;
            this.btnProgram.Tag = "6";
            this.btnProgram.Text = "   PROGRAM";
            this.btnProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProgram.Textcolor = System.Drawing.Color.White;
            this.btnProgram.TextFont = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProgram.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnCastelMIMI
            // 
            this.btnCastelMIMI.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnCastelMIMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCastelMIMI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCastelMIMI.BorderRadius = 0;
            this.btnCastelMIMI.ButtonText = "   CASTEL MIMI";
            this.btnCastelMIMI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimatedContentOnOffSide.SetDecoration(this.btnCastelMIMI, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.btnCastelMIMI, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.btnCastelMIMI, BunifuAnimatorNS.DecorationType.None);
            this.btnCastelMIMI.DisabledColor = System.Drawing.Color.Gray;
            this.btnCastelMIMI.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCastelMIMI.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCastelMIMI.Iconimage")));
            this.btnCastelMIMI.Iconimage_right = null;
            this.btnCastelMIMI.Iconimage_right_Selected = null;
            this.btnCastelMIMI.Iconimage_Selected = null;
            this.btnCastelMIMI.IconMarginLeft = 0;
            this.btnCastelMIMI.IconMarginRight = 0;
            this.btnCastelMIMI.IconRightVisible = true;
            this.btnCastelMIMI.IconRightZoom = 0D;
            this.btnCastelMIMI.IconVisible = true;
            this.btnCastelMIMI.IconZoom = 55D;
            this.btnCastelMIMI.IsTab = false;
            this.btnCastelMIMI.Location = new System.Drawing.Point(0, 114);
            this.btnCastelMIMI.Name = "btnCastelMIMI";
            this.btnCastelMIMI.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCastelMIMI.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCastelMIMI.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCastelMIMI.selected = false;
            this.btnCastelMIMI.Size = new System.Drawing.Size(275, 50);
            this.btnCastelMIMI.TabIndex = 1;
            this.btnCastelMIMI.Tag = "0";
            this.btnCastelMIMI.Text = "   CASTEL MIMI";
            this.btnCastelMIMI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCastelMIMI.Textcolor = System.Drawing.Color.White;
            this.btnCastelMIMI.TextFont = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCastelMIMI.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnGallery
            // 
            this.btnGallery.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnGallery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGallery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGallery.BorderRadius = 0;
            this.btnGallery.ButtonText = "   GALERIE";
            this.btnGallery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimatedContentOnOffSide.SetDecoration(this.btnGallery, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.btnGallery, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.btnGallery, BunifuAnimatorNS.DecorationType.None);
            this.btnGallery.DisabledColor = System.Drawing.Color.Gray;
            this.btnGallery.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGallery.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGallery.Iconimage")));
            this.btnGallery.Iconimage_right = null;
            this.btnGallery.Iconimage_right_Selected = null;
            this.btnGallery.Iconimage_Selected = null;
            this.btnGallery.IconMarginLeft = 0;
            this.btnGallery.IconMarginRight = 0;
            this.btnGallery.IconRightVisible = true;
            this.btnGallery.IconRightZoom = 0D;
            this.btnGallery.IconVisible = true;
            this.btnGallery.IconZoom = 55D;
            this.btnGallery.IsTab = false;
            this.btnGallery.Location = new System.Drawing.Point(0, 394);
            this.btnGallery.Name = "btnGallery";
            this.btnGallery.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGallery.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGallery.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGallery.selected = false;
            this.btnGallery.Size = new System.Drawing.Size(275, 50);
            this.btnGallery.TabIndex = 1;
            this.btnGallery.Tag = "5";
            this.btnGallery.Text = "   GALERIE";
            this.btnGallery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGallery.Textcolor = System.Drawing.Color.White;
            this.btnGallery.TextFont = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGallery.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnRestaurant
            // 
            this.btnRestaurant.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnRestaurant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRestaurant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurant.BorderRadius = 0;
            this.btnRestaurant.ButtonText = "   RESTAURANT";
            this.btnRestaurant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimatedContentOnOffSide.SetDecoration(this.btnRestaurant, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.btnRestaurant, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.btnRestaurant, BunifuAnimatorNS.DecorationType.None);
            this.btnRestaurant.DisabledColor = System.Drawing.Color.Gray;
            this.btnRestaurant.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRestaurant.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRestaurant.Iconimage")));
            this.btnRestaurant.Iconimage_right = null;
            this.btnRestaurant.Iconimage_right_Selected = null;
            this.btnRestaurant.Iconimage_Selected = null;
            this.btnRestaurant.IconMarginLeft = 0;
            this.btnRestaurant.IconMarginRight = 0;
            this.btnRestaurant.IconRightVisible = true;
            this.btnRestaurant.IconRightZoom = 0D;
            this.btnRestaurant.IconVisible = true;
            this.btnRestaurant.IconZoom = 55D;
            this.btnRestaurant.IsTab = false;
            this.btnRestaurant.Location = new System.Drawing.Point(0, 170);
            this.btnRestaurant.Name = "btnRestaurant";
            this.btnRestaurant.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRestaurant.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRestaurant.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRestaurant.selected = false;
            this.btnRestaurant.Size = new System.Drawing.Size(275, 50);
            this.btnRestaurant.TabIndex = 1;
            this.btnRestaurant.Tag = "1";
            this.btnRestaurant.Text = "   RESTAURANT";
            this.btnRestaurant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestaurant.Textcolor = System.Drawing.Color.White;
            this.btnRestaurant.TextFont = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestaurant.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEvents.BorderRadius = 0;
            this.btnEvents.ButtonText = "   EVENIMENTE";
            this.btnEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimatedContentOnOffSide.SetDecoration(this.btnEvents, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.btnEvents, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.btnEvents, BunifuAnimatorNS.DecorationType.None);
            this.btnEvents.DisabledColor = System.Drawing.Color.Gray;
            this.btnEvents.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEvents.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEvents.Iconimage")));
            this.btnEvents.Iconimage_right = null;
            this.btnEvents.Iconimage_right_Selected = null;
            this.btnEvents.Iconimage_Selected = null;
            this.btnEvents.IconMarginLeft = 0;
            this.btnEvents.IconMarginRight = 0;
            this.btnEvents.IconRightVisible = true;
            this.btnEvents.IconRightZoom = 0D;
            this.btnEvents.IconVisible = true;
            this.btnEvents.IconZoom = 55D;
            this.btnEvents.IsTab = false;
            this.btnEvents.Location = new System.Drawing.Point(0, 338);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEvents.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEvents.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEvents.selected = false;
            this.btnEvents.Size = new System.Drawing.Size(275, 50);
            this.btnEvents.TabIndex = 1;
            this.btnEvents.Tag = "4";
            this.btnEvents.Text = "   EVENIMENTE";
            this.btnEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.Textcolor = System.Drawing.Color.White;
            this.btnEvents.TextFont = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEvents.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnWine
            // 
            this.btnWine.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnWine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnWine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWine.BorderRadius = 0;
            this.btnWine.ButtonText = "   VINURI";
            this.btnWine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimatedContentOnOffSide.SetDecoration(this.btnWine, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.btnWine, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.btnWine, BunifuAnimatorNS.DecorationType.None);
            this.btnWine.DisabledColor = System.Drawing.Color.Gray;
            this.btnWine.Iconcolor = System.Drawing.Color.Transparent;
            this.btnWine.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnWine.Iconimage")));
            this.btnWine.Iconimage_right = null;
            this.btnWine.Iconimage_right_Selected = null;
            this.btnWine.Iconimage_Selected = null;
            this.btnWine.IconMarginLeft = 0;
            this.btnWine.IconMarginRight = 0;
            this.btnWine.IconRightVisible = true;
            this.btnWine.IconRightZoom = 0D;
            this.btnWine.IconVisible = true;
            this.btnWine.IconZoom = 55D;
            this.btnWine.IsTab = false;
            this.btnWine.Location = new System.Drawing.Point(0, 226);
            this.btnWine.Name = "btnWine";
            this.btnWine.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnWine.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnWine.OnHoverTextColor = System.Drawing.Color.White;
            this.btnWine.selected = false;
            this.btnWine.Size = new System.Drawing.Size(275, 50);
            this.btnWine.TabIndex = 1;
            this.btnWine.Tag = "2";
            this.btnWine.Text = "   VINURI";
            this.btnWine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWine.Textcolor = System.Drawing.Color.White;
            this.btnWine.TextFont = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWine.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnResort
            // 
            this.btnResort.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btnResort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnResort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResort.BorderRadius = 0;
            this.btnResort.ButtonText = "   STATIUNE";
            this.btnResort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimatedContentOnOffSide.SetDecoration(this.btnResort, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.btnResort, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.btnResort, BunifuAnimatorNS.DecorationType.None);
            this.btnResort.DisabledColor = System.Drawing.Color.Gray;
            this.btnResort.Iconcolor = System.Drawing.Color.Transparent;
            this.btnResort.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnResort.Iconimage")));
            this.btnResort.Iconimage_right = null;
            this.btnResort.Iconimage_right_Selected = null;
            this.btnResort.Iconimage_Selected = null;
            this.btnResort.IconMarginLeft = 0;
            this.btnResort.IconMarginRight = 0;
            this.btnResort.IconRightVisible = true;
            this.btnResort.IconRightZoom = 0D;
            this.btnResort.IconVisible = true;
            this.btnResort.IconZoom = 55D;
            this.btnResort.IsTab = false;
            this.btnResort.Location = new System.Drawing.Point(0, 282);
            this.btnResort.Name = "btnResort";
            this.btnResort.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnResort.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnResort.OnHoverTextColor = System.Drawing.Color.White;
            this.btnResort.selected = false;
            this.btnResort.Size = new System.Drawing.Size(275, 50);
            this.btnResort.TabIndex = 1;
            this.btnResort.Tag = "3";
            this.btnResort.Text = "   STATIUNE";
            this.btnResort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResort.Textcolor = System.Drawing.Color.White;
            this.btnResort.TextFont = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResort.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // BtnsContent
            // 
            this.BtnsContent.Controls.Add(this.tabPage1);
            this.BtnsContent.Controls.Add(this.tabPage2);
            this.BtnsContent.Controls.Add(this.tabPage3);
            this.BtnsContent.Controls.Add(this.tabPage4);
            this.BtnsContent.Controls.Add(this.tabPage5);
            this.BtnsContent.Controls.Add(this.tabPage6);
            this.BtnsContent.Controls.Add(this.tabPage7);
            this.BtnsContent.Controls.Add(this.tabPage8);
            this.BtnsContent.Controls.Add(this.tabPage9);
            this.AnimatedSideOn.SetDecoration(this.BtnsContent, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.BtnsContent, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedContentOnOffSide.SetDecoration(this.BtnsContent, BunifuAnimatorNS.DecorationType.None);
            this.BtnsContent.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnsContent.Location = new System.Drawing.Point(47, -7);
            this.BtnsContent.Margin = new System.Windows.Forms.Padding(0);
            this.BtnsContent.Name = "BtnsContent";
            this.BtnsContent.SelectedIndex = 0;
            this.BtnsContent.Size = new System.Drawing.Size(1287, 748);
            this.BtnsContent.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.castelMIMIContent1);
            this.AnimatedContentOnOffSide.SetDecoration(this.tabPage1, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.tabPage1, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.tabPage1, BunifuAnimatorNS.DecorationType.None);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1279, 720);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "0";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // castelMIMIContent1
            // 
            this.castelMIMIContent1.BackColor = System.Drawing.Color.White;
            this.AnimatedContentOnOffSide.SetDecoration(this.castelMIMIContent1, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.castelMIMIContent1, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.castelMIMIContent1, BunifuAnimatorNS.DecorationType.None);
            this.castelMIMIContent1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.castelMIMIContent1.Location = new System.Drawing.Point(-4, 0);
            this.castelMIMIContent1.Name = "castelMIMIContent1";
            this.castelMIMIContent1.Size = new System.Drawing.Size(1283, 724);
            this.castelMIMIContent1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.AnimatedContentOnOffSide.SetDecoration(this.tabPage2, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.tabPage2, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.tabPage2, BunifuAnimatorNS.DecorationType.None);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1279, 720);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.AnimatedContentOnOffSide.SetDecoration(this.tabPage3, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.tabPage3, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.tabPage3, BunifuAnimatorNS.DecorationType.None);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1279, 720);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.AnimatedContentOnOffSide.SetDecoration(this.tabPage4, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.tabPage4, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.tabPage4, BunifuAnimatorNS.DecorationType.None);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1279, 720);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "3";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.AnimatedContentOnOffSide.SetDecoration(this.tabPage5, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.tabPage5, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.tabPage5, BunifuAnimatorNS.DecorationType.None);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1279, 720);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "4";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.AnimatedContentOnOffSide.SetDecoration(this.tabPage6, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.tabPage6, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.tabPage6, BunifuAnimatorNS.DecorationType.None);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1279, 720);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "5";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.AnimatedContentOnOffSide.SetDecoration(this.tabPage7, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.tabPage7, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.tabPage7, BunifuAnimatorNS.DecorationType.None);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1279, 720);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "6";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.AnimatedContentOnOffSide.SetDecoration(this.tabPage8, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.tabPage8, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.tabPage8, BunifuAnimatorNS.DecorationType.None);
            this.tabPage8.Location = new System.Drawing.Point(4, 24);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1279, 720);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "7";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.AnimatedContentOnOffSide.SetDecoration(this.tabPage9, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOff.SetDecoration(this.tabPage9, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this.tabPage9, BunifuAnimatorNS.DecorationType.None);
            this.tabPage9.Location = new System.Drawing.Point(4, 24);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1279, 720);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "8";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // AnimatedSideOff
            // 
            this.AnimatedSideOff.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.AnimatedSideOff.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.AnimatedSideOff.DefaultAnimation = animation2;
            // 
            // AnimatedContentOnOffSide
            // 
            this.AnimatedContentOnOffSide.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.AnimatedContentOnOffSide.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.AnimatedContentOnOffSide.DefaultAnimation = animation3;
            this.AnimatedContentOnOffSide.TimeStep = 0.1F;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 741);
            this.Controls.Add(this.pnlUserMenu);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BtnsContent);
            this.AnimatedSideOff.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedSideOn.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimatedContentOnOffSide.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.pnlUserMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSidePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).EndInit();
            this.BtnsContent.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private Bunifu.Framework.UI.BunifuImageButton ExitBtn;
        private BunifuAnimatorNS.BunifuTransition AnimatedSideOn;
        private System.Windows.Forms.Panel pnlUserMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnAboutUS;
        private Bunifu.Framework.UI.BunifuImageButton btnSidePanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnContact;
        private System.Windows.Forms.PictureBox userLogo;
        private Bunifu.Framework.UI.BunifuFlatButton btnProgram;
        private Bunifu.Framework.UI.BunifuFlatButton btnCastelMIMI;
        private Bunifu.Framework.UI.BunifuFlatButton btnGallery;
        private Bunifu.Framework.UI.BunifuFlatButton btnRestaurant;
        private Bunifu.Framework.UI.BunifuFlatButton btnEvents;
        private Bunifu.Framework.UI.BunifuFlatButton btnWine;
        private Bunifu.Framework.UI.BunifuFlatButton btnResort;
        private BunifuAnimatorNS.BunifuTransition AnimatedSideOff;
        private System.Windows.Forms.TabControl BtnsContent;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private BunifuAnimatorNS.BunifuTransition AnimatedContentOnOffSide;
        private CastelMIMIContent castelMIMIContent1;
    }
}