using System;
using NUnit.Framework;
using UnitTest;

namespace UnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void MocDloheJmeno()
        {
            //není kontrola správný exception
            Assert.Throws<Exception>(() =>
            {
                new HerniPostava("tohlejemocdlouhe");
            });
        }

        [Test]
        public void SpravneJmeno()
        {
            Assert.DoesNotThrow(() =>
            {
                new HerniPostava("kratke");
            });
        }

        [Test]
        public void PocatecniLevel()
        {
            Assert.IsTrue(new HerniPostava("Luna").Level == 1);
        }

        [Test]
        public void PocatecniX()
        {
            Assert.IsTrue(new HerniPostava("Misha").X == 0);
        }

        [Test]
        public void PocatecniY()
        {
            Assert.IsTrue(new HerniPostava("Muffin").Y == 0);
        }

        [Test]
        public void ZmenaSouradnic()
        {
            HerniPostava postava = new HerniPostava("Oliver");
            double ocekavanyX = 69;
            double ocekavanyY = 420;
            postava.ZmenaPozice(ocekavanyX, ocekavanyY);
            Assert.IsTrue(postava.X == ocekavanyX && postava.Y == ocekavanyY);
        }
    }
}