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
//Empieso la prueba de las clases que yo arme, simplemente me aseguro que se crean correctamet dandeme el nombre//
        [Test]
        public void Dwarf_test()
        {   

            Dwarf dwarf_prueba= new Dwarf("Dwarf_prueba");  
            string Expected="Dwarf_prueba";
            
            Assert.AreEqual(Expected,dwarf_prueba.Name);
        }
        [Test]
        public void Archer_test()
        {   

            Archer Archer_prueba= new Archer("Archer_prueba");  
            string Expected="Archer_prueba";
            
            Assert.AreEqual(Expected,Archer_prueba.Name);
        }
        [Test]
        public void Knight_test()
        {   

            Knight Knight_prueba= new Knight("Knight_prueba");  
            string Expected="Knight_prueba";
            
            Assert.AreEqual(Expected,Knight_prueba.Name);
        }
        [Test]
        public void Wizard_test()
        {   

            Wizard Wizard_prueba= new Wizard("Wizard_prueba");  
            string Expected="Wizard_prueba";
            
            Assert.AreEqual(Expected,Wizard_prueba.Name);
        }
        [Test]
        public void Cyclops_test()
        {   
            Cyclops Cyclops_prueba= new Cyclops("Cyclops_prueba");  
            string Expected="Cyclops_prueba";
            
            Assert.AreEqual(Expected,Cyclops_prueba.Name);
        }
//Voy a probar las funciones de las clases, solo uso un Heroe y un Enemigo//
        [Test]
        public void Hero_Attack_Test()
        {   

            Archer Archer_prueba= new Archer("Archer_prueba");  
            int Expected=15;
            
            Assert.AreEqual(Expected,Archer_prueba.AttackValue);
        }
        [Test]
        public void Enemy_Attack_Test()
        {   

            Cyclops Cyclops_prueba= new Cyclops("Cyclops_prueba");  
            int Expected=25;
            
            Assert.AreEqual(Expected,Cyclops_prueba.AttackValue);
        }
//Testeo que el combate funcione, voy a crear un Knight que deve tener 20 puntos de atacke, ago que atake 5 veces a el Cyclope, si la vida de ciclop es 0 entoces funciona//
        [Test]
        public void Combat_Test()
        {   

            Cyclops Cyclops_prueba01= new Cyclops("Cyclops_prueba01");  
            Knight Knight_prueba01= new Knight("Knight_prueba01");
            Cyclops_prueba01.ReceiveAttack(Knight_prueba01.AttackValue);
            Cyclops_prueba01.ReceiveAttack(Knight_prueba01.AttackValue);
            Cyclops_prueba01.ReceiveAttack(Knight_prueba01.AttackValue);
            Cyclops_prueba01.ReceiveAttack(Knight_prueba01.AttackValue);
            Cyclops_prueba01.ReceiveAttack(Knight_prueba01.AttackValue);
            int Expected=0;
            Assert.AreEqual(Expected,Cyclops_prueba01.Health);
        }
//Pruebo que funcione la funcio de mostrar e incrementr VP//
        [Test]
        public void VP_test()
        {
            Knight Knight_prueba02= new Knight("Knight_prueba02");
            Cyclops Cyclops_prueba02= new Cyclops("Cyclops_prueba02");
            Knight_prueba02.Up_VP(Cyclops_prueba02.VP);
            int Expected=10;
            Assert.AreEqual(Expected,Knight_prueba02.VP);
        } 
        //Pruebo que funcion cuente la Defensa en el combate, y la funcion poner armas.//
        //voy armar un cyclope que viene por defecto con una Acha (axe, atak 25)//
        // Voy a armar un Knight que biene por defecto con un Escudo y Armadura (Def 25+14=39) //
        // Ago que el cyclop atake varias vese al Knight, como deveria tener mayor defensa, el Knight no deveria perder vida//
        [Test]
        public void Defense_Test()
        {
            Knight Knight_prueba03= new Knight("Knight_prueba03"); 
            Cyclops Cyclops_prueba03= new Cyclops("Cyclops_prueba03");
            Knight_prueba03.ReceiveAttack(Cyclops_prueba03.AttackValue);
            Knight_prueba03.ReceiveAttack(Cyclops_prueba03.AttackValue);
            Knight_prueba03.ReceiveAttack(Cyclops_prueba03.AttackValue);
            int Expected=100;
            Assert.AreEqual(Expected,Knight_prueba03.Health);

        }
        [Test]
        public void Encounter_Test()
        {
            /*Voy a realizar un test de Encounter donde Heroes y un Eneimgo pelean
            MI prueba para sertificar que ande es que uno de los heroes alla adquirido VP´s*/
            Knight Knight_prueba04= new Knight("Knight_prueba04"); 
            Knight Knight_prueba05= new Knight("Knight_prueba05"); 
            Knight Knight_prueba06= new Knight("Knight_prueba06"); 
            Cyclops Cyclops_prueba04= new Cyclops("Cyclops_prueba04");
            Encounter Encounter_Test= new Encounter();
            Encounter_Test.AddHero(Knight_prueba04);
            Encounter_Test.AddHero(Knight_prueba05);
            Encounter_Test.AddHero(Knight_prueba06);
            Encounter_Test.AddEnemy(Cyclops_prueba04);
            Encounter_Test.DoEncounter();
            int a=Knight_prueba04.VP;
            int b=Knight_prueba05.VP;
            int c=Knight_prueba06.VP;
            int Total=a+b+c;
            int Expected=10;
            Assert.AreEqual(Expected,Total);

        }
    
    
    
    
    
    }
}
