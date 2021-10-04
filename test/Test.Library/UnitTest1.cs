using System;
using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Character_ShouldCreatCH()
        {   

            Dwarf dwarf_prueba= new Dwarf("Dearf_prueba");  
            string Expected="Dearf_prueba";
            
            Assert.AreEqual(Expected,dwarf_prueba.Name);
        }
    }
}
