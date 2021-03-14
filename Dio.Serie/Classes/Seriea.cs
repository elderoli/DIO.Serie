using System;

namespace Dio.Seriea.Classes
{
    public class Serie : EntidadeBase
    {
        //atributos
        private Genero Genero {get; set; }
        private string Titulo {get; set; }
        private string Descricao {get; set; }
        private int Ano {get; set; }
        private bool Excluido {get; set; }

        //metodos

        public Serie (int id, Genero genero, string titulo, string descricao, int ano)
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
        //Environment.Newline https://docs.microsoft.com/en/us/dotnet/api/system.environment.new

        string retorno = "";
        retorno += "Gênero: " + this.Genero + Environment.NewLine;
        retorno += "Titulo: " + this.Titulo + Environment.NewLine;
        retorno += "Descricao: " + this.Descricao + Environment.NewLine;
        retorno += "Ano de inicio: " + this.Ano + Environment.NewLine;
        retorno += "Excluido: " + this.Excluido;
        return retorno;
        }
        public string retornaTitulo()
        {
            return this.Titulo;

        }
        public int retornaId()
        {
            return this.Id;

        }        
        public bool retornaExcluido()
        {
            return this.Excluido;
        } 

        public void Excluir()
        {
            this.Excluido = true;
        }


    }
}