using Microsoft.AspNetCore.Mvc;
using System.Net;
using TaxaJuros.Api.Controllers.Base;
using TaxaJuros.Business.Interface;
using TaxaJuros.CrossCutting.DTO.Taxa;
using TaxaJuros.Domain;

namespace TaxaJuros.Controllers
{
    [Route("api/v1/taxaJuros")]
    public class TaxaController : BaseController<Taxa, TaxaDTO>
    {
        public TaxaController(ITaxaService taxaService) : base(taxaService)
        {
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        public new ActionResult GetAll()
        {
            return base.GetAll();
        }
    }
}