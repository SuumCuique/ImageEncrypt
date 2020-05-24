using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageEncrypt {
	public partial class Form1 : Form {
		byte[] result;
		byte[] bytes;
		string Extension;
		public Form1() {
			InitializeComponent();
		}

		private void Load_Click(object sender, EventArgs e) {
			if(openFileDialog1.ShowDialog() == DialogResult.OK) {
				Extension = Path.GetExtension(openFileDialog1.FileName);
				Stream LoadFile = openFileDialog1.OpenFile();
				pictureBox1.Image = Image.FromStream(LoadFile);
				LoadFile.Position = 0;
				BinaryReader br = new BinaryReader(LoadFile);
				bytes = br.ReadBytes(Convert.ToInt32(LoadFile.Length));
				result = new byte[LoadFile.Length];
				br.Close();
			}
		}

		private void Encrypt_Click(object sender, EventArgs e) {
			int iterator = Convert.ToInt32(NumericPass.Value);
			int temp = bytes.Length - (bytes.Length % iterator);

			//изначальный файл = 9х[10 байт][9 байт]
			//результат = [9 байт]  9х[10 байт]
			int Counter = bytes.Length - temp;
			if(temp != bytes.Length)
				for(int i = 0; i < (bytes.Length % iterator); i++)
					result[i] = bytes[temp + i];
			for(int i = 1; i <= temp / iterator; i++) { //итерации
				for(long x = 0; x < iterator; x++, Counter++) {
					result[Counter] = bytes[temp - i * iterator + x];
				}
			}
			//-------------------
			Stream file = File.OpenRead("Ea5jUx65.jpg");
			byte[] image = new byte[file.Length + Extension.Length + 2 + bytes.Length];
			BinaryReader br = new BinaryReader(file);
			br.ReadBytes(Convert.ToInt32(file.Length)).CopyTo(image, 0);
			byte[] Extbytes = ASCIIEncoding.ASCII.GetBytes("\n"+Extension+"\n");
			Extbytes.CopyTo(image, file.Length);
			result.CopyTo(image, file.Length + Extbytes.Length);
			br.Close();
			//-------------------
			saveFileDialog1.DefaultExt = Extension;
			if(saveFileDialog1.ShowDialog() == DialogResult.OK) {
				BinaryWriter bw = new BinaryWriter(saveFileDialog1.OpenFile());
				bw.Write(image);
				bw.Close();
				Stream LoadFile = openFileDialog1.OpenFile();
				pictureBox2.Image = Image.FromFile(saveFileDialog1.FileName);
			}
		}

		private void Decrypt_Click(object sender, EventArgs e) {
			//изначальный вес изображения - 200065 байт https://theasciicode.com.ar/ascii-printable-characters/lowercase-letter-p-minuscule-ascii-code-112.html
			int iterator = Convert.ToInt32(NumericPass.Value);
			int ost = bytes.Length % iterator;
			byte[] format = new byte[3];
			Array.Copy(bytes, 200066, format, 0, 3);
			int tmp = 0;
			byte[] bytes_crypt = new byte[bytes.Length - (200065 + 5)];
			Array.Copy(bytes_crypt, 200065 + 5, bytes, 0, bytes.Length - (200065 + 5));
			for(int i = bytes_crypt.Length - iterator; i >= ost; i -= iterator) {
				Array.Copy(bytes_crypt, i, result, tmp, iterator);
				tmp += iterator;
			}
			if(ost > 0) {
				Array.Copy(bytes_crypt, 0, result, tmp, ost);
			}
			saveFileDialog1.DefaultExt = Extension;
			try {
				pictureBox2.Image = null;
				BinaryWriter bw1 = new BinaryWriter(new FileStream("decrypted" + Extension, FileMode.Create));
				bw1.Write(result);
				bw1.Close();
				pictureBox2.Image = Image.FromStream(new FileStream("decrypted" + Extension, FileMode.Open));
			}
			catch(Exception w) { }

			if(saveFileDialog1.ShowDialog() == DialogResult.OK) {
				BinaryWriter bw = new BinaryWriter(saveFileDialog1.OpenFile());
				bw.Write(result);
				bw.Close();
			}
		}

		private void Loader_Click(object sender, EventArgs e) {
			if(result != null)
				Array.Clear(result, 0, result.Length);
			if(bytes != null)
				Array.Clear(bytes, 0, bytes.Length);
			if(openFileDialog1.ShowDialog() == DialogResult.OK) {
				Extension = Path.GetExtension(openFileDialog1.FileName);
				Stream LoadFile = openFileDialog1.OpenFile();
				pictureBox2.Image = Image.FromStream(LoadFile);
				LoadFile.Position = 0;
				BinaryReader br = new BinaryReader(LoadFile);
				bytes = br.ReadBytes(Convert.ToInt32(LoadFile.Length));
				result = new byte[LoadFile.Length];
				br.Close();
			}
		}
	}
}
