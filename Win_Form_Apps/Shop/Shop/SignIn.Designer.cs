namespace Shop {
    partial class SignIn {
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.cardsSignin = new Bunifu.Framework.UI.BunifuCards();
            this.lblError = new System.Windows.Forms.Label();
            this.inputPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.inputUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictTopPictureUser = new System.Windows.Forms.PictureBox();
            this.btnSignIn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRegisterNow = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictPass = new System.Windows.Forms.PictureBox();
            this.pictSignIn = new System.Windows.Forms.PictureBox();
            this.pictRegisterNow = new System.Windows.Forms.PictureBox();
            this.pictUserName = new System.Windows.Forms.PictureBox();
            this.cardsSignin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictTopPictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSignIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRegisterNow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUserName)).BeginInit();
            this.SuspendLayout();
            // 
            // cardsSignin
            // 
            this.cardsSignin.BackColor = System.Drawing.Color.White;
            this.cardsSignin.BorderRadius = 0;
            this.cardsSignin.BottomSahddow = false;
            this.cardsSignin.color = System.Drawing.Color.Tomato;
            this.cardsSignin.Controls.Add(this.lblError);
            this.cardsSignin.Controls.Add(this.pictTopPictureUser);
            this.cardsSignin.Controls.Add(this.btnSignIn);
            this.cardsSignin.Controls.Add(this.btnRegisterNow);
            this.cardsSignin.Controls.Add(this.pictPass);
            this.cardsSignin.Controls.Add(this.inputPassword);
            this.cardsSignin.Controls.Add(this.pictSignIn);
            this.cardsSignin.Controls.Add(this.pictRegisterNow);
            this.cardsSignin.Controls.Add(this.pictUserName);
            this.cardsSignin.Controls.Add(this.inputUserName);
            this.cardsSignin.Controls.Add(this.separator);
            this.cardsSignin.LeftSahddow = false;
            this.cardsSignin.Location = new System.Drawing.Point(0, 0);
            this.cardsSignin.Name = "cardsSignin";
            this.cardsSignin.RightSahddow = false;
            this.cardsSignin.ShadowDepth = 0;
            this.cardsSignin.Size = new System.Drawing.Size(415, 561);
            this.cardsSignin.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Tomato;
            this.lblError.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblError.Location = new System.Drawing.Point(0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(415, 22);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "Error";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // inputPassword
            // 
            this.inputPassword.BackColor = System.Drawing.Color.White;
            this.inputPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputPassword.ForeColor = System.Drawing.Color.Black;
            this.inputPassword.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputPassword.HintText = "Password";
            this.inputPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inputPassword.isPassword = false;
            this.inputPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.inputPassword.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.inputPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.inputPassword.LineThickness = 5;
            this.inputPassword.Location = new System.Drawing.Point(78, 260);
            this.inputPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(314, 40);
            this.inputPassword.TabIndex = 1;
            this.inputPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputPassword.OnValueChanged += new System.EventHandler(this.inputPassword_OnValueChanged);
            // 
            // inputUserName
            // 
            this.inputUserName.BackColor = System.Drawing.Color.White;
            this.inputUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputUserName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputUserName.ForeColor = System.Drawing.Color.Black;
            this.inputUserName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputUserName.HintText = "UserName";
            this.inputUserName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.inputUserName.isPassword = false;
            this.inputUserName.LineFocusedColor = System.Drawing.Color.Blue;
            this.inputUserName.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.inputUserName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.inputUserName.LineThickness = 5;
            this.inputUserName.Location = new System.Drawing.Point(78, 179);
            this.inputUserName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.inputUserName.Name = "inputUserName";
            this.inputUserName.Size = new System.Drawing.Size(314, 40);
            this.inputUserName.TabIndex = 0;
            this.inputUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.Transparent;
            this.separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.separator.LineThickness = 10;
            this.separator.Location = new System.Drawing.Point(0, 450);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(483, 18);
            this.separator.TabIndex = 5;
            this.separator.Transparency = 255;
            this.separator.Vertical = false;
            // 
            // pictTopPictureUser
            // 
            this.pictTopPictureUser.Image = ((System.Drawing.Image)(resources.GetObject("pictTopPictureUser.Image")));
            this.pictTopPictureUser.Location = new System.Drawing.Point(10, 25);
            this.pictTopPictureUser.Name = "pictTopPictureUser";
            this.pictTopPictureUser.Size = new System.Drawing.Size(382, 110);
            this.pictTopPictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictTopPictureUser.TabIndex = 6;
            this.pictTopPictureUser.TabStop = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.ActiveBorderThickness = 1;
            this.btnSignIn.ActiveCornerRadius = 20;
            this.btnSignIn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSignIn.ActiveForecolor = System.Drawing.Color.White;
            this.btnSignIn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSignIn.BackColor = System.Drawing.Color.White;
            this.btnSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignIn.BackgroundImage")));
            this.btnSignIn.ButtonText = "SIGN IN";
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignIn.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSignIn.IdleBorderThickness = 1;
            this.btnSignIn.IdleCornerRadius = 20;
            this.btnSignIn.IdleFillColor = System.Drawing.Color.White;
            this.btnSignIn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSignIn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSignIn.Location = new System.Drawing.Point(78, 351);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(6);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(314, 55);
            this.btnSignIn.TabIndex = 0;
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegisterNow
            // 
            this.btnRegisterNow.ActiveBorderThickness = 1;
            this.btnRegisterNow.ActiveCornerRadius = 20;
            this.btnRegisterNow.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnRegisterNow.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegisterNow.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegisterNow.BackColor = System.Drawing.Color.White;
            this.btnRegisterNow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegisterNow.BackgroundImage")));
            this.btnRegisterNow.ButtonText = "Register Now";
            this.btnRegisterNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterNow.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegisterNow.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRegisterNow.IdleBorderThickness = 1;
            this.btnRegisterNow.IdleCornerRadius = 20;
            this.btnRegisterNow.IdleFillColor = System.Drawing.Color.White;
            this.btnRegisterNow.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnRegisterNow.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnRegisterNow.Location = new System.Drawing.Point(78, 496);
            this.btnRegisterNow.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegisterNow.Name = "btnRegisterNow";
            this.btnRegisterNow.Size = new System.Drawing.Size(314, 55);
            this.btnRegisterNow.TabIndex = 0;
            this.btnRegisterNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictPass
            // 
            this.pictPass.Image = ((System.Drawing.Image)(resources.GetObject("pictPass.Image")));
            this.pictPass.Location = new System.Drawing.Point(10, 258);
            this.pictPass.Name = "pictPass";
            this.pictPass.Size = new System.Drawing.Size(48, 48);
            this.pictPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictPass.TabIndex = 3;
            this.pictPass.TabStop = false;
            // 
            // pictSignIn
            // 
            this.pictSignIn.Image = ((System.Drawing.Image)(resources.GetObject("pictSignIn.Image")));
            this.pictSignIn.Location = new System.Drawing.Point(10, 351);
            this.pictSignIn.Name = "pictSignIn";
            this.pictSignIn.Size = new System.Drawing.Size(55, 55);
            this.pictSignIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictSignIn.TabIndex = 3;
            this.pictSignIn.TabStop = false;
            // 
            // pictRegisterNow
            // 
            this.pictRegisterNow.Image = ((System.Drawing.Image)(resources.GetObject("pictRegisterNow.Image")));
            this.pictRegisterNow.Location = new System.Drawing.Point(10, 496);
            this.pictRegisterNow.Name = "pictRegisterNow";
            this.pictRegisterNow.Size = new System.Drawing.Size(55, 55);
            this.pictRegisterNow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictRegisterNow.TabIndex = 3;
            this.pictRegisterNow.TabStop = false;
            // 
            // pictUserName
            // 
            this.pictUserName.Image = ((System.Drawing.Image)(resources.GetObject("pictUserName.Image")));
            this.pictUserName.Location = new System.Drawing.Point(10, 175);
            this.pictUserName.Name = "pictUserName";
            this.pictUserName.Size = new System.Drawing.Size(48, 48);
            this.pictUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictUserName.TabIndex = 3;
            this.pictUserName.TabStop = false;
            // 
            // SignIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cardsSignin);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "SignIn";
            this.Size = new System.Drawing.Size(415, 561);
            this.cardsSignin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictTopPictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSignIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRegisterNow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUserName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards cardsSignin;
        private System.Windows.Forms.PictureBox pictTopPictureUser;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSignIn;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegisterNow;
        private System.Windows.Forms.PictureBox pictPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputPassword;
        private System.Windows.Forms.PictureBox pictSignIn;
        private System.Windows.Forms.PictureBox pictRegisterNow;
        private System.Windows.Forms.PictureBox pictUserName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputUserName;
        private Bunifu.Framework.UI.BunifuSeparator separator;
        private System.Windows.Forms.Label lblError;
    }
}
