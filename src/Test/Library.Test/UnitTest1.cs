using NUnit.Framework;
using System;
using RoleplayGame;


namespace Program
{
    [TestFixture]
    public class OurTests
    {        
        [Test]
        public void TestDwarf()
        {
            Dwarf argo = new Dwarf("argo");
            argo.Axe = new Axe();
            Axe hacha = new Axe();
            int actual = argo.AttackValue;
            int expected = hacha.AttackValue;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestKnight()
        {
            Knight viking = new Knight("viking");
            viking.Shield = new Shield();
            viking.Armor = new Armor();
            Shield escudo = new Shield();
            Armor dragon = new Armor();
            int actual = viking.DefenseValue;
            int expected = dragon.DefenseValue+ escudo.DefenseValue;
            Assert.AreEqual(expected, actual);
        }


    }
}