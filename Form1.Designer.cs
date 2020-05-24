namespace ImageEncrypt {
	partial class Form1 {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.label2 = new System.Windows.Forms.Label();
			this.NumericPass = new System.Windows.Forms.NumericUpDown();
			this.Decrypt = new System.Windows.Forms.Button();
			this.Loader = new System.Windows.Forms.Button();
			this.BtnEncrypt = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BtnLoad = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.NumericPass)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(159, 331);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Число-пароль:";
			// 
			// NumericPass
			// 
			this.NumericPass.Location = new System.Drawing.Point(246, 329);
			this.NumericPass.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumericPass.Name = "NumericPass";
			this.NumericPass.Size = new System.Drawing.Size(120, 20);
			this.NumericPass.TabIndex = 7;
			this.NumericPass.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Decrypt
			// 
			this.Decrypt.Location = new System.Drawing.Point(390, 349);
			this.Decrypt.Name = "Decrypt";
			this.Decrypt.Size = new System.Drawing.Size(148, 48);
			this.Decrypt.TabIndex = 6;
			this.Decrypt.Text = "Расшифровать";
			this.Decrypt.UseVisualStyleBackColor = true;
			this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
			// 
			// Loader
			// 
			this.Loader.Location = new System.Drawing.Point(12, 349);
			this.Loader.Name = "Loader";
			this.Loader.Size = new System.Drawing.Size(148, 48);
			this.Loader.TabIndex = 5;
			this.Loader.Text = "Загрузить зашифрованный файл";
			this.Loader.UseVisualStyleBackColor = true;
			this.Loader.Click += new System.EventHandler(this.Loader_Click);
			// 
			// BtnEncrypt
			// 
			this.BtnEncrypt.Location = new System.Drawing.Point(390, 282);
			this.BtnEncrypt.Name = "BtnEncrypt";
			this.BtnEncrypt.Size = new System.Drawing.Size(148, 48);
			this.BtnEncrypt.TabIndex = 2;
			this.BtnEncrypt.Text = "Зашифровать";
			this.BtnEncrypt.UseVisualStyleBackColor = true;
			this.BtnEncrypt.Click += new System.EventHandler(this.Encrypt_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(255, 255);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// BtnLoad
			// 
			this.BtnLoad.Location = new System.Drawing.Point(12, 277);
			this.BtnLoad.Name = "BtnLoad";
			this.BtnLoad.Size = new System.Drawing.Size(148, 48);
			this.BtnLoad.TabIndex = 0;
			this.BtnLoad.Text = "Загрузить исходный файл";
			this.BtnLoad.UseVisualStyleBackColor = true;
			this.BtnLoad.Click += new System.EventHandler(this.Load_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// pictureBox2
			// 
			this.pictureBox2.InitialImage = null;
			this.pictureBox2.Location = new System.Drawing.Point(286, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(253, 255);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 409);
			this.Controls.Add(this.Decrypt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BtnLoad);
			this.Controls.Add(this.NumericPass);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.Loader);
			this.Controls.Add(this.BtnEncrypt);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "ImageEncrypt";
			((System.ComponentModel.ISupportInitialize)(this.NumericPass)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button BtnEncrypt;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button BtnLoad;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumericPass;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Button Loader;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

