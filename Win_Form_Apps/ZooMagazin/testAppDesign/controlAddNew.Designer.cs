﻿namespace testAppDesign {
    partial class controlAddNew {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlAddNew));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.price = new System.Windows.Forms.TextBox();
            this.wasAdded = new System.Windows.Forms.Label();
            this.quantityFemale = new System.Windows.Forms.TextBox();
            this.quantityMale = new System.Windows.Forms.TextBox();
            this.bunifuSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.textPrice = new System.Windows.Forms.Label();
            this.textFemale = new System.Windows.Forms.Label();
            this.nameAnimal = new System.Windows.Forms.Label();
            this.textMale = new System.Windows.Forms.Label();
            this.textAnimal = new System.Windows.Forms.Label();
            this.btnEnter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.existAnimal = new System.Windows.Forms.Label();
            this.textEnterAnimal = new System.Windows.Forms.Label();
            this.inputAddNew = new System.Windows.Forms.TextBox();
            this.bunifuRoundInput = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panelAdd);
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Controls.Add(this.existAnimal);
            this.panel1.Controls.Add(this.textEnterAnimal);
            this.panel1.Controls.Add(this.inputAddNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 626);
            this.panel1.TabIndex = 0;
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.Transparent;
            this.panelAdd.Controls.Add(this.btnAdd);
            this.panelAdd.Controls.Add(this.price);
            this.panelAdd.Controls.Add(this.wasAdded);
            this.panelAdd.Controls.Add(this.quantityFemale);
            this.panelAdd.Controls.Add(this.quantityMale);
            this.panelAdd.Controls.Add(this.bunifuSeparator);
            this.panelAdd.Controls.Add(this.textPrice);
            this.panelAdd.Controls.Add(this.textFemale);
            this.panelAdd.Controls.Add(this.nameAnimal);
            this.panelAdd.Controls.Add(this.textMale);
            this.panelAdd.Controls.Add(this.textAnimal);
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAdd.Location = new System.Drawing.Point(0, 315);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(990, 311);
            this.panelAdd.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.Transparent;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdd.Iconimage")));
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 70D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(354, 159);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAdd.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(154, 65);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.Black;
            this.btnAdd.TextFont = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(635, 107);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(110, 30);
            this.price.TabIndex = 11;
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wasAdded
            // 
            this.wasAdded.AutoSize = true;
            this.wasAdded.BackColor = System.Drawing.Color.Transparent;
            this.wasAdded.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wasAdded.ForeColor = System.Drawing.Color.Lime;
            this.wasAdded.Location = new System.Drawing.Point(349, 240);
            this.wasAdded.MinimumSize = new System.Drawing.Size(154, 26);
            this.wasAdded.Name = "wasAdded";
            this.wasAdded.Size = new System.Drawing.Size(154, 26);
            this.wasAdded.TabIndex = 7;
            this.wasAdded.Text = "It was added!";
            this.wasAdded.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // quantityFemale
            // 
            this.quantityFemale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityFemale.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityFemale.Location = new System.Drawing.Point(452, 106);
            this.quantityFemale.Name = "quantityFemale";
            this.quantityFemale.Size = new System.Drawing.Size(100, 30);
            this.quantityFemale.TabIndex = 11;
            this.quantityFemale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantityMale
            // 
            this.quantityMale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityMale.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityMale.Location = new System.Drawing.Point(271, 107);
            this.quantityMale.Name = "quantityMale";
            this.quantityMale.Size = new System.Drawing.Size(100, 30);
            this.quantityMale.TabIndex = 11;
            this.quantityMale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuSeparator
            // 
            this.bunifuSeparator.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator.LineThickness = 3;
            this.bunifuSeparator.Location = new System.Drawing.Point(17, 67);
            this.bunifuSeparator.Name = "bunifuSeparator";
            this.bunifuSeparator.Size = new System.Drawing.Size(774, 12);
            this.bunifuSeparator.TabIndex = 10;
            this.bunifuSeparator.Transparency = 255;
            this.bunifuSeparator.Vertical = false;
            // 
            // textPrice
            // 
            this.textPrice.AutoSize = true;
            this.textPrice.BackColor = System.Drawing.Color.Transparent;
            this.textPrice.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPrice.ForeColor = System.Drawing.Color.Black;
            this.textPrice.Location = new System.Drawing.Point(639, 24);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(85, 40);
            this.textPrice.TabIndex = 0;
            this.textPrice.Text = "Price";
            // 
            // textFemale
            // 
            this.textFemale.AutoSize = true;
            this.textFemale.BackColor = System.Drawing.Color.Transparent;
            this.textFemale.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFemale.ForeColor = System.Drawing.Color.Black;
            this.textFemale.Location = new System.Drawing.Point(445, 24);
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
            this.nameAnimal.Location = new System.Drawing.Point(38, 96);
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
            this.textMale.Location = new System.Drawing.Point(281, 24);
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
            this.textAnimal.Location = new System.Drawing.Point(77, 24);
            this.textAnimal.Name = "textAnimal";
            this.textAnimal.Size = new System.Drawing.Size(107, 40);
            this.textAnimal.TabIndex = 0;
            this.textAnimal.Text = "Animal";
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
            this.btnEnter.Location = new System.Drawing.Point(766, 116);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEnter.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnEnter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEnter.selected = false;
            this.btnEnter.Size = new System.Drawing.Size(65, 65);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnter.Textcolor = System.Drawing.Color.White;
            this.btnEnter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // existAnimal
            // 
            this.existAnimal.AutoSize = true;
            this.existAnimal.BackColor = System.Drawing.Color.Transparent;
            this.existAnimal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.existAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(79)))), ((int)(((byte)(58)))));
            this.existAnimal.Location = new System.Drawing.Point(86, 191);
            this.existAnimal.MinimumSize = new System.Drawing.Size(674, 26);
            this.existAnimal.Name = "existAnimal";
            this.existAnimal.Size = new System.Drawing.Size(674, 26);
            this.existAnimal.TabIndex = 7;
            this.existAnimal.Text = "The animal already exists";
            this.existAnimal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textEnterAnimal
            // 
            this.textEnterAnimal.AutoSize = true;
            this.textEnterAnimal.BackColor = System.Drawing.Color.Transparent;
            this.textEnterAnimal.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEnterAnimal.ForeColor = System.Drawing.Color.Black;
            this.textEnterAnimal.Location = new System.Drawing.Point(81, 83);
            this.textEnterAnimal.MinimumSize = new System.Drawing.Size(674, 38);
            this.textEnterAnimal.Name = "textEnterAnimal";
            this.textEnterAnimal.Size = new System.Drawing.Size(674, 38);
            this.textEnterAnimal.TabIndex = 5;
            this.textEnterAnimal.Text = "Enter the new species of the animal";
            this.textEnterAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputAddNew
            // 
            this.inputAddNew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAddNew.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputAddNew.Location = new System.Drawing.Point(86, 143);
            this.inputAddNew.Name = "inputAddNew";
            this.inputAddNew.Size = new System.Drawing.Size(674, 38);
            this.inputAddNew.TabIndex = 4;
            this.inputAddNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputAddNew.TextChanged += new System.EventHandler(this.inputAddNew_TextChanged);
            this.inputAddNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputAddNew_KeyDown);
            // 
            // bunifuRoundInput
            // 
            this.bunifuRoundInput.ElipseRadius = 5;
            this.bunifuRoundInput.TargetControl = this.inputAddNew;
            // 
            // controlAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "controlAddNew";
            this.Size = new System.Drawing.Size(990, 626);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textEnterAnimal;
        private System.Windows.Forms.TextBox inputAddNew;
        private System.Windows.Forms.Label existAnimal;
        private Bunifu.Framework.UI.BunifuFlatButton btnEnter;
        private Bunifu.Framework.UI.BunifuElipse bunifuRoundInput;
        private System.Windows.Forms.Panel panelAdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox quantityFemale;
        private System.Windows.Forms.TextBox quantityMale;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator;
        private System.Windows.Forms.Label textPrice;
        private System.Windows.Forms.Label textFemale;
        private System.Windows.Forms.Label nameAnimal;
        private System.Windows.Forms.Label textMale;
        private System.Windows.Forms.Label textAnimal;
        private System.Windows.Forms.Label wasAdded;
    }
}
