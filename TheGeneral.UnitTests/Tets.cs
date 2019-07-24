using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGeneral.UnitTests
{
    [TestFixture]
    public class Tets
    {
        General general;

        [SetUp]
        public void SetUp()
        {
            general = new General();
        }

        [Test]
        [TestCase(10, 1)]
        [TestCase(6, 1)]
        [TestCase(-10, -1)]
        [TestCase(0, 13)]
        [TestCase(1, -2)]
        public void Successfull_Attack_Inside_Board_Dimensions(int a, int b)
        {
            bool successfullAttack = general.IsAttackSuccesful(a, b);

            Assert.That(successfullAttack, Is.True, "Attack was unsuccessfull!");
        }

        [Test]
        [TestCase(11, 1)]
        [TestCase(5, 1)]
        [TestCase(-11, -1)]
        [TestCase(-1, 13)]
        [TestCase(0, -2)]
        public void Unsucessfull_Attack_Outside_Board_Dimensions(int a, int b)
        {
            bool successfullAttack = general.IsAttackSuccesful(a, b);

            Assert.That(successfullAttack, Is.False, "Attack was not supposed to be successfull!");
        }

        [Test]
        [TestCase(11, 1)]
        [TestCase(5, 1)]
        [TestCase(-11, -1)]
        [TestCase(-1, 13)]
        [TestCase(-1, -21)]
        public void Successfull_Defence_Inside_Board_Dimensions(int a, int b)
        {
            bool successfullDefence = general.IsDefenceSuccesful(a, b);

            Assert.That(successfullDefence, Is.True, "Defence was unsuccessfull!");
        }

        [Test]
        [TestCase(10, 1)]
        [TestCase(6, 1)]
        [TestCase(-10, -1)]
        [TestCase(0, 13)]
        [TestCase(1, -2)]
        public void Unsucessfull_Defence_Outside_Board_Dimensions(int a, int b)
        {
            bool successfullDefence = general.IsDefenceSuccesful(a, b);

            Assert.That(successfullDefence, Is.False, "Defence was not supposed to be successfull!");
        }

        [Test]
        [TestCase(201, 299)]
        [TestCase(200, 500)]
        public void Invalid_Input_Outside_Board_Dimensions_Exception_Expected(int a, int b)
        {

            Exception ex = Assert.Throws<Exception>(() => general.IsDefenceSuccesful(a, b));

        }
        
    }
}
