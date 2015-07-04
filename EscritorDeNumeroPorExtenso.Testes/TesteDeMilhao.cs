using EscritorDeNumeroPorExtenso.ClassLibrary;
using NUnit.Framework;

namespace EscritorDeNumeroPorExtenso.Testes
{
    [TestFixture]
    public class TesteDeMilhao
    {
        [Test]
        public void DeveGerarNumeroUmMilhao()
        {
            Assert.AreEqual("um milh�o", new Milhao(new Unidade(1)).ToString());
        }

        [Test]
        public void DeveGerarNumeroDezMilh�es()
        {
            Assert.AreEqual("dez milh�es", new Milhao(new Dezena(1)).ToString());
        }

        [Test]
        public void DeveGerarNumeroUmMilhaoECemMil()
        {
            Assert.AreEqual("um milh�o e cem mil", new Milhao(new Unidade(1), new Milhar(new Centena(1))).ToString());
        }

        [Test]
        public void DeveGerarNumeroUmMilhaoECemMilEUm()
        {
            Assert.AreEqual("um milh�o e cem mil e um", new Milhao(new Unidade(1), new Milhar(new Centena(1), new PrimeiraClasse(new Unidade(1)))).ToString());
        }

        [Test]
        public void DeveGerarNumero1111e3()
        {
            Assert.AreEqual("um milh�o e cento e onze mil", new Milhao(new Unidade(1), new Milhar(new Centena(1, new Dezena(1, new Unidade(1))))).ToString());
        }
    }
}