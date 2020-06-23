namespace ex3
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.kilometri1 = new System.Windows.Forms.RadioButton();
			this.metri1 = new System.Windows.Forms.RadioButton();
			this.decimetri1 = new System.Windows.Forms.RadioButton();
			this.centimetri1 = new System.Windows.Forms.RadioButton();
			this.milimetri1 = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.milimetri2 = new System.Windows.Forms.RadioButton();
			this.centimetri2 = new System.Windows.Forms.RadioButton();
			this.decimetri2 = new System.Windows.Forms.RadioButton();
			this.metri2 = new System.Windows.Forms.RadioButton();
			this.kilometri2 = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(70, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lungimea data";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(70, 268);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Lungimea-rezultat";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.milimetri1);
			this.groupBox1.Controls.Add(this.centimetri1);
			this.groupBox1.Controls.Add(this.decimetri1);
			this.groupBox1.Controls.Add(this.metri1);
			this.groupBox1.Controls.Add(this.kilometri1);
			this.groupBox1.Location = new System.Drawing.Point(457, 41);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 186);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Unitatea de masura";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(293, 172);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 55);
			this.label3.TabIndex = 0;
			this.label3.Text = "=";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(219, 121);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(189, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "0";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(219, 270);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(189, 20);
			this.textBox2.TabIndex = 2;
			// 
			// kilometri1
			// 
			this.kilometri1.AutoSize = true;
			this.kilometri1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kilometri1.Location = new System.Drawing.Point(19, 20);
			this.kilometri1.Name = "kilometri1";
			this.kilometri1.Size = new System.Drawing.Size(85, 24);
			this.kilometri1.TabIndex = 0;
			this.kilometri1.TabStop = true;
			this.kilometri1.Text = "kilometri";
			this.kilometri1.UseVisualStyleBackColor = true;
			// 
			// metri1
			// 
			this.metri1.AutoSize = true;
			this.metri1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.metri1.Location = new System.Drawing.Point(19, 50);
			this.metri1.Name = "metri1";
			this.metri1.Size = new System.Drawing.Size(62, 24);
			this.metri1.TabIndex = 0;
			this.metri1.TabStop = true;
			this.metri1.Text = "metri";
			this.metri1.UseVisualStyleBackColor = true;
			// 
			// decimetri1
			// 
			this.decimetri1.AutoSize = true;
			this.decimetri1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.decimetri1.Location = new System.Drawing.Point(19, 80);
			this.decimetri1.Name = "decimetri1";
			this.decimetri1.Size = new System.Drawing.Size(91, 24);
			this.decimetri1.TabIndex = 0;
			this.decimetri1.TabStop = true;
			this.decimetri1.Text = "decimetri";
			this.decimetri1.UseVisualStyleBackColor = true;
			// 
			// centimetri1
			// 
			this.centimetri1.AutoSize = true;
			this.centimetri1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.centimetri1.Location = new System.Drawing.Point(19, 110);
			this.centimetri1.Name = "centimetri1";
			this.centimetri1.Size = new System.Drawing.Size(96, 24);
			this.centimetri1.TabIndex = 0;
			this.centimetri1.TabStop = true;
			this.centimetri1.Text = "centimetri";
			this.centimetri1.UseVisualStyleBackColor = true;
			// 
			// milimetri1
			// 
			this.milimetri1.AutoSize = true;
			this.milimetri1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.milimetri1.Location = new System.Drawing.Point(19, 140);
			this.milimetri1.Name = "milimetri1";
			this.milimetri1.Size = new System.Drawing.Size(84, 24);
			this.milimetri1.TabIndex = 0;
			this.milimetri1.TabStop = true;
			this.milimetri1.Text = "milimetri";
			this.milimetri1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.milimetri2);
			this.groupBox2.Controls.Add(this.centimetri2);
			this.groupBox2.Controls.Add(this.decimetri2);
			this.groupBox2.Controls.Add(this.metri2);
			this.groupBox2.Controls.Add(this.kilometri2);
			this.groupBox2.Location = new System.Drawing.Point(457, 233);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 186);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Unitatea de masura";
			// 
			// milimetri2
			// 
			this.milimetri2.AutoSize = true;
			this.milimetri2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.milimetri2.Location = new System.Drawing.Point(19, 140);
			this.milimetri2.Name = "milimetri2";
			this.milimetri2.Size = new System.Drawing.Size(84, 24);
			this.milimetri2.TabIndex = 0;
			this.milimetri2.TabStop = true;
			this.milimetri2.Text = "milimetri";
			this.milimetri2.UseVisualStyleBackColor = true;
			this.milimetri2.CheckedChanged += new System.EventHandler(this.Milimetri2_CheckedChanged);
			// 
			// centimetri2
			// 
			this.centimetri2.AutoSize = true;
			this.centimetri2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.centimetri2.Location = new System.Drawing.Point(19, 110);
			this.centimetri2.Name = "centimetri2";
			this.centimetri2.Size = new System.Drawing.Size(96, 24);
			this.centimetri2.TabIndex = 0;
			this.centimetri2.TabStop = true;
			this.centimetri2.Text = "centimetri";
			this.centimetri2.UseVisualStyleBackColor = true;
			this.centimetri2.CheckedChanged += new System.EventHandler(this.Centimetri2_CheckedChanged);
			// 
			// decimetri2
			// 
			this.decimetri2.AutoSize = true;
			this.decimetri2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.decimetri2.Location = new System.Drawing.Point(19, 80);
			this.decimetri2.Name = "decimetri2";
			this.decimetri2.Size = new System.Drawing.Size(91, 24);
			this.decimetri2.TabIndex = 0;
			this.decimetri2.TabStop = true;
			this.decimetri2.Text = "decimetri";
			this.decimetri2.UseVisualStyleBackColor = true;
			this.decimetri2.CheckedChanged += new System.EventHandler(this.Decimetri2_CheckedChanged);
			// 
			// metri2
			// 
			this.metri2.AutoSize = true;
			this.metri2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.metri2.Location = new System.Drawing.Point(19, 50);
			this.metri2.Name = "metri2";
			this.metri2.Size = new System.Drawing.Size(62, 24);
			this.metri2.TabIndex = 0;
			this.metri2.TabStop = true;
			this.metri2.Text = "metri";
			this.metri2.UseVisualStyleBackColor = true;
			this.metri2.CheckedChanged += new System.EventHandler(this.Metri2_CheckedChanged);
			// 
			// kilometri2
			// 
			this.kilometri2.AutoSize = true;
			this.kilometri2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kilometri2.Location = new System.Drawing.Point(19, 20);
			this.kilometri2.Name = "kilometri2";
			this.kilometri2.Size = new System.Drawing.Size(85, 24);
			this.kilometri2.TabIndex = 0;
			this.kilometri2.TabStop = true;
			this.kilometri2.Text = "kilometri";
			this.kilometri2.UseVisualStyleBackColor = true;
			this.kilometri2.CheckedChanged += new System.EventHandler(this.Kilometri2_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton milimetri1;
		private System.Windows.Forms.RadioButton centimetri1;
		private System.Windows.Forms.RadioButton decimetri1;
		private System.Windows.Forms.RadioButton metri1;
		private System.Windows.Forms.RadioButton kilometri1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton milimetri2;
		private System.Windows.Forms.RadioButton centimetri2;
		private System.Windows.Forms.RadioButton decimetri2;
		private System.Windows.Forms.RadioButton metri2;
		private System.Windows.Forms.RadioButton kilometri2;
	}
}

