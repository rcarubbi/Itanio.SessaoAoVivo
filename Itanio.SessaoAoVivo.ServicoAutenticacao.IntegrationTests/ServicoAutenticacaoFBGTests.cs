using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Itanio.SessaoAoVivo.Dominio;

namespace Itanio.SessaoAoVivo.ServicoAutenticacao.IntegrationTests
{
    [TestClass]
    public class ServicoAutenticacaoFBGTests
    {
        [TestMethod]
        public void Autenticacao_FBG_OK()
        {
            var usuario = Dado_Usuario_Valido();
            var resultado = Quando_Autenticar(usuario);
            resultado.Should().BeTrue();
        }

        private bool Quando_Autenticar(Usuario usuario)
        {
            IServicoAutenticacao autenticacao = new ServicoAutenticacaoFBG.ServicoAutenticacaoFBG();
            return autenticacao.Autenticar(usuario);
        }

        private Usuario Dado_Usuario_Valido()
        {
            return new Usuario {
                Email = "zane@itanio.com.br",
                Senha = "123mudar"
            };
        }
    }
}
