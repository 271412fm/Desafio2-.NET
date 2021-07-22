using System;
using System.Collections.Generic;
using DigitalInnovationOne.Series.Interfaces;


namespace DigitalInnovationOne.Series
{
    public class SerieRepositorio : iRepositorio<Serie>
    {
        private List<Serie> ListaSerie = new List<Serie>();
        public void AtualizaSerie(int id, Serie objeto)
        {
            ListaSerie[id] = objeto;
        }

        public void Insere(Serie objeto)
        {
            ListaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return ListaSerie;
        }

        public int PróximoId()
        {
            return ListaSerie.Count;
        }

        public void Remove(int id)
        {
            ListaSerie[id].Excluir();

        }
        public Serie retornoPorId(int id)
        {
            return ListaSerie[id];
        }
    }
}

