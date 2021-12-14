using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIO.Series
{
	public partial class Form1 : Form
	{
		SerieRepositorio repositorio = new SerieRepositorio();

		public Form1()
		{
			InitializeComponent();
			tbGen.DataSource = Enum.GetNames(typeof(Genero));
			tbNGen.DataSource = Enum.GetNames(typeof(Genero));
		}


		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				Genero g = (Genero)tbNGen.SelectedIndex+1;
				Serie s = new Serie(repositorio.ProximoId(), g, tbNtitulo.Text, tbNdesc.Text, int.Parse(tbNano.Text));
				repositorio.Adiciona(s);
				MessageBox.Show("Série cadastrada com sucesso");
				Limpa();
			}
			catch
			{
				MessageBox.Show("Erro! Digite um valor valido");
			}
		}

		private void Series_Enter(object sender, EventArgs e)
		{
			listaSeries.Clear();
			foreach (Serie s in repositorio.Lista())
			{
				listaSeries.Items.Add(s.Id+" - "+s.Titulo+( s.Excluido? " *excluido* ":""));
			}
			
		}
		
		private void btn_buscar_Click(object sender, EventArgs e)
		{
			try
			{
				Serie serie = repositorio.RetornaItem(int.Parse(tbId.Text));
				tbTitulo.Text = serie.Titulo;
				tbAno.Text = serie.Ano.ToString();
				tbDesc.Text = serie.Descricao;
				tbGen.Text =  serie.Genero.ToString();

				btnAtualiza.Enabled = true;
				btnExclui.Enabled = true;
			}
			catch 
			{
				MessageBox.Show("Erro! Digite um valor valido" );
			}

		}

		private void btnAtualiza_Click(object sender, EventArgs e)
		{
			try
			{
				Genero g = (Genero)tbGen.SelectedIndex;
				Serie s = new Serie(int.Parse(tbId.Text), g, tbTitulo.Text, tbDesc.Text, int.Parse(tbAno.Text));
				repositorio.Atualiza(int.Parse(tbId.Text), s);
				MessageBox.Show("Série atualizada com sucesso");
			}
			catch
			{
				MessageBox.Show("Erro! Digite um valor valido");
			}
		}

		private void btnExclui_Click(object sender, EventArgs e)
		{
			try
			{
				repositorio.Exclui(int.Parse(tbId.Text));
			}
			catch 
			{
				MessageBox.Show("Erro! Digite um valor valido");
			}
			Limpa();
		}

		private void Limpa()
		{
			tbAno.Clear();
			tbDesc.Clear();
			tbGen.SelectedIndex = -1;
			tbNano.Clear();
			tbNdesc.Clear();
			tbNGen.SelectedIndex = -1;
			tbNtitulo.Clear();
			tbTitulo.Clear();
			tbId.Clear();

			btnAtualiza.Enabled = false;
			btnExclui.Enabled = false;
		}
	}
}
