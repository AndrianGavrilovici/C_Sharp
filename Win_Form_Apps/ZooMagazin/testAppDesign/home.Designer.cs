﻿using System.Drawing;

namespace testAppDesign
{
    partial class home
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnExit1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.designTopText = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.bunifuRoundHome = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragHome = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.topPanel.Controls.Add(this.btnExit1);
            this.topPanel.Controls.Add(this.btnExit);
            this.topPanel.Controls.Add(this.designTopText);
            this.topPanel.Controls.Add(this.btnBack);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(308, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1007, 28);
            this.topPanel.TabIndex = 1;
            // 
            // btnExit1
            // 
            this.btnExit1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(152)))), ((int)(((byte)(87)))));
            this.btnExit1.BackColor = System.Drawing.Color.Transparent;
            this.btnExit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit1.BorderRadius = 0;
            this.btnExit1.ButtonText = "";
            this.btnExit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit1.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit1.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExit1.Iconimage")));
            this.btnExit1.Iconimage_right = null;
            this.btnExit1.Iconimage_right_Selected = null;
            this.btnExit1.Iconimage_Selected = null;
            this.btnExit1.IconMarginLeft = 5;
            this.btnExit1.IconMarginRight = 0;
            this.btnExit1.IconRightVisible = true;
            this.btnExit1.IconRightZoom = 0D;
            this.btnExit1.IconVisible = true;
            this.btnExit1.IconZoom = 38D;
            this.btnExit1.IsTab = false;
            this.btnExit1.Location = new System.Drawing.Point(1239, 0);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Normalcolor = System.Drawing.Color.Transparent;
            this.btnExit1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(152)))), ((int)(((byte)(87)))));
            this.btnExit1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit1.selected = false;
            this.btnExit1.Size = new System.Drawing.Size(50, 37);
            this.btnExit1.TabIndex = 0;
            this.btnExit1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit1.Textcolor = System.Drawing.Color.White;
            this.btnExit1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(79)))), ((int)(((byte)(58)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(59)))), ((int)(((byte)(38)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(958, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 28);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // designTopText
            // 
            this.designTopText.AutoSize = true;
            this.designTopText.BackColor = System.Drawing.Color.Transparent;
            this.designTopText.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.designTopText.ForeColor = System.Drawing.Color.White;
            this.designTopText.Location = new System.Drawing.Point(405, 4);
            this.designTopText.Name = "designTopText";
            this.designTopText.Size = new System.Drawing.Size(124, 19);
            this.designTopText.TabIndex = 3;
            this.designTopText.Text = "App By Gavrilovici";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 28);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(308, 654);
            this.leftPanel.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(308, 28);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1007, 626);
            this.panelContainer.TabIndex = 2;
            // 
            // bunifuRoundHome
            // 
            this.bunifuRoundHome.ElipseRadius = 10;
            this.bunifuRoundHome.TargetControl = this;
            // 
            // bunifuDragHome
            // 
            this.bunifuDragHome.Fixed = true;
            this.bunifuDragHome.Horizontal = true;
            this.bunifuDragHome.TargetControl = this.topPanel;
            this.bunifuDragHome.Vertical = true;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 654);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "home";
            this.Tag = "";
            this.Text = "App By Gavrilovici";
            this.Load += new System.EventHandler(this.Home_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label designTopText;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelContainer;
        private Bunifu.Framework.UI.BunifuElipse bunifuRoundHome;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragHome;
        private System.Windows.Forms.Button btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit1;
    }
}

