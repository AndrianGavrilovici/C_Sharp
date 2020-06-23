namespace MessageApp {
    partial class MainProgram {
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
            BunifuAnimatorNS.Animation animation19 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgram));
            BunifuAnimatorNS.Animation animation20 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation21 = new BunifuAnimatorNS.Animation();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ExitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.contentPanel = new System.Windows.Forms.Panel();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition3 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.signIn1 = new MessageApp.SignIn();
            this.registerNowAccount1 = new MessageApp.RegisterNowAccount();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TopPanel.Controls.Add(this.ExitBtn);
            this.bunifuTransition1.SetDecoration(this.TopPanel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.TopPanel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.TopPanel, BunifuAnimatorNS.DecorationType.None);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(515, 20);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.ExitBtn, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.ExitBtn, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.ExitBtn, BunifuAnimatorNS.DecorationType.None);
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageActive = null;
            this.ExitBtn.Location = new System.Drawing.Point(494, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(15, 15);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Zoom = 10;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation19.AnimateOnlyDifferences = true;
            animation19.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation19.BlindCoeff")));
            animation19.LeafCoeff = 0F;
            animation19.MaxTime = 1F;
            animation19.MinTime = 0F;
            animation19.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation19.MosaicCoeff")));
            animation19.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation19.MosaicShift")));
            animation19.MosaicSize = 0;
            animation19.Padding = new System.Windows.Forms.Padding(0);
            animation19.RotateCoeff = 0F;
            animation19.RotateLimit = 0F;
            animation19.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation19.ScaleCoeff")));
            animation19.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation19.SlideCoeff")));
            animation19.TimeCoeff = 0F;
            animation19.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation19;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(80)))));
            this.bunifuTransition1.SetDecoration(this.contentPanel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.contentPanel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this.contentPanel, BunifuAnimatorNS.DecorationType.None);
            this.contentPanel.Location = new System.Drawing.Point(0, 20);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(515, 319);
            this.contentPanel.TabIndex = 1;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.bunifuTransition2.Cursor = null;
            animation20.AnimateOnlyDifferences = true;
            animation20.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation20.BlindCoeff")));
            animation20.LeafCoeff = 0F;
            animation20.MaxTime = 1F;
            animation20.MinTime = 0F;
            animation20.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation20.MosaicCoeff")));
            animation20.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation20.MosaicShift")));
            animation20.MosaicSize = 0;
            animation20.Padding = new System.Windows.Forms.Padding(0);
            animation20.RotateCoeff = 0F;
            animation20.RotateLimit = 0F;
            animation20.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation20.ScaleCoeff")));
            animation20.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation20.SlideCoeff")));
            animation20.TimeCoeff = 0F;
            animation20.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation20;
            // 
            // bunifuTransition3
            // 
            this.bunifuTransition3.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.bunifuTransition3.Cursor = null;
            animation21.AnimateOnlyDifferences = true;
            animation21.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation21.BlindCoeff")));
            animation21.LeafCoeff = 0F;
            animation21.MaxTime = 1F;
            animation21.MinTime = 0F;
            animation21.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation21.MosaicCoeff")));
            animation21.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation21.MosaicShift")));
            animation21.MosaicSize = 0;
            animation21.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation21.RotateCoeff = 0F;
            animation21.RotateLimit = 0F;
            animation21.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation21.ScaleCoeff")));
            animation21.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation21.SlideCoeff")));
            animation21.TimeCoeff = 0F;
            animation21.TransparencyCoeff = 0F;
            this.bunifuTransition3.DefaultAnimation = animation21;
            this.bunifuTransition3.MaxAnimationTime = 1000;
            // 
            // signIn1
            // 
            this.signIn1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition3.SetDecoration(this.signIn1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.signIn1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.signIn1, BunifuAnimatorNS.DecorationType.None);
            this.signIn1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signIn1.Location = new System.Drawing.Point(50, 80);
            this.signIn1.Name = "signIn1";
            this.signIn1.Size = new System.Drawing.Size(415, 561);
            this.signIn1.TabIndex = 2;
            // 
            // registerNowAccount1
            // 
            this.registerNowAccount1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition3.SetDecoration(this.registerNowAccount1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.registerNowAccount1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.registerNowAccount1, BunifuAnimatorNS.DecorationType.None);
            this.registerNowAccount1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.registerNowAccount1.Location = new System.Drawing.Point(50, 80);
            this.registerNowAccount1.Name = "registerNowAccount1";
            this.registerNowAccount1.Size = new System.Drawing.Size(414, 561);
            this.registerNowAccount1.TabIndex = 3;
            this.registerNowAccount1.Visible = false;
            // 
            // MainProgram
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(515, 725);
            this.Controls.Add(this.registerNowAccount1);
            this.Controls.Add(this.signIn1);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.TopPanel);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition3.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private Bunifu.Framework.UI.BunifuImageButton ExitBtn;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel contentPanel;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition3;
        private SignIn signIn1;
        private RegisterNowAccount registerNowAccount1;
    }
}

