
using poc.DAL;
using poc.Model;
using System.Collections.Generic;
using System.Linq;

namespace poc.BLL
{
    public class FuncionarioBLL
    {
        private readonly StoreContext _context;

public FuncionarioBLL(StoreContext context){
    this._context = context;
}

        public string HelloWorld()
        {
            return "Hello World";
        }

        public bool create(Funcionario func){
            this._context.Add(func);
            int result =  this._context.SaveChanges();
            bool sucess = result > 0;
            return sucess;
        }

        public Funcionario getById(int id) {

            var funcionario = this._context.Funcionarios.FirstOrDefault(x => x.Id == id);
            return funcionario;
        }

        public List<Funcionario> getAll()
        {

            var funcionario = this._context.Funcionarios.Select(x => new Funcionario {
                Id = x.Id,
                Nome = x.Nome,
                Endereco = x.Endereco,
                Telefone = x.Telefone,
                DataContratacao = x.DataContratacao
            }).ToList();
            return funcionario;
        }
    }
}