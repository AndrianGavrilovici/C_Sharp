﻿namespace testAppDesign {
    partial class controlAdminMenu {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlAdminMenu));
            this.btnAddNew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.activeBar = new System.Windows.Forms.Panel();
            this.btnEditAmount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPriceEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelCategory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelAll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureAdmin = new System.Windows.Forms.PictureBox();
            this.textAdminMenu = new System.Windows.Forms.Label();
            this.btnShowAll = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNew.BorderRadius = 0;
            this.btnAddNew.ButtonText = "Add another animal";
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddNew.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddNew.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Iconimage")));
            this.btnAddNew.Iconimage_right = null;
            this.btnAddNew.Iconimage_right_Selected = null;
            this.btnAddNew.Iconimage_Selected = null;
            this.btnAddNew.IconMarginLeft = 0;
            this.btnAddNew.IconMarginRight = 0;
            this.btnAddNew.IconRightVisible = true;
            this.btnAddNew.IconRightZoom = 0D;
            this.btnAddNew.IconVisible = true;
            this.btnAddNew.IconZoom = 40D;
            this.btnAddNew.IsTab = false;
            this.btnAddNew.Location = new System.Drawing.Point(7, 293);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddNew.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnAddNew.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddNew.selected = false;
            this.btnAddNew.Size = new System.Drawing.Size(257, 53);
            this.btnAddNew.TabIndex = 17;
            this.btnAddNew.Text = "Add another animal";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Textcolor = System.Drawing.Color.White;
            this.btnAddNew.TextFont = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "Search Animal";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearch.Iconimage")));
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 40D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(7, 185);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(257, 53);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Tag = "";
            this.btnSearch.Text = "Search Animal";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // activeBar
            // 
            this.activeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(79)))), ((int)(((byte)(58)))));
            this.activeBar.Location = new System.Drawing.Point(0, 185);
            this.activeBar.Name = "activeBar";
            this.activeBar.Size = new System.Drawing.Size(7, 52);
            this.activeBar.TabIndex = 14;
            // 
            // btnEditAmount
            // 
            this.btnEditAmount.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnEditAmount.BackColor = System.Drawing.Color.Transparent;
            this.btnEditAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditAmount.BorderRadius = 0;
            this.btnEditAmount.ButtonText = "Edit the amount of animals";
            this.btnEditAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditAmount.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditAmount.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditAmount.ForeColor = System.Drawing.Color.White;
            this.btnEditAmount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditAmount.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditAmount.Iconimage")));
            this.btnEditAmount.Iconimage_right = null;
            this.btnEditAmount.Iconimage_right_Selected = null;
            this.btnEditAmount.Iconimage_Selected = null;
            this.btnEditAmount.IconMarginLeft = 0;
            this.btnEditAmount.IconMarginRight = 0;
            this.btnEditAmount.IconRightVisible = true;
            this.btnEditAmount.IconRightZoom = 0D;
            this.btnEditAmount.IconVisible = true;
            this.btnEditAmount.IconZoom = 40D;
            this.btnEditAmount.IsTab = false;
            this.btnEditAmount.Location = new System.Drawing.Point(7, 347);
            this.btnEditAmount.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnEditAmount.Name = "btnEditAmount";
            this.btnEditAmount.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEditAmount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnEditAmount.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditAmount.selected = false;
            this.btnEditAmount.Size = new System.Drawing.Size(257, 53);
            this.btnEditAmount.TabIndex = 17;
            this.btnEditAmount.Text = "Edit the amount of animals";
            this.btnEditAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAmount.Textcolor = System.Drawing.Color.White;
            this.btnEditAmount.TextFont = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.btnEditAmount.Click += new System.EventHandler(this.btnEditAmount_Click);
            // 
            // btnPriceEdit
            // 
            this.btnPriceEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnPriceEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnPriceEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPriceEdit.BorderRadius = 0;
            this.btnPriceEdit.ButtonText = "Price editing";
            this.btnPriceEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriceEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnPriceEdit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPriceEdit.ForeColor = System.Drawing.Color.White;
            this.btnPriceEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPriceEdit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPriceEdit.Iconimage")));
            this.btnPriceEdit.Iconimage_right = null;
            this.btnPriceEdit.Iconimage_right_Selected = null;
            this.btnPriceEdit.Iconimage_Selected = null;
            this.btnPriceEdit.IconMarginLeft = 0;
            this.btnPriceEdit.IconMarginRight = 0;
            this.btnPriceEdit.IconRightVisible = true;
            this.btnPriceEdit.IconRightZoom = 0D;
            this.btnPriceEdit.IconVisible = true;
            this.btnPriceEdit.IconZoom = 40D;
            this.btnPriceEdit.IsTab = false;
            this.btnPriceEdit.Location = new System.Drawing.Point(7, 401);
            this.btnPriceEdit.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnPriceEdit.Name = "btnPriceEdit";
            this.btnPriceEdit.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPriceEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnPriceEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPriceEdit.selected = false;
            this.btnPriceEdit.Size = new System.Drawing.Size(257, 53);
            this.btnPriceEdit.TabIndex = 17;
            this.btnPriceEdit.Text = "Price editing";
            this.btnPriceEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPriceEdit.Textcolor = System.Drawing.Color.White;
            this.btnPriceEdit.TextFont = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.btnPriceEdit.Click += new System.EventHandler(this.btnPriceEdit_Click);
            // 
            // btnDelCategory
            // 
            this.btnDelCategory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnDelCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnDelCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelCategory.BorderRadius = 0;
            this.btnDelCategory.ButtonText = "Delete category animal";
            this.btnDelCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelCategory.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelCategory.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelCategory.ForeColor = System.Drawing.Color.White;
            this.btnDelCategory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelCategory.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelCategory.Iconimage")));
            this.btnDelCategory.Iconimage_right = null;
            this.btnDelCategory.Iconimage_right_Selected = null;
            this.btnDelCategory.Iconimage_Selected = null;
            this.btnDelCategory.IconMarginLeft = 0;
            this.btnDelCategory.IconMarginRight = 0;
            this.btnDelCategory.IconRightVisible = true;
            this.btnDelCategory.IconRightZoom = 0D;
            this.btnDelCategory.IconVisible = true;
            this.btnDelCategory.IconZoom = 40D;
            this.btnDelCategory.IsTab = false;
            this.btnDelCategory.Location = new System.Drawing.Point(7, 455);
            this.btnDelCategory.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnDelCategory.Name = "btnDelCategory";
            this.btnDelCategory.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDelCategory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnDelCategory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelCategory.selected = false;
            this.btnDelCategory.Size = new System.Drawing.Size(257, 53);
            this.btnDelCategory.TabIndex = 17;
            this.btnDelCategory.Text = "Delete category animal";
            this.btnDelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelCategory.Textcolor = System.Drawing.Color.White;
            this.btnDelCategory.TextFont = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.btnDelCategory.Click += new System.EventHandler(this.btnDelCategory_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnDelAll.BackColor = System.Drawing.Color.Transparent;
            this.btnDelAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelAll.BorderRadius = 0;
            this.btnDelAll.ButtonText = "Delete all animals";
            this.btnDelAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelAll.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelAll.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelAll.ForeColor = System.Drawing.Color.White;
            this.btnDelAll.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelAll.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelAll.Iconimage")));
            this.btnDelAll.Iconimage_right = null;
            this.btnDelAll.Iconimage_right_Selected = null;
            this.btnDelAll.Iconimage_Selected = null;
            this.btnDelAll.IconMarginLeft = 0;
            this.btnDelAll.IconMarginRight = 0;
            this.btnDelAll.IconRightVisible = true;
            this.btnDelAll.IconRightZoom = 0D;
            this.btnDelAll.IconVisible = true;
            this.btnDelAll.IconZoom = 40D;
            this.btnDelAll.IsTab = false;
            this.btnDelAll.Location = new System.Drawing.Point(7, 509);
            this.btnDelAll.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDelAll.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnDelAll.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelAll.selected = false;
            this.btnDelAll.Size = new System.Drawing.Size(257, 53);
            this.btnDelAll.TabIndex = 17;
            this.btnDelAll.Text = "Delete all animals";
            this.btnDelAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelAll.Textcolor = System.Drawing.Color.White;
            this.btnDelAll.TextFont = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureAdmin
            // 
            this.pictureAdmin.BackColor = System.Drawing.Color.Transparent;
            this.pictureAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureAdmin.BackgroundImage")));
            this.pictureAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureAdmin.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureAdmin.InitialImage")));
            this.pictureAdmin.Location = new System.Drawing.Point(7, 3);
            this.pictureAdmin.Name = "pictureAdmin";
            this.pictureAdmin.Size = new System.Drawing.Size(240, 108);
            this.pictureAdmin.TabIndex = 18;
            this.pictureAdmin.TabStop = false;
            this.pictureAdmin.WaitOnLoad = true;
            // 
            // textAdminMenu
            // 
            this.textAdminMenu.AutoSize = true;
            this.textAdminMenu.BackColor = System.Drawing.Color.Transparent;
            this.textAdminMenu.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAdminMenu.ForeColor = System.Drawing.Color.White;
            this.textAdminMenu.Location = new System.Drawing.Point(36, 114);
            this.textAdminMenu.Name = "textAdminMenu";
            this.textAdminMenu.Size = new System.Drawing.Size(211, 29);
            this.textAdminMenu.TabIndex = 19;
            this.textAdminMenu.Text = "Administrator Menu";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnShowAll.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowAll.BorderRadius = 0;
            this.btnShowAll.ButtonText = "Show All Animals";
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.DisabledColor = System.Drawing.Color.Gray;
            this.btnShowAll.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShowAll.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShowAll.Iconimage")));
            this.btnShowAll.Iconimage_right = null;
            this.btnShowAll.Iconimage_right_Selected = null;
            this.btnShowAll.Iconimage_Selected = null;
            this.btnShowAll.IconMarginLeft = 0;
            this.btnShowAll.IconMarginRight = 0;
            this.btnShowAll.IconRightVisible = true;
            this.btnShowAll.IconRightZoom = 0D;
            this.btnShowAll.IconVisible = true;
            this.btnShowAll.IconZoom = 40D;
            this.btnShowAll.IsTab = false;
            this.btnShowAll.Location = new System.Drawing.Point(7, 239);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Normalcolor = System.Drawing.Color.Transparent;
            this.btnShowAll.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.btnShowAll.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShowAll.selected = false;
            this.btnShowAll.Size = new System.Drawing.Size(257, 53);
            this.btnShowAll.TabIndex = 20;
            this.btnShowAll.Text = "Show All Animals";
            this.btnShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAll.Textcolor = System.Drawing.Color.White;
            this.btnShowAll.TextFont = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // controlAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.textAdminMenu);
            this.Controls.Add(this.pictureAdmin);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnDelCategory);
            this.Controls.Add(this.btnPriceEdit);
            this.Controls.Add(this.btnEditAmount);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.activeBar);
            this.Name = "controlAdminMenu";
            this.Size = new System.Drawing.Size(264, 648);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnAddNew;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private System.Windows.Forms.Panel activeBar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditAmount;
        private Bunifu.Framework.UI.BunifuFlatButton btnPriceEdit;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelCategory;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelAll;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureAdmin;
        private System.Windows.Forms.Label textAdminMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnShowAll;
    }
}