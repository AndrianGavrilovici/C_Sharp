﻿namespace testAppDesign {
    partial class controlDelCategory {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlDelCategory));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnEnter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.noExistAnimal = new System.Windows.Forms.Label();
            this.textEnterAnimal = new System.Windows.Forms.Label();
            this.inputSpecies = new System.Windows.Forms.TextBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnMale = new Bunifu.Framework.UI.BunifuFlatButton();
            this.succesDelete = new System.Windows.Forms.Label();
            this.btnFemale = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBoth = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelTop.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.btnEnter);
            this.panelTop.Controls.Add(this.noExistAnimal);
            this.panelTop.Controls.Add(this.textEnterAnimal);
            this.panelTop.Controls.Add(this.inputSpecies);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(990, 234);
            this.panelTop.TabIndex = 0;
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
            this.btnEnter.Location = new System.Drawing.Point(747, 89);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEnter.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnEnter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEnter.selected = false;
            this.btnEnter.Size = new System.Drawing.Size(65, 65);
            this.btnEnter.TabIndex = 16;
            this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnter.Textcolor = System.Drawing.Color.White;
            this.btnEnter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // noExistAnimal
            // 
            this.noExistAnimal.AutoSize = true;
            this.noExistAnimal.BackColor = System.Drawing.Color.Transparent;
            this.noExistAnimal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noExistAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(79)))), ((int)(((byte)(58)))));
            this.noExistAnimal.Location = new System.Drawing.Point(67, 164);
            this.noExistAnimal.MinimumSize = new System.Drawing.Size(674, 26);
            this.noExistAnimal.Name = "noExistAnimal";
            this.noExistAnimal.Size = new System.Drawing.Size(674, 26);
            this.noExistAnimal.TabIndex = 15;
            this.noExistAnimal.Text = "Sorry. There is no such animal in our store.";
            this.noExistAnimal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textEnterAnimal
            // 
            this.textEnterAnimal.AutoSize = true;
            this.textEnterAnimal.BackColor = System.Drawing.Color.Transparent;
            this.textEnterAnimal.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEnterAnimal.ForeColor = System.Drawing.Color.Black;
            this.textEnterAnimal.Location = new System.Drawing.Point(62, 56);
            this.textEnterAnimal.MinimumSize = new System.Drawing.Size(674, 38);
            this.textEnterAnimal.Name = "textEnterAnimal";
            this.textEnterAnimal.Size = new System.Drawing.Size(674, 38);
            this.textEnterAnimal.TabIndex = 14;
            this.textEnterAnimal.Text = "Enter the species of the animal";
            this.textEnterAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputSpecies
            // 
            this.inputSpecies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputSpecies.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputSpecies.Location = new System.Drawing.Point(67, 116);
            this.inputSpecies.Name = "inputSpecies";
            this.inputSpecies.Size = new System.Drawing.Size(674, 38);
            this.inputSpecies.TabIndex = 13;
            this.inputSpecies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputSpecies.TextChanged += new System.EventHandler(this.inputSpecies_TextChanged);
            this.inputSpecies.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputSpecies_KeyDown);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.Controls.Add(this.succesDelete);
            this.panelContent.Controls.Add(this.btnBoth);
            this.panelContent.Controls.Add(this.btnFemale);
            this.panelContent.Controls.Add(this.btnMale);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContent.Location = new System.Drawing.Point(0, 253);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(990, 373);
            this.panelContent.TabIndex = 1;
            // 
            // btnMale
            // 
            this.btnMale.Activecolor = System.Drawing.Color.Transparent;
            this.btnMale.BackColor = System.Drawing.Color.Transparent;
            this.btnMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMale.BorderRadius = 0;
            this.btnMale.ButtonText = "Delete Male";
            this.btnMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMale.DisabledColor = System.Drawing.Color.Gray;
            this.btnMale.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMale.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMale.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMale.Iconimage")));
            this.btnMale.Iconimage_right = null;
            this.btnMale.Iconimage_right_Selected = null;
            this.btnMale.Iconimage_Selected = null;
            this.btnMale.IconMarginLeft = 0;
            this.btnMale.IconMarginRight = 0;
            this.btnMale.IconRightVisible = true;
            this.btnMale.IconRightZoom = 0D;
            this.btnMale.IconVisible = true;
            this.btnMale.IconZoom = 90D;
            this.btnMale.IsTab = false;
            this.btnMale.Location = new System.Drawing.Point(55, 81);
            this.btnMale.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMale.Name = "btnMale";
            this.btnMale.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMale.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnMale.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btnMale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMale.selected = false;
            this.btnMale.Size = new System.Drawing.Size(222, 65);
            this.btnMale.TabIndex = 23;
            this.btnMale.Text = "Delete Male";
            this.btnMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMale.Textcolor = System.Drawing.Color.Black;
            this.btnMale.TextFont = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMale.Click += new System.EventHandler(this.btnMale_Click);
            // 
            // succesDelete
            // 
            this.succesDelete.AutoSize = true;
            this.succesDelete.BackColor = System.Drawing.Color.Transparent;
            this.succesDelete.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.succesDelete.ForeColor = System.Drawing.Color.Lime;
            this.succesDelete.Location = new System.Drawing.Point(300, 217);
            this.succesDelete.Name = "succesDelete";
            this.succesDelete.Size = new System.Drawing.Size(233, 26);
            this.succesDelete.TabIndex = 24;
            this.succesDelete.Text = "You deleted successfully!";
            this.succesDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnFemale
            // 
            this.btnFemale.Activecolor = System.Drawing.Color.Transparent;
            this.btnFemale.BackColor = System.Drawing.Color.Transparent;
            this.btnFemale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFemale.BorderRadius = 0;
            this.btnFemale.ButtonText = "Delete Female";
            this.btnFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFemale.DisabledColor = System.Drawing.Color.Gray;
            this.btnFemale.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFemale.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFemale.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFemale.Iconimage")));
            this.btnFemale.Iconimage_right = null;
            this.btnFemale.Iconimage_right_Selected = null;
            this.btnFemale.Iconimage_Selected = null;
            this.btnFemale.IconMarginLeft = 0;
            this.btnFemale.IconMarginRight = 0;
            this.btnFemale.IconRightVisible = true;
            this.btnFemale.IconRightZoom = 0D;
            this.btnFemale.IconVisible = true;
            this.btnFemale.IconZoom = 90D;
            this.btnFemale.IsTab = false;
            this.btnFemale.Location = new System.Drawing.Point(305, 81);
            this.btnFemale.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Normalcolor = System.Drawing.Color.Transparent;
            this.btnFemale.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnFemale.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btnFemale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFemale.selected = false;
            this.btnFemale.Size = new System.Drawing.Size(222, 65);
            this.btnFemale.TabIndex = 23;
            this.btnFemale.Text = "Delete Female";
            this.btnFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFemale.Textcolor = System.Drawing.Color.Black;
            this.btnFemale.TextFont = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFemale.Click += new System.EventHandler(this.btnFemale_Click);
            // 
            // btnBoth
            // 
            this.btnBoth.Activecolor = System.Drawing.Color.Transparent;
            this.btnBoth.BackColor = System.Drawing.Color.Transparent;
            this.btnBoth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBoth.BorderRadius = 0;
            this.btnBoth.ButtonText = "Delete Both";
            this.btnBoth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoth.DisabledColor = System.Drawing.Color.Gray;
            this.btnBoth.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBoth.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBoth.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBoth.Iconimage")));
            this.btnBoth.Iconimage_right = null;
            this.btnBoth.Iconimage_right_Selected = null;
            this.btnBoth.Iconimage_Selected = null;
            this.btnBoth.IconMarginLeft = 0;
            this.btnBoth.IconMarginRight = 0;
            this.btnBoth.IconRightVisible = true;
            this.btnBoth.IconRightZoom = 0D;
            this.btnBoth.IconVisible = true;
            this.btnBoth.IconZoom = 90D;
            this.btnBoth.IsTab = false;
            this.btnBoth.Location = new System.Drawing.Point(562, 81);
            this.btnBoth.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBoth.Name = "btnBoth";
            this.btnBoth.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBoth.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnBoth.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btnBoth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBoth.selected = false;
            this.btnBoth.Size = new System.Drawing.Size(222, 65);
            this.btnBoth.TabIndex = 23;
            this.btnBoth.Text = "Delete Both";
            this.btnBoth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBoth.Textcolor = System.Drawing.Color.Black;
            this.btnBoth.TextFont = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBoth.Click += new System.EventHandler(this.btnBoth_Click);
            // 
            // controlDelCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.Name = "controlDelCategory";
            this.Size = new System.Drawing.Size(990, 626);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private Bunifu.Framework.UI.BunifuFlatButton btnEnter;
        private System.Windows.Forms.Label noExistAnimal;
        private System.Windows.Forms.Label textEnterAnimal;
        private System.Windows.Forms.TextBox inputSpecies;
        private System.Windows.Forms.Panel panelContent;
        private Bunifu.Framework.UI.BunifuFlatButton btnMale;
        private System.Windows.Forms.Label succesDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnBoth;
        private Bunifu.Framework.UI.BunifuFlatButton btnFemale;
    }
}
