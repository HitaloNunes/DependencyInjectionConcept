using DependencyInjectionConcept.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionConcept.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InjectionController : ControllerBase
    {
        private readonly ISaudacoesService _saudacoesService;
        public InjectionController(ISaudacoesService saudacoesService)
        {
            _saudacoesService = saudacoesService;
        }
        [HttpGet]
        public string Saudacoes (string Nome)
        {
            return _saudacoesService.Saudacao(Nome);
        }
    }
}
