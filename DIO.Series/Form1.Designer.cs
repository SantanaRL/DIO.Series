
namespace DIO.Series
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Series = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.visualizar = new System.Windows.Forms.TabPage();
			this.tbDesc = new System.Windows.Forms.RichTextBox();
			this.btnAtualiza = new System.Windows.Forms.Button();
			this.btnExclui = new System.Windows.Forms.Button();
			this.btn_buscar = new System.Windows.Forms.Button();
			this.tbId = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbAno = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbTitulo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.adicionar = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.tbNdesc = new System.Windows.Forms.RichTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tbNano = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tbNtitulo = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tbNGen = new System.Windows.Forms.ComboBox();
			this.listaSeries = new System.Windows.Forms.ListView();
			this.tbGen = new System.Windows.Forms.ComboBox();
			this.serieBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tabControl1.SuspendLayout();
			this.Series.SuspendLayout();
			this.visualizar.SuspendLayout();
			this.adicionar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.serieBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.Series);
			this.tabControl1.Controls.Add(this.visualizar);
			this.tabControl1.Controls.Add(this.adicionar);
			this.tabControl1.Location = new System.Drawing.Point(12, 54);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(365, 326);
			this.tabControl1.TabIndex = 2;
			// 
			// Series
			// 
			this.Series.Controls.Add(this.listaSeries);
			this.Series.Controls.Add(this.label5);
			this.Series.Location = new System.Drawing.Point(4, 22);
			this.Series.Name = "Series";
			this.Series.Padding = new System.Windows.Forms.Padding(3);
			this.Series.Size = new System.Drawing.Size(357, 300);
			this.Series.TabIndex = 0;
			this.Series.Text = "lista";
			this.Series.UseVisualStyleBackColor = true;
			this.Series.Enter += new System.EventHandler(this.Series_Enter);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(96, 42);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "séries inseridas:";
			// 
			// visualizar
			// 
			this.visualizar.Controls.Add(this.tbGen);
			this.visualizar.Controls.Add(this.tbDesc);
			this.visualizar.Controls.Add(this.btnAtualiza);
			this.visualizar.Controls.Add(this.btnExclui);
			this.visualizar.Controls.Add(this.btn_buscar);
			this.visualizar.Controls.Add(this.tbId);
			this.visualizar.Controls.Add(this.label6);
			this.visualizar.Controls.Add(this.label4);
			this.visualizar.Controls.Add(this.tbAno);
			this.visualizar.Controls.Add(this.label3);
			this.visualizar.Controls.Add(this.label2);
			this.visualizar.Controls.Add(this.tbTitulo);
			this.visualizar.Controls.Add(this.label1);
			this.visualizar.Location = new System.Drawing.Point(4, 22);
			this.visualizar.Name = "visualizar";
			this.visualizar.Padding = new System.Windows.Forms.Padding(3);
			this.visualizar.Size = new System.Drawing.Size(357, 300);
			this.visualizar.TabIndex = 1;
			this.visualizar.Text = "visualizar";
			this.visualizar.UseVisualStyleBackColor = true;
			// 
			// tbDesc
			// 
			this.tbDesc.Location = new System.Drawing.Point(6, 171);
			this.tbDesc.Name = "tbDesc";
			this.tbDesc.Size = new System.Drawing.Size(338, 83);
			this.tbDesc.TabIndex = 13;
			this.tbDesc.Text = "";
			// 
			// btnAtualiza
			// 
			this.btnAtualiza.Enabled = false;
			this.btnAtualiza.Location = new System.Drawing.Point(99, 271);
			this.btnAtualiza.Name = "btnAtualiza";
			this.btnAtualiza.Size = new System.Drawing.Size(75, 23);
			this.btnAtualiza.TabIndex = 12;
			this.btnAtualiza.Text = "atualizar";
			this.btnAtualiza.UseVisualStyleBackColor = true;
			this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
			// 
			// btnExclui
			// 
			this.btnExclui.Enabled = false;
			this.btnExclui.Location = new System.Drawing.Point(180, 271);
			this.btnExclui.Name = "btnExclui";
			this.btnExclui.Size = new System.Drawing.Size(75, 23);
			this.btnExclui.TabIndex = 11;
			this.btnExclui.Text = "excluir";
			this.btnExclui.UseVisualStyleBackColor = true;
			this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
			// 
			// btn_buscar
			// 
			this.btn_buscar.Location = new System.Drawing.Point(219, 23);
			this.btn_buscar.Name = "btn_buscar";
			this.btn_buscar.Size = new System.Drawing.Size(48, 23);
			this.btn_buscar.TabIndex = 10;
			this.btn_buscar.Text = "buscar";
			this.btn_buscar.UseVisualStyleBackColor = true;
			this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
			// 
			// tbId
			// 
			this.tbId.Location = new System.Drawing.Point(167, 25);
			this.tbId.Name = "tbId";
			this.tbId.Size = new System.Drawing.Size(45, 20);
			this.tbId.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(67, 28);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "insira o id da serie:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "descrição:";
			// 
			// tbAno
			// 
			this.tbAno.Location = new System.Drawing.Point(61, 121);
			this.tbAno.Name = "tbAno";
			this.tbAno.Size = new System.Drawing.Size(100, 20);
			this.tbAno.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "ano:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Genero:";
			// 
			// tbTitulo
			// 
			this.tbTitulo.Location = new System.Drawing.Point(61, 69);
			this.tbTitulo.Name = "tbTitulo";
			this.tbTitulo.Size = new System.Drawing.Size(100, 20);
			this.tbTitulo.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "titulo:";
			// 
			// adicionar
			// 
			this.adicionar.Controls.Add(this.tbNGen);
			this.adicionar.Controls.Add(this.button1);
			this.adicionar.Controls.Add(this.tbNdesc);
			this.adicionar.Controls.Add(this.label7);
			this.adicionar.Controls.Add(this.tbNano);
			this.adicionar.Controls.Add(this.label8);
			this.adicionar.Controls.Add(this.label9);
			this.adicionar.Controls.Add(this.tbNtitulo);
			this.adicionar.Controls.Add(this.label10);
			this.adicionar.Location = new System.Drawing.Point(4, 22);
			this.adicionar.Name = "adicionar";
			this.adicionar.Size = new System.Drawing.Size(357, 300);
			this.adicionar.TabIndex = 2;
			this.adicionar.Text = "adicionar";
			this.adicionar.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(120, 248);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 22;
			this.button1.Text = "adicionar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tbNdesc
			// 
			this.tbNdesc.Location = new System.Drawing.Point(17, 150);
			this.tbNdesc.Name = "tbNdesc";
			this.tbNdesc.Size = new System.Drawing.Size(330, 92);
			this.tbNdesc.TabIndex = 21;
			this.tbNdesc.Text = "";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(24, 134);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 13);
			this.label7.TabIndex = 20;
			this.label7.Text = "descrição:";
			// 
			// tbNano
			// 
			this.tbNano.Location = new System.Drawing.Point(65, 85);
			this.tbNano.Name = "tbNano";
			this.tbNano.Size = new System.Drawing.Size(100, 20);
			this.tbNano.TabIndex = 19;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(31, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(28, 13);
			this.label8.TabIndex = 18;
			this.label8.Text = "ano:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(14, 62);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(45, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "Genero:";
			// 
			// tbNtitulo
			// 
			this.tbNtitulo.Location = new System.Drawing.Point(65, 33);
			this.tbNtitulo.Name = "tbNtitulo";
			this.tbNtitulo.Size = new System.Drawing.Size(100, 20);
			this.tbNtitulo.TabIndex = 15;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(24, 36);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(32, 13);
			this.label10.TabIndex = 14;
			this.label10.Text = "titulo:";
			// 
			// tbNGen
			// 
			this.tbNGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tbNGen.FormattingEnabled = true;
			this.tbNGen.Location = new System.Drawing.Point(65, 59);
			this.tbNGen.Name = "tbNGen";
			this.tbNGen.Size = new System.Drawing.Size(100, 21);
			this.tbNGen.TabIndex = 23;
			// 
			// listaSeries
			// 
			this.listaSeries.HideSelection = false;
			this.listaSeries.Location = new System.Drawing.Point(90, 58);
			this.listaSeries.Name = "listaSeries";
			this.listaSeries.Size = new System.Drawing.Size(203, 236);
			this.listaSeries.TabIndex = 15;
			this.listaSeries.UseCompatibleStateImageBehavior = false;
			this.listaSeries.View = System.Windows.Forms.View.List;
			// 
			// tbGen
			// 
			this.tbGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tbGen.FormattingEnabled = true;
			this.tbGen.Location = new System.Drawing.Point(61, 95);
			this.tbGen.Name = "tbGen";
			this.tbGen.Size = new System.Drawing.Size(100, 21);
			this.tbGen.TabIndex = 14;
			// 
			// serieBindingSource
			// 
			this.serieBindingSource.DataSource = typeof(DIO.Series.Serie);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 392);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.Series.ResumeLayout(false);
			this.Series.PerformLayout();
			this.visualizar.ResumeLayout(false);
			this.visualizar.PerformLayout();
			this.adicionar.ResumeLayout(false);
			this.adicionar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.serieBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage Series;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TabPage visualizar;
		private System.Windows.Forms.Button btnAtualiza;
		private System.Windows.Forms.Button btnExclui;
		private System.Windows.Forms.Button btn_buscar;
		private System.Windows.Forms.TextBox tbId;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbAno;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbTitulo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage adicionar;
		private System.Windows.Forms.RichTextBox tbDesc;
		private System.Windows.Forms.RichTextBox tbNdesc;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbNano;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbNtitulo;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.BindingSource serieBindingSource;
		private System.Windows.Forms.ComboBox tbNGen;
		private System.Windows.Forms.ListView listaSeries;
		private System.Windows.Forms.ComboBox tbGen;
	}
}

