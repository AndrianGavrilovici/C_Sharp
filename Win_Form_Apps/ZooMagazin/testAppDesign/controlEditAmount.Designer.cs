﻿namespace testAppDesign {
    partial class controlEditAmount {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlEditAmount));
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelAdding = new System.Windows.Forms.Panel();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.textSuccesDeleted = new System.Windows.Forms.Label();
            this.numberDeleteFemale = new System.Windows.Forms.TextBox();
            this.numberDeleteMale = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textMale2 = new System.Windows.Forms.Label();
            this.textMale1 = new System.Windows.Forms.Label();
            this.textWantToDelete = new System.Windows.Forms.Label();
            this.btnDeleteAmount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textSuccesAdded = new System.Windows.Forms.Label();
            this.numberAddFemale = new System.Windows.Forms.TextBox();
            this.numberAddMale = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textFemale = new System.Windows.Forms.Label();
            this.textMale = new System.Windows.Forms.Label();
            this.textWantToAdd = new System.Windows.Forms.Label();
            this.btnAddAmount = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelAddingOrRemove = new System.Windows.Forms.Panel();
            this.noExistAnimal = new System.Windows.Forms.Label();
            this.panelBtnRemove = new System.Windows.Forms.Panel();
            this.panelBtnAdding = new System.Windows.Forms.Panel();
            this.btnAdding = new Bunifu.Framework.UI.BunifuFlatButton();
            this.inputSpecies = new System.Windows.Forms.TextBox();
            this.btnRemove = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuRoundInput = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelContent.SuspendLayout();
            this.panelAdding.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.panelAddingOrRemove.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContent.BackgroundImage")));
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContent.Controls.Add(this.panelAdding);
            this.panelContent.Controls.Add(this.panelAddingOrRemove);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(990, 626);
            this.panelContent.TabIndex = 0;
            // 
            // panelAdding
            // 
            this.panelAdding.BackColor = System.Drawing.Color.Transparent;
            this.panelAdding.Controls.Add(this.panelDelete);
            this.panelAdding.Controls.Add(this.textSuccesAdded);
            this.panelAdding.Controls.Add(this.numberAddFemale);
            this.panelAdding.Controls.Add(this.numberAddMale);
            this.panelAdding.Controls.Add(this.panel1);
            this.panelAdding.Controls.Add(this.textFemale);
            this.panelAdding.Controls.Add(this.textMale);
            this.panelAdding.Controls.Add(this.textWantToAdd);
            this.panelAdding.Controls.Add(this.btnAddAmount);
            this.panelAdding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAdding.Location = new System.Drawing.Point(0, 287);
            this.panelAdding.Name = "panelAdding";
            this.panelAdding.Size = new System.Drawing.Size(990, 339);
            this.panelAdding.TabIndex = 1;
            // 
            // panelDelete
            // 
            this.panelDelete.BackColor = System.Drawing.Color.Transparent;
            this.panelDelete.Controls.Add(this.textSuccesDeleted);
            this.panelDelete.Controls.Add(this.numberDeleteFemale);
            this.panelDelete.Controls.Add(this.numberDeleteMale);
            this.panelDelete.Controls.Add(this.panel3);
            this.panelDelete.Controls.Add(this.textMale2);
            this.panelDelete.Controls.Add(this.textMale1);
            this.panelDelete.Controls.Add(this.textWantToDelete);
            this.panelDelete.Controls.Add(this.btnDeleteAmount);
            this.panelDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDelete.Location = new System.Drawing.Point(0, 3);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(990, 336);
            this.panelDelete.TabIndex = 15;
            // 
            // textSuccesDeleted
            // 
            this.textSuccesDeleted.AutoSize = true;
            this.textSuccesDeleted.BackColor = System.Drawing.Color.Transparent;
            this.textSuccesDeleted.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSuccesDeleted.ForeColor = System.Drawing.Color.Lime;
            this.textSuccesDeleted.Location = new System.Drawing.Point(102, 249);
            this.textSuccesDeleted.MinimumSize = new System.Drawing.Size(674, 26);
            this.textSuccesDeleted.Name = "textSuccesDeleted";
            this.textSuccesDeleted.Size = new System.Drawing.Size(674, 26);
            this.textSuccesDeleted.TabIndex = 13;
            this.textSuccesDeleted.Text = "You deleted successfully!";
            this.textSuccesDeleted.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // numberDeleteFemale
            // 
            this.numberDeleteFemale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberDeleteFemale.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberDeleteFemale.Location = new System.Drawing.Point(652, 101);
            this.numberDeleteFemale.Name = "numberDeleteFemale";
            this.numberDeleteFemale.Size = new System.Drawing.Size(119, 34);
            this.numberDeleteFemale.TabIndex = 14;
            this.numberDeleteFemale.TextChanged += new System.EventHandler(this.numberDeleteFemale_TextChanged);
            this.numberDeleteFemale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberDeleteFemale_KeyDown);
            // 
            // numberDeleteMale
            // 
            this.numberDeleteMale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberDeleteMale.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberDeleteMale.Location = new System.Drawing.Point(509, 101);
            this.numberDeleteMale.Name = "numberDeleteMale";
            this.numberDeleteMale.Size = new System.Drawing.Size(119, 34);
            this.numberDeleteMale.TabIndex = 14;
            this.numberDeleteMale.TextChanged += new System.EventHandler(this.numberDeleteMale_TextChanged);
            this.numberDeleteMale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberDeleteMale_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(574, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 52);
            this.panel3.TabIndex = 10;
            // 
            // textMale2
            // 
            this.textMale2.AutoSize = true;
            this.textMale2.BackColor = System.Drawing.Color.Transparent;
            this.textMale2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMale2.ForeColor = System.Drawing.Color.Black;
            this.textMale2.Location = new System.Drawing.Point(654, 51);
            this.textMale2.Name = "textMale2";
            this.textMale2.Size = new System.Drawing.Size(93, 33);
            this.textMale2.TabIndex = 13;
            this.textMale2.Text = "Female";
            this.textMale2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textMale1
            // 
            this.textMale1.AutoSize = true;
            this.textMale1.BackColor = System.Drawing.Color.Transparent;
            this.textMale1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMale1.ForeColor = System.Drawing.Color.Black;
            this.textMale1.Location = new System.Drawing.Point(530, 51);
            this.textMale1.Name = "textMale1";
            this.textMale1.Size = new System.Drawing.Size(68, 33);
            this.textMale1.TabIndex = 13;
            this.textMale1.Text = "Male";
            this.textMale1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textWantToDelete
            // 
            this.textWantToDelete.AutoSize = true;
            this.textWantToDelete.BackColor = System.Drawing.Color.Transparent;
            this.textWantToDelete.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textWantToDelete.ForeColor = System.Drawing.Color.Black;
            this.textWantToDelete.Location = new System.Drawing.Point(39, 71);
            this.textWantToDelete.Name = "textWantToDelete";
            this.textWantToDelete.Size = new System.Drawing.Size(440, 42);
            this.textWantToDelete.TabIndex = 13;
            this.textWantToDelete.Text = "How much you want to delete?";
            this.textWantToDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnDeleteAmount
            // 
            this.btnDeleteAmount.Activecolor = System.Drawing.Color.Transparent;
            this.btnDeleteAmount.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteAmount.BorderRadius = 0;
            this.btnDeleteAmount.ButtonText = "Remove";
            this.btnDeleteAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAmount.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteAmount.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteAmount.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAmount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteAmount.Iconimage = null;
            this.btnDeleteAmount.Iconimage_right = null;
            this.btnDeleteAmount.Iconimage_right_Selected = null;
            this.btnDeleteAmount.Iconimage_Selected = null;
            this.btnDeleteAmount.IconMarginLeft = 0;
            this.btnDeleteAmount.IconMarginRight = 0;
            this.btnDeleteAmount.IconRightVisible = true;
            this.btnDeleteAmount.IconRightZoom = 0D;
            this.btnDeleteAmount.IconVisible = true;
            this.btnDeleteAmount.IconZoom = 80D;
            this.btnDeleteAmount.IsTab = false;
            this.btnDeleteAmount.Location = new System.Drawing.Point(574, 174);
            this.btnDeleteAmount.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnDeleteAmount.Name = "btnDeleteAmount";
            this.btnDeleteAmount.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDeleteAmount.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDeleteAmount.OnHoverTextColor = System.Drawing.Color.DarkOrange;
            this.btnDeleteAmount.selected = false;
            this.btnDeleteAmount.Size = new System.Drawing.Size(124, 53);
            this.btnDeleteAmount.TabIndex = 9;
            this.btnDeleteAmount.Tag = "";
            this.btnDeleteAmount.Text = "Remove";
            this.btnDeleteAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteAmount.Textcolor = System.Drawing.Color.Black;
            this.btnDeleteAmount.TextFont = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.btnDeleteAmount.Click += new System.EventHandler(this.btnDeleteAmount_Click);
            // 
            // textSuccesAdded
            // 
            this.textSuccesAdded.AutoSize = true;
            this.textSuccesAdded.BackColor = System.Drawing.Color.Transparent;
            this.textSuccesAdded.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSuccesAdded.ForeColor = System.Drawing.Color.Lime;
            this.textSuccesAdded.Location = new System.Drawing.Point(102, 249);
            this.textSuccesAdded.MinimumSize = new System.Drawing.Size(674, 26);
            this.textSuccesAdded.Name = "textSuccesAdded";
            this.textSuccesAdded.Size = new System.Drawing.Size(674, 26);
            this.textSuccesAdded.TabIndex = 13;
            this.textSuccesAdded.Text = "You have successfully added!";
            this.textSuccesAdded.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // numberAddFemale
            // 
            this.numberAddFemale.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberAddFemale.Location = new System.Drawing.Point(652, 101);
            this.numberAddFemale.Name = "numberAddFemale";
            this.numberAddFemale.Size = new System.Drawing.Size(119, 34);
            this.numberAddFemale.TabIndex = 14;
            this.numberAddFemale.TextChanged += new System.EventHandler(this.numberAddFemale_TextChanged);
            this.numberAddFemale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberAddFemale_KeyDown);
            // 
            // numberAddMale
            // 
            this.numberAddMale.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberAddMale.Location = new System.Drawing.Point(509, 101);
            this.numberAddMale.Name = "numberAddMale";
            this.numberAddMale.Size = new System.Drawing.Size(119, 34);
            this.numberAddMale.TabIndex = 14;
            this.numberAddMale.TextChanged += new System.EventHandler(this.numberAddMale_TextChanged);
            this.numberAddMale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberAddMale_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(574, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 52);
            this.panel1.TabIndex = 10;
            // 
            // textFemale
            // 
            this.textFemale.AutoSize = true;
            this.textFemale.BackColor = System.Drawing.Color.Transparent;
            this.textFemale.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFemale.ForeColor = System.Drawing.Color.Black;
            this.textFemale.Location = new System.Drawing.Point(654, 51);
            this.textFemale.Name = "textFemale";
            this.textFemale.Size = new System.Drawing.Size(93, 33);
            this.textFemale.TabIndex = 13;
            this.textFemale.Text = "Female";
            this.textFemale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textMale
            // 
            this.textMale.AutoSize = true;
            this.textMale.BackColor = System.Drawing.Color.Transparent;
            this.textMale.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMale.ForeColor = System.Drawing.Color.Black;
            this.textMale.Location = new System.Drawing.Point(530, 51);
            this.textMale.Name = "textMale";
            this.textMale.Size = new System.Drawing.Size(68, 33);
            this.textMale.TabIndex = 13;
            this.textMale.Text = "Male";
            this.textMale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textWantToAdd
            // 
            this.textWantToAdd.AutoSize = true;
            this.textWantToAdd.BackColor = System.Drawing.Color.Transparent;
            this.textWantToAdd.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textWantToAdd.ForeColor = System.Drawing.Color.Black;
            this.textWantToAdd.Location = new System.Drawing.Point(39, 71);
            this.textWantToAdd.Name = "textWantToAdd";
            this.textWantToAdd.Size = new System.Drawing.Size(402, 42);
            this.textWantToAdd.TabIndex = 13;
            this.textWantToAdd.Text = "How much you want to add?";
            this.textWantToAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnAddAmount
            // 
            this.btnAddAmount.Activecolor = System.Drawing.Color.Transparent;
            this.btnAddAmount.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAmount.BorderRadius = 0;
            this.btnAddAmount.ButtonText = "Add";
            this.btnAddAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAmount.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddAmount.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddAmount.ForeColor = System.Drawing.Color.Black;
            this.btnAddAmount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddAmount.Iconimage = null;
            this.btnAddAmount.Iconimage_right = null;
            this.btnAddAmount.Iconimage_right_Selected = null;
            this.btnAddAmount.Iconimage_Selected = null;
            this.btnAddAmount.IconMarginLeft = 0;
            this.btnAddAmount.IconMarginRight = 0;
            this.btnAddAmount.IconRightVisible = true;
            this.btnAddAmount.IconRightZoom = 0D;
            this.btnAddAmount.IconVisible = true;
            this.btnAddAmount.IconZoom = 80D;
            this.btnAddAmount.IsTab = false;
            this.btnAddAmount.Location = new System.Drawing.Point(574, 174);
            this.btnAddAmount.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnAddAmount.Name = "btnAddAmount";
            this.btnAddAmount.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddAmount.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAddAmount.OnHoverTextColor = System.Drawing.Color.DarkOrange;
            this.btnAddAmount.selected = false;
            this.btnAddAmount.Size = new System.Drawing.Size(124, 53);
            this.btnAddAmount.TabIndex = 9;
            this.btnAddAmount.Tag = "";
            this.btnAddAmount.Text = "Add";
            this.btnAddAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddAmount.Textcolor = System.Drawing.Color.Black;
            this.btnAddAmount.TextFont = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.btnAddAmount.Click += new System.EventHandler(this.btnAddAmount_Click);
            // 
            // panelAddingOrRemove
            // 
            this.panelAddingOrRemove.BackColor = System.Drawing.Color.Transparent;
            this.panelAddingOrRemove.Controls.Add(this.noExistAnimal);
            this.panelAddingOrRemove.Controls.Add(this.panelBtnRemove);
            this.panelAddingOrRemove.Controls.Add(this.panelBtnAdding);
            this.panelAddingOrRemove.Controls.Add(this.btnAdding);
            this.panelAddingOrRemove.Controls.Add(this.inputSpecies);
            this.panelAddingOrRemove.Controls.Add(this.btnRemove);
            this.panelAddingOrRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddingOrRemove.Location = new System.Drawing.Point(0, 0);
            this.panelAddingOrRemove.Name = "panelAddingOrRemove";
            this.panelAddingOrRemove.Size = new System.Drawing.Size(990, 241);
            this.panelAddingOrRemove.TabIndex = 0;
            // 
            // noExistAnimal
            // 
            this.noExistAnimal.AutoSize = true;
            this.noExistAnimal.BackColor = System.Drawing.Color.Transparent;
            this.noExistAnimal.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noExistAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(79)))), ((int)(((byte)(58)))));
            this.noExistAnimal.Location = new System.Drawing.Point(73, 167);
            this.noExistAnimal.MinimumSize = new System.Drawing.Size(674, 26);
            this.noExistAnimal.Name = "noExistAnimal";
            this.noExistAnimal.Size = new System.Drawing.Size(674, 26);
            this.noExistAnimal.TabIndex = 12;
            this.noExistAnimal.Text = "Sorry. There is no such animal in our store.";
            this.noExistAnimal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelBtnRemove
            // 
            this.panelBtnRemove.BackColor = System.Drawing.Color.Blue;
            this.panelBtnRemove.Location = new System.Drawing.Point(451, 107);
            this.panelBtnRemove.Name = "panelBtnRemove";
            this.panelBtnRemove.Size = new System.Drawing.Size(4, 52);
            this.panelBtnRemove.TabIndex = 10;
            // 
            // panelBtnAdding
            // 
            this.panelBtnAdding.BackColor = System.Drawing.Color.Blue;
            this.panelBtnAdding.Location = new System.Drawing.Point(194, 106);
            this.panelBtnAdding.Name = "panelBtnAdding";
            this.panelBtnAdding.Size = new System.Drawing.Size(4, 52);
            this.panelBtnAdding.TabIndex = 10;
            // 
            // btnAdding
            // 
            this.btnAdding.Activecolor = System.Drawing.Color.Transparent;
            this.btnAdding.BackColor = System.Drawing.Color.Transparent;
            this.btnAdding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdding.BorderRadius = 0;
            this.btnAdding.ButtonText = "Adding";
            this.btnAdding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdding.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdding.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdding.ForeColor = System.Drawing.Color.Black;
            this.btnAdding.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdding.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdding.Iconimage")));
            this.btnAdding.Iconimage_right = null;
            this.btnAdding.Iconimage_right_Selected = null;
            this.btnAdding.Iconimage_Selected = null;
            this.btnAdding.IconMarginLeft = 0;
            this.btnAdding.IconMarginRight = 0;
            this.btnAdding.IconRightVisible = true;
            this.btnAdding.IconRightZoom = 0D;
            this.btnAdding.IconVisible = true;
            this.btnAdding.IconZoom = 80D;
            this.btnAdding.IsTab = false;
            this.btnAdding.Location = new System.Drawing.Point(194, 106);
            this.btnAdding.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnAdding.Name = "btnAdding";
            this.btnAdding.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAdding.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAdding.OnHoverTextColor = System.Drawing.Color.DarkOrange;
            this.btnAdding.selected = false;
            this.btnAdding.Size = new System.Drawing.Size(247, 53);
            this.btnAdding.TabIndex = 9;
            this.btnAdding.Tag = "";
            this.btnAdding.Text = "Adding";
            this.btnAdding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdding.Textcolor = System.Drawing.Color.Black;
            this.btnAdding.TextFont = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.btnAdding.Click += new System.EventHandler(this.btnAdding_Click);
            // 
            // inputSpecies
            // 
            this.inputSpecies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputSpecies.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputSpecies.Location = new System.Drawing.Point(57, 46);
            this.inputSpecies.Name = "inputSpecies";
            this.inputSpecies.Size = new System.Drawing.Size(719, 38);
            this.inputSpecies.TabIndex = 11;
            this.inputSpecies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputSpecies.TextChanged += new System.EventHandler(this.inputSpecies_TextChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Activecolor = System.Drawing.Color.Transparent;
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.BorderRadius = 0;
            this.btnRemove.ButtonText = "Remove";
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.DisabledColor = System.Drawing.Color.Gray;
            this.btnRemove.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRemove.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRemove.Iconimage")));
            this.btnRemove.Iconimage_right = null;
            this.btnRemove.Iconimage_right_Selected = null;
            this.btnRemove.Iconimage_Selected = null;
            this.btnRemove.IconMarginLeft = 0;
            this.btnRemove.IconMarginRight = 0;
            this.btnRemove.IconRightVisible = true;
            this.btnRemove.IconRightZoom = 0D;
            this.btnRemove.IconVisible = true;
            this.btnRemove.IconZoom = 80D;
            this.btnRemove.IsTab = false;
            this.btnRemove.Location = new System.Drawing.Point(451, 107);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Normalcolor = System.Drawing.Color.Transparent;
            this.btnRemove.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnRemove.OnHoverTextColor = System.Drawing.Color.DarkOrange;
            this.btnRemove.selected = false;
            this.btnRemove.Size = new System.Drawing.Size(247, 53);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Tag = "";
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemove.Textcolor = System.Drawing.Color.Black;
            this.btnRemove.TextFont = new System.Drawing.Font("Comic Sans MS", 15.75F);
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // bunifuRoundInput
            // 
            this.bunifuRoundInput.ElipseRadius = 10;
            this.bunifuRoundInput.TargetControl = this.inputSpecies;
            // 
            // controlEditAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContent);
            this.Name = "controlEditAmount";
            this.Size = new System.Drawing.Size(990, 626);
            this.panelContent.ResumeLayout(false);
            this.panelAdding.ResumeLayout(false);
            this.panelAdding.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.panelAddingOrRemove.ResumeLayout(false);
            this.panelAddingOrRemove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelAdding;
        private System.Windows.Forms.Panel panelAddingOrRemove;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdding;
        private Bunifu.Framework.UI.BunifuFlatButton btnRemove;
        private System.Windows.Forms.Panel panelBtnAdding;
        private System.Windows.Forms.Panel panelBtnRemove;
        private System.Windows.Forms.TextBox inputSpecies;
        private Bunifu.Framework.UI.BunifuElipse bunifuRoundInput;
        private System.Windows.Forms.Label noExistAnimal;
        private System.Windows.Forms.TextBox numberAddMale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label textWantToAdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddAmount;
        private System.Windows.Forms.Label textSuccesAdded;
        private System.Windows.Forms.TextBox numberAddFemale;
        private System.Windows.Forms.Label textFemale;
        private System.Windows.Forms.Label textMale;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Label textSuccesDeleted;
        private System.Windows.Forms.TextBox numberDeleteFemale;
        private System.Windows.Forms.TextBox numberDeleteMale;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label textMale2;
        private System.Windows.Forms.Label textMale1;
        private System.Windows.Forms.Label textWantToDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteAmount;
    }
}
