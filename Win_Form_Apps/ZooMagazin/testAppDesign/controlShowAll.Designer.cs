﻿namespace testAppDesign
{
    partial class controlShowAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlShowAll));
            this.panelShowAll = new System.Windows.Forms.Panel();
            this.textAnimal = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.Label();
            this.textFemale = new System.Windows.Forms.Label();
            this.textMale = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.bunifuRoundPanel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelShowAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShowAll
            // 
            this.panelShowAll.AutoScroll = true;
            this.panelShowAll.BackColor = System.Drawing.Color.White;
            this.panelShowAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelShowAll.BackgroundImage")));
            this.panelShowAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelShowAll.Controls.Add(this.textAnimal);
            this.panelShowAll.Controls.Add(this.textPrice);
            this.panelShowAll.Controls.Add(this.textFemale);
            this.panelShowAll.Controls.Add(this.textMale);
            this.panelShowAll.Controls.Add(this.panelTitle);
            this.panelShowAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowAll.Location = new System.Drawing.Point(0, 0);
            this.panelShowAll.Name = "panelShowAll";
            this.panelShowAll.Size = new System.Drawing.Size(990, 626);
            this.panelShowAll.TabIndex = 0;
            // 
            // textAnimal
            // 
            this.textAnimal.AutoSize = true;
            this.textAnimal.BackColor = System.Drawing.Color.Gray;
            this.textAnimal.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAnimal.ForeColor = System.Drawing.Color.White;
            this.textAnimal.Location = new System.Drawing.Point(109, 40);
            this.textAnimal.Name = "textAnimal";
            this.textAnimal.Size = new System.Drawing.Size(107, 40);
            this.textAnimal.TabIndex = 8;
            this.textAnimal.Text = "Animal";
            // 
            // textPrice
            // 
            this.textPrice.AutoSize = true;
            this.textPrice.BackColor = System.Drawing.Color.Gray;
            this.textPrice.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPrice.ForeColor = System.Drawing.Color.White;
            this.textPrice.Location = new System.Drawing.Point(667, 40);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(85, 40);
            this.textPrice.TabIndex = 2;
            this.textPrice.Text = "Price";
            // 
            // textFemale
            // 
            this.textFemale.AutoSize = true;
            this.textFemale.BackColor = System.Drawing.Color.Gray;
            this.textFemale.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFemale.ForeColor = System.Drawing.Color.White;
            this.textFemale.Location = new System.Drawing.Point(467, 40);
            this.textFemale.Name = "textFemale";
            this.textFemale.Size = new System.Drawing.Size(113, 40);
            this.textFemale.TabIndex = 5;
            this.textFemale.Text = "Female";
            // 
            // textMale
            // 
            this.textMale.AutoSize = true;
            this.textMale.BackColor = System.Drawing.Color.Gray;
            this.textMale.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMale.ForeColor = System.Drawing.Color.White;
            this.textMale.Location = new System.Drawing.Point(313, 40);
            this.textMale.Name = "textMale";
            this.textMale.Size = new System.Drawing.Size(81, 40);
            this.textMale.TabIndex = 7;
            this.textMale.Text = "Male";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Gray;
            this.panelTitle.Location = new System.Drawing.Point(60, 31);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(740, 49);
            this.panelTitle.TabIndex = 10;
            // 
            // bunifuRoundPanel
            // 
            this.bunifuRoundPanel.ElipseRadius = 10;
            this.bunifuRoundPanel.TargetControl = this.panelTitle;
            // 
            // controlShowAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelShowAll);
            this.DoubleBuffered = true;
            this.Name = "controlShowAll";
            this.Size = new System.Drawing.Size(990, 626);
            this.panelShowAll.ResumeLayout(false);
            this.panelShowAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShowAll;
        private System.Windows.Forms.Label textPrice;
        private System.Windows.Forms.Label textFemale;
        private System.Windows.Forms.Label textMale;
        private System.Windows.Forms.Label textAnimal;
        private System.Windows.Forms.Panel panelTitle;
        private Bunifu.Framework.UI.BunifuElipse bunifuRoundPanel;
    }
}
