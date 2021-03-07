
using poc.DAL;
using poc.Model;

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
    }
}