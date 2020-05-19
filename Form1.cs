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
		public Form1() {
			InitializeComponent();
		}
		private void BtnLoad_Click(object sender, EventArgs e) {
			if(openFileDialog1.ShowDialog() == DialogResult.OK) {
				Stream LoadFile = openFileDialog1.OpenFile();
				pictureBox1.Image = Image.FromStream(LoadFile);
				LoadFile.Position = 0;
				BinaryReader br = new BinaryReader(LoadFile);
				bytes = br.ReadBytes(Convert.ToInt32(LoadFile.Length));
				result = new byte[LoadFile.Length];
				br.Close();
			}
		}

		private void BtnEncrypt_Click(object sender, EventArgs e) {
			int iterator = Convert.ToInt32(NumericPass.Value);
			int temp = bytes.Length - (bytes.Length % iterator);
			
			//изначальный файл = 9х[10 байт][9 байт]
			//результат = [9 байт]  9х[10 байт]
			int Counter = bytes.Length - temp;
			if(temp!=bytes.Length)
				for(int i=0; i < (bytes.Length%iterator); i++)
					result[i] = bytes[temp + i];
			for(int i=1; i <= temp / iterator; i++) { //итерации
				for(long x = 0; x < iterator; x++, Counter++) {
					result[Counter] = bytes[temp - i * iterator + x];
				}
			}

			if(saveFileDialog1.ShowDialog() == DialogResult.OK) {
				BinaryWriter bw = new BinaryWriter(saveFileDialog1.OpenFile());
				bw.Write(result);
				bw.Close();
			}
		}
	}
}
