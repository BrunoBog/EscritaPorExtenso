﻿using EscritaPorExtenso.Lib;
using NUnit.Framework;

namespace EscritaPorExtenso.Testes
{
    [TestFixture]
    public class TesteDoConversor
    {
        [Test]
        public void DeveConverterNumeroUm()
        {
            Assert.AreEqual(new PrimeiraClasse(new Unidade(1)), ConversorDeNumeroParaClasses.Converter(1));
        }

        [Test]
        public void DeveConverterNumero9()
        {
            Assert.AreEqual(new PrimeiraClasse(new Unidade(9)), ConversorDeNumeroParaClasses.Converter(9));
        }

        [Test]
        public void DeveConverterUmaDezena()
        {
            Assert.AreEqual(new PrimeiraClasse(new Dezena(1)), ConversorDeNumeroParaClasses.Converter(10));
        }

        [Test]
        public void DeveConverterUmaDezenaComUnidade()
        {
            var convertido = ConversorDeNumeroParaClasses.Converter(13);
            
            Assert.AreEqual(new PrimeiraClasse(new Dezena(1, new Unidade(3))), convertido);
        }

        [Test]
        public void DeveConverterUmaCentena()
        {
            var convertido = ConversorDeNumeroParaClasses.Converter(200);
            
            Assert.AreEqual(new PrimeiraClasse(new Centena(2)), convertido);
        }

        [Test]
        public void DeveConverterUmaCentenaComDezenaEUnidade()
        {
            var convertido = ConversorDeNumeroParaClasses.Converter(666);

            Assert.AreEqual(new PrimeiraClasse(new Centena(6, new Dezena(6, new Unidade(6)))), convertido);
        }
    }
}