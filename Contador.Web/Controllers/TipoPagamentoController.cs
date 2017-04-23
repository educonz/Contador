using Base.Core.Logger;
using Contador.Contracts;
using Contador.Domain.TiposPagamento.Servicos;
using System.Reflection;
using System.Web.Http;

namespace Contador.Web.Controllers
{
    [RoutePrefix("api/tipopagamento")]
    public class TipoPagamentoController : ApiController
    {
        private readonly ITipoPagamentoService _tipoPagamentoService;
        private readonly ILog _log;

        public TipoPagamentoController(ITipoPagamentoService tipoPagamentoService, ILog log)
        {
            _tipoPagamentoService = tipoPagamentoService;
            _log = log;
            _log.SetMethodLog(MethodBase.GetCurrentMethod().DeclaringType);
        }

        [HttpGet]
        public IHttpActionResult Get(long id)
        {
            _log.Error("Teste");

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
