using System;

namespace DigitalInnovationOne.Series
{
    public class Serie : EntidadeBase
    {
        //Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        //Métodos
        public Serie(int Id, Genero genero, string Titulo, string Descricao, int ano, string titulo, string descricao)
        {
            this.Id = Id;
            this.Genero = genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public Serie(int Id, Genero genero, string titulo, int ano, string descricao)
        {
            this.Id = Id;
            Genero = genero;
            Titulo = titulo;
            Ano = ano;
            Descricao = descricao;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;

        }

        public string RetornaTitulo()
        {
            return this.Titulo;
        }

        public int RetornaID()
        {
            return this.Id;

        }
        public void Excluir()
        {
            this.Excluido = true;
        }

        
        
    }
}