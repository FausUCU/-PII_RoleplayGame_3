using System;
using RoleplayGame;
using System.Collections;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.AddMagicItem(book);/*cambio a AddMagicItem proque distingui en la classe IMagicalcharacter 
            el agregar o remover iteams magicos o normales */
            
            Dwarf gimli = new Dwarf("Gimli");

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Someone cured Gimli. Gimli now has ❤️ {gimli.Health}"); 
 /*=========================Mi Codigo=========================================*/ 
 // Creo 3 Heroes y 3 Enemigos//          
            Knight Green=new Knight("Green");
            Dwarf  Brown=new Dwarf("Brown");
            Archer Blue=new Archer("Blue");
            Cyclops Cyclops01= new Cyclops("Cyclops01");
            Cyclops Cyclops02= new Cyclops("Cyclops02");
            Cyclops Cyclops03= new Cyclops("Cyclops03");
            //Creo el encuentro//
            Encounter Pelea01= new Encounter();
            //Agrego los Heroes y enemigos al encuentro//
            Pelea01.AddHero(Green);
            Pelea01.AddHero(Brown);
            Pelea01.AddHero(Blue);
            Pelea01.AddEnemy(Cyclops01);
            Pelea01.AddEnemy(Cyclops02);
            Pelea01.AddEnemy(Cyclops03);
            //imprimo los equipos//
            Pelea01.printTeams();
            //Realizo el encuentro//
            Pelea01.DoEncounter();








        }
    }
}
