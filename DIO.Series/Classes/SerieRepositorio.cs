using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	class SerieRepositorio : IRepositorio<Serie>
	{


		private List<Serie> listaSerie = new List<Serie>();

		public void Adiciona(Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public void Atualiza(int id, Serie objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaSerie[id].Excluir();
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public Serie RetornaItem(int id)
		{
			return listaSerie[id];
		}
	}
}
