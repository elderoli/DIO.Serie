using System;
using System.Collections.Generic;
using Dio.Seriea.Interfaces;

namespace Dio.Seriea.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
            private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
           listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
            //implementar envio de e-mail aqui
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornarPorId(int id)
        {
            return listaSerie[id];
        }
    }
}