

using System;

namespace poc.Model{

    public class Funcionario{
        public int Id {get;set;}
        public string Nome{get;set;}
        public string Telefone { get; set; }
        public string Endereco { get; set; } 

        public DateTime DataContratacao {get;set;}

        public Funcionario() {
        
        }

    public Funcionario(string Nome, string Telefone, string Endereco, DateTime DataContratacao){
        this.Endereco = Endereco;
        this.Nome = Nome;
        this.Telefone = Telefone;
        this.DataContratacao = DataContratacao;
    }

    }
}