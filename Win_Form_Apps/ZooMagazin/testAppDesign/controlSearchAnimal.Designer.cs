﻿namespace testAppDesign
{
    partial class controlSearchAnimal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlSearchAnimal));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.noExistAnimal = new System.Windows.Forms.Label();
            this.textEnterAnimal = new System.Windows.Forms.Label();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.priceAnimal = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.Label();
            this.quantityFemale = new System.Windows.Forms.Label();
            this.quantityMale = new System.Windows.Forms.Label();
            this.textFemale = new System.Windows.Forms.Label();
            this.nameAnimal = new System.Windows.Forms.Label();
            this.textMale = new System.Windows.Forms.Label();
            this.textAnimal = new System.Windows.Forms.Label();
            this.bunifuRoundInput = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelTop.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.noExistAnimal);
            this.panelTop.Controls.Add(this.textEnterAnimal);
            this.panelTop.Controls.Add(this.inputSearch);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(990, 244);
            this.panelTop.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.Transparent;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnSearch.IconZoom = 80D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(826, 152);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSearch.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(65, 65);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // noExistAnimal
            // 
            this.noExistAnimal.AutoSize = true;
            this.noExistAnimal.BackColor = System.Drawing.Color.Transparent;
            this.noExistAnimal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noExistAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(79)))), ((int)(((byte)(58)))));
            this.noExistAnimal.Location = new System.Drawing.Point(146, 218);
            this.noExistAnimal.MinimumSize = new System.Drawing.Size(674, 26);
            this.noExistAnimal.Name = "noExistAnimal";
            this.noExistAnimal.Size = new System.Drawing.Size(674, 26);
            this.noExistAnimal.TabIndex = 1;
            this.noExistAnimal.Text = "Sorry. There is no such animal in our store.";
            this.noExistAnimal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textEnterAnimal
            // 
            this.textEnterAnimal.AutoSize = true;
            this.textEnterAnimal.BackColor = System.Drawing.Color.Transparent;
            this.textEnterAnimal.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEnterAnimal.ForeColor = System.Drawing.Color.Black;
            this.textEnterAnimal.Location = new System.Drawing.Point(146, 92);
            this.textEnterAnimal.MinimumSize = new System.Drawing.Size(674, 38);
            this.textEnterAnimal.Name = "textEnterAnimal";
            this.textEnterAnimal.Size = new System.Drawing.Size(674, 38);
            this.textEnterAnimal.TabIndex = 1;
            this.textEnterAnimal.Text = "Enter the species of the animal";
            this.textEnterAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputSearch
            // 
            this.inputSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputSearch.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputSearch.Location = new System.Drawing.Point(146, 168);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(674, 38);
            this.inputSearch.TabIndex = 0;
            this.inputSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputSearch.TextChanged += new System.EventHandler(this.inputNameAnimal_TextChanged);
            this.inputSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputSearch_KeyDown);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.Controls.Add(this.bunifuSeparator);
            this.panelContent.Controls.Add(this.priceAnimal);
            this.panelContent.Controls.Add(this.textPrice);
            this.panelContent.Controls.Add(this.quantityFemale);
            this.panelContent.Controls.Add(this.quantityMale);
            this.panelContent.Controls.Add(this.textFemale);
            this.panelContent.Controls.Add(this.nameAnimal);
            this.panelContent.Controls.Add(this.textMale);
            this.panelContent.Controls.Add(this.textAnimal);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 244);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(990, 382);
            this.panelContent.TabIndex = 4;
            // 
            // priceAnimal
            // 
            this.priceAnimal.AutoSize = true;
            this.priceAnimal.BackColor = System.Drawing.Color.Transparent;
            this.priceAnimal.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceAnimal.ForeColor = System.Drawing.Color.Black;
            this.priceAnimal.Location = new System.Drawing.Point(735, 102);
            this.priceAnimal.MinimumSize = new System.Drawing.Size(85, 40);
            this.priceAnimal.Name = "priceAnimal";
            this.priceAnimal.Size = new System.Drawing.Size(85, 40);
            this.priceAnimal.TabIndex = 0;
            this.priceAnimal.Text = "Price";
            this.priceAnimal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textPrice
            // 
            this.textPrice.AutoSize = true;
            this.textPrice.BackColor = System.Drawing.Color.Transparent;
            this.textPrice.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPrice.ForeColor = System.Drawing.Color.Black;
            this.textPrice.Location = new System.Drawing.Point(735, 30);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(85, 40);
            this.textPrice.TabIndex = 0;
            this.textPrice.Text = "Price";
            // 
            // quantityFemale
            // 
            this.quantityFemale.AutoSize = true;
            this.quantityFemale.BackColor = System.Drawing.Color.Transparent;
            this.quantityFemale.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityFemale.ForeColor = System.Drawing.Color.Black;
            this.quantityFemale.Location = new System.Drawing.Point(504, 102);
            this.quantityFemale.MinimumSize = new System.Drawing.Size(113, 40);
            this.quantityFemale.Name = "quantityFemale";
            this.quantityFemale.Size = new System.Drawing.Size(113, 40);
            this.quantityFemale.TabIndex = 0;
            this.quantityFemale.Text = "Female";
            this.quantityFemale.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quantityMale
            // 
            this.quantityMale.AutoSize = true;
            this.quantityMale.BackColor = System.Drawing.Color.Transparent;
            this.quantityMale.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityMale.ForeColor = System.Drawing.Color.Black;
            this.quantityMale.Location = new System.Drawing.Point(350, 102);
            this.quantityMale.MinimumSize = new System.Drawing.Size(81, 40);
            this.quantityMale.Name = "quantityMale";
            this.quantityMale.Size = new System.Drawing.Size(81, 40);
            this.quantityMale.TabIndex = 0;
            this.quantityMale.Text = "Male";
            this.quantityMale.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textFemale
            // 
            this.textFemale.AutoSize = true;
            this.textFemale.BackColor = System.Drawing.Color.Transparent;
            this.textFemale.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFemale.ForeColor = System.Drawing.Color.Black;
            this.textFemale.Location = new System.Drawing.Point(504, 30);
            this.textFemale.Name = "textFemale";
            this.textFemale.Size = new System.Drawing.Size(113, 40);
            this.textFemale.TabIndex = 0;
            this.textFemale.Text = "Female";
            // 
            // nameAnimal
            // 
            this.nameAnimal.AutoSize = true;
            this.nameAnimal.BackColor = System.Drawing.Color.Transparent;
            this.nameAnimal.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAnimal.ForeColor = System.Drawing.Color.Black;
            this.nameAnimal.Location = new System.Drawing.Point(107, 102);
            this.nameAnimal.MinimumSize = new System.Drawing.Size(185, 40);
            this.nameAnimal.Name = "nameAnimal";
            this.nameAnimal.Size = new System.Drawing.Size(185, 40);
            this.nameAnimal.TabIndex = 0;
            this.nameAnimal.Text = "name Animal";
            this.nameAnimal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textMale
            // 
            this.textMale.AutoSize = true;
            this.textMale.BackColor = System.Drawing.Color.Transparent;
            this.textMale.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMale.ForeColor = System.Drawing.Color.Black;
            this.textMale.Location = new System.Drawing.Point(350, 30);
            this.textMale.Name = "textMale";
            this.textMale.Size = new System.Drawing.Size(81, 40);
            this.textMale.TabIndex = 0;
            this.textMale.Text = "Male";
            // 
            // textAnimal
            // 
            this.textAnimal.AutoSize = true;
            this.textAnimal.BackColor = System.Drawing.Color.Transparent;
            this.textAnimal.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAnimal.ForeColor = System.Drawing.Color.Black;
            this.textAnimal.Location = new System.Drawing.Point(146, 30);
            this.textAnimal.Name = "textAnimal";
            this.textAnimal.Size = new System.Drawing.Size(107, 40);
            this.textAnimal.TabIndex = 0;
            this.textAnimal.Text = "Animal";
            // 
            // bunifuRoundInput
            // 
            this.bunifuRoundInput.ElipseRadius = 15;
            this.bunifuRoundInput.TargetControl = this.inputSearch;
            // 
            // bunifuSeparator
            // 
            this.bunifuSeparator.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator.LineThickness = 3;
            this.bunifuSeparator.Location = new System.Drawing.Point(86, 73);
            this.bunifuSeparator.Name = "bunifuSeparator";
            this.bunifuSeparator.Size = new System.Drawing.Size(831, 12);
            this.bunifuSeparator.TabIndex = 10;
            this.bunifuSeparator.Transparency = 255;
            this.bunifuSeparator.Vertical = false;
            // 
            // controlSearchAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "controlSearchAnimal";
            this.Size = new System.Drawing.Size(990, 626);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label textEnterAnimal;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label textPrice;
        private System.Windows.Forms.Label textFemale;
        private System.Windows.Forms.Label textMale;
        private System.Windows.Forms.Label textAnimal;
        private System.Windows.Forms.Label priceAnimal;
        private System.Windows.Forms.Label quantityFemale;
        private System.Windows.Forms.Label quantityMale;
        private System.Windows.Forms.Label nameAnimal;
        private System.Windows.Forms.Label noExistAnimal;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuElipse bunifuRoundInput;
        private System.Windows.Forms.TextBox inputSearch;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator;
    }
}
