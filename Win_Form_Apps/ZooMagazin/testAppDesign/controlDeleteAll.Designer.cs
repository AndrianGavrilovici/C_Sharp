﻿namespace testAppDesign {
    partial class controlDeleteAll {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlDeleteAll));
            this.btnDelAll = new Bunifu.Framework.UI.BunifuFlatButton();
            this.succesDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelAll
            // 
            this.btnDelAll.Activecolor = System.Drawing.Color.Transparent;
            this.btnDelAll.BackColor = System.Drawing.Color.Transparent;
            this.btnDelAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelAll.BorderRadius = 0;
            this.btnDelAll.ButtonText = "Delete All Animals";
            this.btnDelAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelAll.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelAll.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.btnDelAll.IconZoom = 90D;
            this.btnDelAll.IsTab = false;
            this.btnDelAll.Location = new System.Drawing.Point(281, 154);
            this.btnDelAll.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDelAll.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDelAll.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btnDelAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelAll.selected = false;
            this.btnDelAll.Size = new System.Drawing.Size(338, 65);
            this.btnDelAll.TabIndex = 24;
            this.btnDelAll.Text = "Delete All Animals";
            this.btnDelAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelAll.Textcolor = System.Drawing.Color.Black;
            this.btnDelAll.TextFont = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // succesDelete
            // 
            this.succesDelete.AutoSize = true;
            this.succesDelete.BackColor = System.Drawing.Color.Transparent;
            this.succesDelete.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.succesDelete.ForeColor = System.Drawing.Color.Lime;
            this.succesDelete.Location = new System.Drawing.Point(305, 281);
            this.succesDelete.Name = "succesDelete";
            this.succesDelete.Size = new System.Drawing.Size(233, 26);
            this.succesDelete.TabIndex = 25;
            this.succesDelete.Text = "You deleted successfully!";
            this.succesDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // controlDeleteAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.succesDelete);
            this.Controls.Add(this.btnDelAll);
            this.DoubleBuffered = true;
            this.Name = "controlDeleteAll";
            this.Size = new System.Drawing.Size(990, 626);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnDelAll;
        private System.Windows.Forms.Label succesDelete;
    }
}
