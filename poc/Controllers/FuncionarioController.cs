using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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

        [HttpGet]
        [Route("get/{id}")]
        public string get([FromRoute]int id){
             return JsonConvert.SerializeObject(service.getById(id));
        }

        [HttpGet]
        [Route("get")]
        public string get() {
            return JsonConvert.SerializeObject(service.getAll());
        }
    }
}
