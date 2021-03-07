using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using poc.BLL;
using poc.DAL;
using poc.Model;

namespace poc.Controllers
{
    [ApiController]
    [Route("funcionario")]
    public class FuncionarioController : ControllerBase
    {
        private readonly StoreContext _context;
        FuncionarioBLL service;

        public FuncionarioController(StoreContext context, ILogger<FuncionarioController> logger){
            this._context = context;
            service = new FuncionarioBLL(this._context);
            _logger = logger;
        }

        private readonly ILogger<FuncionarioController> _logger;
       

        [HttpGet]
        [Route("greetings")]
        public string greetings(){
            return service.HelloWorld();
        }

        [HttpPost]
        [Route("create")]
        public string create([FromBody]Funcionario funcionario){
             return service.create(funcionario) ? "Inserido com sucesso" : "Deu ruim aí tio";
        }
    }
}
