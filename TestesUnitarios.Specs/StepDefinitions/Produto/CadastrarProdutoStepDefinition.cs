using FluentAssertions;
using Moq;
using TechTalk.SpecFlow;
using TestesUnitarios.Application.Handlers.Produto;
using TestesUnitarios.CQS.Commands.Produto;
using TestesUnitarios.CQS.Dtos.Produto;
using TestesUnitarios.CQS.ViewModels;
using TestesUnitarios.CQS.ViewModels.Result;
using TestesUnitarios.Domain.Interfaces.Repositories;
using TestesUnitarios.Domain.Models;

namespace TestesUnitarios.Specs.StepDefinitions.Produto
{
    [Binding]
    public class CadastrarProdutoStepDefinition
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly CadastrarProdutoHandler _handler;

        public CadastrarProdutoStepDefinition(ScenarioContext scenarioContext)
        {
            var produtoRepositoryMock = new Mock<IProdutoRepository>();
            var retornoMetodoBuscarPorNomeEModelo = new List<ProdutoModel>()
            {
                new ProdutoModel("Produto dois", "Categoria dois", "Modelo azul") { Id = 2 }
            };

            produtoRepositoryMock.Setup(repo => repo
            .BuscarPorNomeEModelo("Produto um", "Modelo azul"))
                .Returns(retornoMetodoBuscarPorNomeEModelo.AsQueryable());

            _scenarioContext = scenarioContext;
            _handler = new CadastrarProdutoHandler(produtoRepositoryMock.Object);
        }

        [Scope(Feature = "Cadastrar um produto", Scenario = "Cadastra um produto inexistente na base"),
            Given("que ao receber um objeto de produto com os seus campos corretamente preenchidos")]
        public void ReceberObjetoComCamposCorretos()
        {
            var produtoComDadosCorretos = new CadastrarProdutoCommand(
                new CadastrarProdutoDto()
                {
                    Nome = "Produto um",
                    Categoria = "Categoria um",
                    Modelo = "Modelo azul"
                });

            _scenarioContext["Produto"] = produtoComDadosCorretos;
        }

        [When("a aplicacao invocar o metodo para cadastro de um produto")]
        public void InvocarMetodoParaCadastroDeUmProduto()
        {
            _scenarioContext["ResultadoCadastroDeProduto"] =
            _handler.Handle((CadastrarProdutoCommand)_scenarioContext["Produto"], new CancellationTokenSource(1000).Token);
        }

        [Then("a aplicacao deve retornar sucesso true com um objeto de retorno preenchido")]
        public void RetornarSucesso()
        {
            var retornoOperacao = (Task<ResultViewModel<ProdutoViewModel>>)_scenarioContext["ResultadoCadastroDeProduto"];
            retornoOperacao.Result.Result.Should().NotBeNull();
        }
    }
}