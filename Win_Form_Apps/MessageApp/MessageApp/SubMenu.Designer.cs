namespace MessageApp {
    partial class SubMenu {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubMenu));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1Page0 = new System.Windows.Forms.Panel();
            this.panel2Page0 = new System.Windows.Forms.Panel();
            this.panel3Page0 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1Page0.SuspendLayout();
            this.panel3Page0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(-7, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(231, 670);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(84)))), ((int)(((byte)(90)))));
            this.tabPage1.Controls.Add(this.panel1Page0);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(223, 644);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "0";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(84)))), ((int)(((byte)(90)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(223, 644);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(84)))), ((int)(((byte)(90)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(223, 644);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "2";
            // 
            // panel1Page0
            // 
            this.panel1Page0.Controls.Add(this.panel3Page0);
            this.panel1Page0.Controls.Add(this.panel2Page0);
            this.panel1Page0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1Page0.Location = new System.Drawing.Point(3, 3);
            this.panel1Page0.Name = "panel1Page0";
            this.panel1Page0.Size = new System.Drawing.Size(217, 638);
            this.panel1Page0.TabIndex = 0;
            // 
            // panel2Page0
            // 
            this.panel2Page0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2Page0.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2Page0.Location = new System.Drawing.Point(0, 0);
            this.panel2Page0.Name = "panel2Page0";
            this.panel2Page0.Size = new System.Drawing.Size(10, 638);
            this.panel2Page0.TabIndex = 0;
            // 
            // panel3Page0
            // 
            this.panel3Page0.Controls.Add(this.bunifuImageButton1);
            this.panel3Page0.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3Page0.Location = new System.Drawing.Point(10, 588);
            this.panel3Page0.Name = "panel3Page0";
            this.panel3Page0.Size = new System.Drawing.Size(207, 50);
            this.panel3Page0.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(207, 50);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // SubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Name = "SubMenu";
            this.Size = new System.Drawing.Size(215, 661);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1Page0.ResumeLayout(false);
            this.panel3Page0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1Page0;
        private System.Windows.Forms.Panel panel3Page0;
        private System.Windows.Forms.Panel panel2Page0;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}
