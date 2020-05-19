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
			this.DecryptPage = new System.Windows.Forms.TabPage();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.EncryptPage = new System.Windows.Forms.TabPage();
			this.BtnEncrypt = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BtnLoad = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.NumericPass = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.tabControl1.SuspendLayout();
			this.EncryptPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericPass)).BeginInit();
			this.SuspendLayout();
			// 
			// DecryptPage
			// 
			this.DecryptPage.Location = new System.Drawing.Point(4, 22);
			this.DecryptPage.Name = "DecryptPage";
			this.DecryptPage.Padding = new System.Windows.Forms.Padding(3);
			this.DecryptPage.Size = new System.Drawing.Size(514, 367);
			this.DecryptPage.TabIndex = 1;
			this.DecryptPage.Text = "tabPage2";
			this.DecryptPage.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.EncryptPage);
			this.tabControl1.Controls.Add(this.DecryptPage);
			this.tabControl1.Location = new System.Drawing.Point(12, 13);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(522, 393);
			this.tabControl1.TabIndex = 0;
			// 
			// EncryptPage
			// 
			this.EncryptPage.Controls.Add(this.label1);
			this.EncryptPage.Controls.Add(this.NumericPass);
			this.EncryptPage.Controls.Add(this.BtnEncrypt);
			this.EncryptPage.Controls.Add(this.pictureBox1);
			this.EncryptPage.Controls.Add(this.BtnLoad);
			this.EncryptPage.Location = new System.Drawing.Point(4, 22);
			this.EncryptPage.Name = "EncryptPage";
			this.EncryptPage.Padding = new System.Windows.Forms.Padding(3);
			this.EncryptPage.Size = new System.Drawing.Size(514, 367);
			this.EncryptPage.TabIndex = 0;
			this.EncryptPage.Text = "Шифрование";
			this.EncryptPage.UseVisualStyleBackColor = true;
			// 
			// BtnEncrypt
			// 
			this.BtnEncrypt.Location = new System.Drawing.Point(388, 334);
			this.BtnEncrypt.Name = "BtnEncrypt";
			this.BtnEncrypt.Size = new System.Drawing.Size(120, 20);
			this.BtnEncrypt.TabIndex = 2;
			this.BtnEncrypt.Text = "Зашифровать";
			this.BtnEncrypt.UseVisualStyleBackColor = true;
			this.BtnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(3, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(505, 316);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// BtnLoad
			// 
			this.BtnLoad.Location = new System.Drawing.Point(6, 334);
			this.BtnLoad.Name = "BtnLoad";
			this.BtnLoad.Size = new System.Drawing.Size(112, 20);
			this.BtnLoad.TabIndex = 0;
			this.BtnLoad.Text = "Загрузить файл";
			this.BtnLoad.UseVisualStyleBackColor = true;
			this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// NumericPass
			// 
			this.NumericPass.Location = new System.Drawing.Point(234, 334);
			this.NumericPass.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumericPass.Name = "NumericPass";
			this.NumericPass.Size = new System.Drawing.Size(120, 20);
			this.NumericPass.TabIndex = 3;
			this.NumericPass.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(147, 338);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Число-пароль:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 419);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "ImageEncrypt";
			this.tabControl1.ResumeLayout(false);
			this.EncryptPage.ResumeLayout(false);
			this.EncryptPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericPass)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage DecryptPage;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage EncryptPage;
		private System.Windows.Forms.Button BtnEncrypt;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button BtnLoad;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown NumericPass;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

