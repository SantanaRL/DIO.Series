using System;

namespace DIO.Series
{
	class Serie : EntidadeBase
	{
		// Atributos
		public Genero Genero { get;  }
		public string Titulo { get; }
		public string Descricao { get; }
		public int Ano { get; }
		public bool Excluido { get; protected set; }

		// Métodos
		public Serie(int id, Genero genero, string titulo, string descricao, int ano)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
			this.Excluido = false;
		}

		public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
			string retorno = "";
			retorno += "Gênero: " + this.Genero + Environment.NewLine;
			retorno += "Titulo: " + this.Titulo + Environment.NewLine;
			retorno += "Descrição: " + this.Descricao + Environment.NewLine;
			retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
			retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

		
		public bool retornaExcluido()
		{
			return this.Excluido;
		}
		public void Excluir()
		{
			Excluido = true;
		}
	}
}
