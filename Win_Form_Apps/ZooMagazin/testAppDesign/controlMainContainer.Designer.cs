﻿namespace testAppDesign
{
    partial class controlMainContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlMainContainer));
            this.textAppCreated = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // textAppCreated
            // 
            this.textAppCreated.AutoSize = true;
            this.textAppCreated.BackColor = System.Drawing.Color.Transparent;
            this.textAppCreated.Font = new System.Drawing.Font("Cambria Math", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAppCreated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.textAppCreated.Location = new System.Drawing.Point(11, 111);
            this.textAppCreated.Name = "textAppCreated";
            this.textAppCreated.Size = new System.Drawing.Size(976, 268);
            this.textAppCreated.TabIndex = 0;
            this.textAppCreated.Text = "Application created by Andrian Gavrilovici";
            // 
            // controlMainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.textAppCreated);
            this.DoubleBuffered = true;
            this.Name = "controlMainContainer";
            this.Size = new System.Drawing.Size(990, 626);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel textAppCreated;
    }
}