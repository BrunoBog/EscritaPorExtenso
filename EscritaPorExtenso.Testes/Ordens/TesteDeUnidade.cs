﻿using EscritaPorExtenso.Core;
using NUnit.Framework;

namespace EscritaPorExtenso.Testes.Ordens
{
    [TestFixture]
    public class TesteDeUnidade
    {
        [Test]
        public void DeveGerarNumeroPorExtensoDeUnidade()
        {
            Assert.AreEqual("um", new Unidade(1).ToString());
        }
    }
}
