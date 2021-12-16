using MediatR;
using Microsoft.AspNetCore.Mvc;
using Plano.Carreira.CQRS.Handles.Referencias;

namespace Plano.Carreira.API.Controllers
{
    [ApiController]
    [Route("referencia")]
    public class ReferenciaController : Controller
    {
        private readonly IMediator _mediatr;

        public ReferenciaController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet]
        [Route("preencher")]
        public async Task<IActionResult> Preencher(PreencherReferenciaRequest model)
            => Json(await _mediatr.Send(model));
    }
}
