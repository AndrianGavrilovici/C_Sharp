﻿namespace testAppDesign {
    partial class controlBasket {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlBasket));
            this.textPrice = new System.Windows.Forms.Label();
            this.textFemale = new System.Windows.Forms.Label();
            this.textMale = new System.Windows.Forms.Label();
            this.textAnimal = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.bunifuRoundPanel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelBasket = new System.Windows.Forms.Panel();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // textPrice
            // 
            this.textPrice.AutoSize = true;
            this.textPrice.BackColor = System.Drawing.Color.Transparent;
            this.textPrice.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPrice.ForeColor = System.Drawing.Color.White;
            this.textPrice.Location = new System.Drawing.Point(607, 9);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(85, 40);
            this.textPrice.TabIndex = 11;
            this.textPrice.Text = "Price";
            // 
            // textFemale
            // 
            this.textFemale.AutoSize = true;
            this.textFemale.BackColor = System.Drawing.Color.Transparent;
            this.textFemale.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFemale.ForeColor = System.Drawing.Color.White;
            this.textFemale.Location = new System.Drawing.Point(407, 9);
            this.textFemale.Name = "textFemale";
            this.textFemale.Size = new System.Drawing.Size(113, 40);
            this.textFemale.TabIndex = 12;
            this.textFemale.Text = "Female";
            // 
            // textMale
            // 
            this.textMale.AutoSize = true;
            this.textMale.BackColor = System.Drawing.Color.Transparent;
            this.textMale.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMale.ForeColor = System.Drawing.Color.White;
            this.textMale.Location = new System.Drawing.Point(253, 9);
            this.textMale.Name = "textMale";
            this.textMale.Size = new System.Drawing.Size(81, 40);
            this.textMale.TabIndex = 13;
            this.textMale.Text = "Male";
            // 
            // textAnimal
            // 
            this.textAnimal.AutoSize = true;
            this.textAnimal.BackColor = System.Drawing.Color.Transparent;
            this.textAnimal.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAnimal.ForeColor = System.Drawing.Color.White;
            this.textAnimal.Location = new System.Drawing.Point(49, 9);
            this.textAnimal.Name = "textAnimal";
            this.textAnimal.Size = new System.Drawing.Size(107, 40);
            this.textAnimal.TabIndex = 14;
            this.textAnimal.Text = "Animal";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Gray;
            this.panelTitle.Controls.Add(this.textPrice);
            this.panelTitle.Controls.Add(this.textAnimal);
            this.panelTitle.Controls.Add(this.textFemale);
            this.panelTitle.Controls.Add(this.textMale);
            this.panelTitle.Location = new System.Drawing.Point(60, 31);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(740, 49);
            this.panelTitle.TabIndex = 15;
            // 
            // bunifuRoundPanel
            // 
            this.bunifuRoundPanel.ElipseRadius = 10;
            this.bunifuRoundPanel.TargetControl = this.panelTitle;
            // 
            // panelBasket
            // 
            this.panelBasket.AutoScroll = true;
            this.panelBasket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBasket.BackgroundImage")));
            this.panelBasket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBasket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBasket.Location = new System.Drawing.Point(0, 0);
            this.panelBasket.Name = "panelBasket";
            this.panelBasket.Size = new System.Drawing.Size(990, 626);
            this.panelBasket.TabIndex = 16;
            // 
            // controlBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelBasket);
            this.DoubleBuffered = true;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "controlBasket";
            this.Size = new System.Drawing.Size(990, 626);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textPrice;
        private System.Windows.Forms.Label textFemale;
        private System.Windows.Forms.Label textMale;
        private System.Windows.Forms.Label textAnimal;
        private System.Windows.Forms.Panel panelTitle;
        private Bunifu.Framework.UI.BunifuElipse bunifuRoundPanel;
        private System.Windows.Forms.Panel panelBasket;
    }
}
