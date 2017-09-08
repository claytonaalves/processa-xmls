/*
 * Created by SharpDevelop.
 * User: Clayton
 * Date: 08/07/2016
 * Time: 13:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProcessaXMLs
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btSelecionarArquivo;
		private System.Windows.Forms.Button btProcessar;
		private System.Windows.Forms.TextBox txtListagem;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.btSelecionarArquivo = new System.Windows.Forms.Button();
			this.btProcessar = new System.Windows.Forms.Button();
			this.txtListagem = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(391, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Selecionar pasta onde estão os XMLs";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// btSelecionarArquivo
			// 
			this.btSelecionarArquivo.Location = new System.Drawing.Point(12, 41);
			this.btSelecionarArquivo.Name = "btSelecionarArquivo";
			this.btSelecionarArquivo.Size = new System.Drawing.Size(391, 23);
			this.btSelecionarArquivo.TabIndex = 1;
			this.btSelecionarArquivo.Text = "Selecionar arquivo contendo as chaves";
			this.btSelecionarArquivo.UseVisualStyleBackColor = true;
			this.btSelecionarArquivo.Click += new System.EventHandler(this.Button2Click);
			// 
			// btProcessar
			// 
			this.btProcessar.Enabled = false;
			this.btProcessar.Location = new System.Drawing.Point(12, 70);
			this.btProcessar.Name = "btProcessar";
			this.btProcessar.Size = new System.Drawing.Size(391, 23);
			this.btProcessar.TabIndex = 2;
			this.btProcessar.Text = "Processar";
			this.btProcessar.UseVisualStyleBackColor = true;
			this.btProcessar.Click += new System.EventHandler(this.btProcessarClick);
			// 
			// txtListagem
			// 
			this.txtListagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.txtListagem.Location = new System.Drawing.Point(12, 99);
			this.txtListagem.Multiline = true;
			this.txtListagem.Name = "txtListagem";
			this.txtListagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtListagem.Size = new System.Drawing.Size(391, 261);
			this.txtListagem.TabIndex = 3;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 363);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "label1";
			this.label1.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(415, 387);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtListagem);
			this.Controls.Add(this.btProcessar);
			this.Controls.Add(this.btSelecionarArquivo);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Processa XMLs";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
