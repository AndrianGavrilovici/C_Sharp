﻿namespace testAppDesign {
    partial class ControlPass {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPass));
            this.panelEnterPass = new System.Windows.Forms.Panel();
            this.incorrectPass = new System.Windows.Forms.Label();
            this.btnEnter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.textEnterPass = new System.Windows.Forms.Label();
            this.bunifuRoundInput = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelEnterPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEnterPass
            // 
            this.panelEnterPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEnterPass.BackgroundImage")));
            this.panelEnterPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEnterPass.Controls.Add(this.incorrectPass);
            this.panelEnterPass.Controls.Add(this.btnEnter);
            this.panelEnterPass.Controls.Add(this.inputPassword);
            this.panelEnterPass.Controls.Add(this.textEnterPass);
            this.panelEnterPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEnterPass.Location = new System.Drawing.Point(0, 0);
            this.panelEnterPass.Name = "panelEnterPass";
            this.panelEnterPass.Size = new System.Drawing.Size(990, 626);
            this.panelEnterPass.TabIndex = 0;
            // 
            // incorrectPass
            // 
            this.incorrectPass.AutoSize = true;
            this.incorrectPass.BackColor = System.Drawing.Color.Transparent;
            this.incorrectPass.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incorrectPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(79)))), ((int)(((byte)(58)))));
            this.incorrectPass.Location = new System.Drawing.Point(54, 267);
            this.incorrectPass.MinimumSize = new System.Drawing.Size(674, 26);
            this.incorrectPass.Name = "incorrectPass";
            this.incorrectPass.Size = new System.Drawing.Size(674, 26);
            this.incorrectPass.TabIndex = 5;
            this.incorrectPass.Text = "Sorry, you have entered an incorrect password.";
            this.incorrectPass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnEnter
            // 
            this.btnEnter.Activecolor = System.Drawing.Color.Transparent;
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnter.BorderRadius = 0;
            this.btnEnter.ButtonText = "";
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.DisabledColor = System.Drawing.Color.Gray;
            this.btnEnter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEnter.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEnter.Iconimage")));
            this.btnEnter.Iconimage_right = null;
            this.btnEnter.Iconimage_right_Selected = null;
            this.btnEnter.Iconimage_Selected = null;
            this.btnEnter.IconMarginLeft = 0;
            this.btnEnter.IconMarginRight = 0;
            this.btnEnter.IconRightVisible = true;
            this.btnEnter.IconRightZoom = 0D;
            this.btnEnter.IconVisible = true;
            this.btnEnter.IconZoom = 80D;
            this.btnEnter.IsTab = false;
            this.btnEnter.Location = new System.Drawing.Point(734, 190);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEnter.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnEnter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEnter.selected = false;
            this.btnEnter.Size = new System.Drawing.Size(65, 65);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnter.Textcolor = System.Drawing.Color.White;
            this.btnEnter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // inputPassword
            // 
            this.inputPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputPassword.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputPassword.Location = new System.Drawing.Point(54, 217);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.PasswordChar = '*';
            this.inputPassword.Size = new System.Drawing.Size(674, 38);
            this.inputPassword.TabIndex = 1;
            this.inputPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputPassword.TextChanged += new System.EventHandler(this.inputPassword_TextChanged);
            this.inputPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputPassword_KeyDown);
            // 
            // textEnterPass
            // 
            this.textEnterPass.AutoSize = true;
            this.textEnterPass.BackColor = System.Drawing.Color.Transparent;
            this.textEnterPass.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEnterPass.Location = new System.Drawing.Point(46, 135);
            this.textEnterPass.MinimumSize = new System.Drawing.Size(674, 38);
            this.textEnterPass.Name = "textEnterPass";
            this.textEnterPass.Size = new System.Drawing.Size(674, 45);
            this.textEnterPass.TabIndex = 0;
            this.textEnterPass.Text = "Enter Password";
            this.textEnterPass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuRoundInput
            // 
            this.bunifuRoundInput.ElipseRadius = 10;
            this.bunifuRoundInput.TargetControl = this.inputPassword;
            // 
            // ControlPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEnterPass);
            this.Name = "ControlPass";
            this.Size = new System.Drawing.Size(990, 626);
            this.panelEnterPass.ResumeLayout(false);
            this.panelEnterPass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEnterPass;
        private System.Windows.Forms.Label textEnterPass;
        private System.Windows.Forms.TextBox inputPassword;
        private Bunifu.Framework.UI.BunifuElipse bunifuRoundInput;
        private Bunifu.Framework.UI.BunifuFlatButton btnEnter;
        private System.Windows.Forms.Label incorrectPass;
    }
}
