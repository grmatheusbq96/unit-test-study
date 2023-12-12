using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TestesUnitarios.CQS.Commands.Produto;
using TestesUnitarios.CQS.Dtos.Produto;
using TestesUnitarios.CQS.Queries;
using TestesUnitarios.CQS.ViewModels;

namespace TestesUnitarios.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProdutoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        [HttpGet, Route("BuscarPorId")]
        [ProducesResponseType(typeof(ProdutoViewModel), (int)HttpStatusCode.OK)]
        public IActionResult BuscarProdutoPorId([FromQuery] int id)
        {
            return Ok(_mediator.Send(new BuscarProdutoPorIdQuery(id)).Result);
        }

        [HttpPost, Route("Cadastrar")]
        [ProducesResponseType(typeof(ProdutoViewModel), (int)HttpStatusCode.Created)]
        public IActionResult CadastrarProduto([FromBody] CadastrarProdutoDto dto)
        {
            return CreatedAtAction(nameof(BuscarProdutoPorId), _mediator.Send(new CadastrarProdutoCommand(dto)).Result);
        }

        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}