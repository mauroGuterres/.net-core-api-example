

namespace poc.Model{

    public class Funcionario{
        public int Id {get;set;}
        public string Nome{get;set;}
        public string Telefone { get; set; }
        public string Endereco { get; set; } 

    public Funcionario(string Nome, string Telefone, string Endereco){
        this.Endereco = Endereco;
        this.Nome = Nome;
        this.Telefone = Telefone;
    }

    }
}