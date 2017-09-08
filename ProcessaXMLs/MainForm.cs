using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace ProcessaXMLs
{
	public partial class MainForm : Form
	{
		private List<string> chaves_xmls_gerados = new List<string>();
		private List<string> chaves_xmls_sefaz = new List<string>();
			
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (this.folderBrowserDialog1.ShowDialog()==DialogResult.OK) {;
				string caminhoXMLs = this.folderBrowserDialog1.SelectedPath;
			    string[] arquivos = Directory.GetFiles(caminhoXMLs);
			    foreach (string nomeArquivo in arquivos) {
			    	string chave = nomeArquivo.Replace(caminhoXMLs+"\\", "").Replace("-nfe.xml", "");
			    	chaves_xmls_gerados.Add(chave);
			    }
			    button1.Text = caminhoXMLs;
			    button1.Enabled = false;
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if (this.openFileDialog1.ShowDialog()==DialogResult.OK) {
				string nomeArquivo = this.openFileDialog1.FileName;
				using (StreamReader sr = new StreamReader(nomeArquivo)) {
					while (!sr.EndOfStream) {
						string linha = sr.ReadLine();
						chaves_xmls_sefaz.Add(linha);
					}
				}
				btSelecionarArquivo.Text = nomeArquivo;
				btSelecionarArquivo.Enabled = false;
     			btProcessar.Enabled = true;
			}
		}
		
		void btProcessarClick(object sender, EventArgs e)
		{
			btProcessar.Enabled = false;
			foreach (string chave_sefaz in chaves_xmls_sefaz) {
				string chave = chave_sefaz
					.Replace("/", "")
					.Replace(".", "")
					.Replace("-", "");
				if (!chaves_xmls_gerados.Contains(chave))
					txtListagem.AppendText(chave_sefaz + Environment.NewLine);
			}
			label1.Text = txtListagem.Lines.Length.ToString() + " xmls não encontrados";
			label1.Visible = true;
		}
	}
}
