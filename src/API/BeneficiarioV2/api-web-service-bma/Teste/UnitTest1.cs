using api_web_service_bma.Controllers;
using api_web_service_bma.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Teste
{
    [TestFixture]
    public class BeneficiarioTeste
    {
        private AppDbContext _dbContext;
        private BeneficiarioController _controller;

        [SetUp]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase").Options;
             _dbContext = new AppDbContext(options);
            _controller = new BeneficiarioController(_dbContext);
        }

        [TearDown]
        public void TearDown()
        {
            _dbContext.Database.EnsureDeleted();
            _dbContext.Dispose();
        }

        [Test]
        public void GetById()
        {
            int id = 3;
            var resultado = _controller.GetById(id);
            Assert.IsInstanceOf<ActionResult>(resultado.Result);
        }

        [Test]
        public void GetAll()
        {
            var resultado = _controller.GetAll();
            Assert.IsInstanceOf<ActionResult>(resultado.Result);
        }

        [Test]
        public void Create()
        {
            Beneficiario beneficiario = new Beneficiario();
            beneficiario.Nome = "Amanda Paloma";
            beneficiario.Cpf = "111.111.111-11";
            beneficiario.Data_nascimento = "27/07/2000";
            beneficiario.Email = "amanda@gmail.com.br";
            beneficiario.Telefone = "33624940";
            beneficiario.Cep = "32223540";
            beneficiario.Logradouro = "Rua Alguarve";
            beneficiario.Numero = "129";
            beneficiario.Complemento = "Casa";
            beneficiario.Bairro = "Amazonas";
            beneficiario.Cidade = "Contagem";
            beneficiario.Uf = "MG";
            beneficiario.Situacao = "Casada";
            beneficiario.Perfil_acesso = "ativo";
            beneficiario.beneficio_cesta_basica = "ativo";
            beneficiario.beneficio_cesta_verde = "ativo";

            var resultado = _controller.Create(beneficiario);
            Assert.IsInstanceOf<ActionResult>(resultado.Result);
        }

        [Test]
        public void Update()
        {
            int id = 3;
            Beneficiario beneficiario = new Beneficiario();
            beneficiario.Id = 3;

            var resultado = _controller.Update(id, beneficiario);
            Assert.IsInstanceOf<ActionResult>(resultado.Result);
        }

        [Test]
        public void Delete()
        {
            int id = 3;
            var resultado = _controller.Delete(id);
            Assert.IsInstanceOf<ActionResult>(resultado.Result);
        }
    }
}