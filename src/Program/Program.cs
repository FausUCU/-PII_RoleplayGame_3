using System;
using RoleplayGame;
using System.Collections;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
           /* SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.AddMagicItem(book);/*cambio a AddMagicItem proque distingui en la classe IMagicalcharacter 
            el agregar o remover iteams magicos o normales */
            /*
            Dwarf gimli = new Dwarf("Gimli");

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Someone cured Gimli. Gimli now has ❤️ {gimli.Health}");
            */
            Knight Green=new Knight("Green");
            Dwarf  Brown=new Dwarf("Brown");
            Archer Blue=new Archer("Blue");
            Cyclops Cyclops01= new Cyclops("Cyclops01");
            Cyclops Cyclops02= new Cyclops("Cyclops02");
            Cyclops Cyclops03= new Cyclops("Cyclops03");
            ArrayList Team_H= new ArrayList();
            ArrayList Team_E= new ArrayList();
            Team_H.Add(Green);
            Team_H.Add(Blue);
            Team_H.Add(Brown);
            Team_E.Add(Cyclops01);
            Team_E.Add(Cyclops02);
            Team_E.Add(Cyclops03);
            




        }
    }
}
