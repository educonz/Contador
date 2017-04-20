using Contador.Contracts;
using Contador.Domain.TiposPagamento.Servicos;
using System.Web.Http;

namespace Contador.Web.Controllers
{
    [RoutePrefix("api/tipopagamento")]
    public class TipoPagamentoController : ApiController
    {
        private readonly ITipoPagamentoService _tipoPagamentoService;

        public TipoPagamentoController(ITipoPagamentoService tipoPagamentoService)
        {
            _tipoPagamentoService = tipoPagamentoService;
        }

        [HttpGet]
        public IHttpActionResult Get(long id)
        {
            return Ok(_tipoPagamentoService.Get(id));
        }

        [HttpDelete]
        public IHttpActionResult Delete(long id)
        {
            _tipoPagamentoService.Delete(id);
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult Post(TipoPagamentoDto tipoPagamentoDto)
        {
            return Ok(_tipoPagamentoService.Post(tipoPagamentoDto));
        }

        [HttpPut]
        public IHttpActionResult Put(TipoPagamentoDto tipoPagamentoDto)
        {
            return Ok(_tipoPagamentoService.Put(tipoPagamentoDto));
        }
    }
}
