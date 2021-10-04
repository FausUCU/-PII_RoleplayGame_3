using System.Collections.Generic;
using System;
using System.Runtime;
using System.Linq;
using System.Text;

namespace RoleplayGame

{
    public class Encounter
    {
        protected List<Hero> Hero_team= new List<Hero>(); 
        protected List<Enemy> Enemy_team= new List<Enemy>();

        public void AddHero(Hero hero )
        {
            this.Hero_team.Add(hero); // Estos " ^1 " significa el ultimo elemento del array//
        }
        public void AddEnemy(Enemy enemy)
        {
            this.Enemy_team.Add(enemy);
        }
        public void printTeams()
        {   
            Console.WriteLine("=======Los Heroes son============");
            foreach (Hero i in this.Hero_team)
            {   
                Console.WriteLine(i.Name);  
            }
            Console.WriteLine("=======Los Enemigos son============");
            foreach (Enemy i in this.Enemy_team)
            {
                Console.WriteLine(i.Name);
            }
        }
        public void Fight()
        {   String Encounter_Result=""; //Resultado del combate
            bool ContinueLoop=true; //Determina si continuo la battala//
            while (ContinueLoop)
           {
                int Enemy_numbers=this.Enemy_team.Count(); //Determina el numero de Enemigo en el convate//   
                int Hero_numbers=this.Hero_team.Count();  //Determina el numero de Heroes en el convate//
                int attacked_H=Hero_numbers;          // Uso esto para ir determinando el Hero que deve atacar el Enemigo, como cada enemigo attacka a cada hero determino como se reduce este numero en el loop del encuento
                int attacked_E=Enemy_numbers-1;        // Uso esto para ir determinando el Enemigo que deve atacar el Heroe, como todos los heroes empiezan attacando a el mismo enemigo, incialiso con -1 para atacar al ultimo del Array y lo redusco en el loop
                foreach (Enemy i in this.Enemy_team)
                {   
                    if (attacked_H>0)
                    {
                        attacked_H=attacked_H-1;        //Determina a que heroe attaka y lo reduce para que ataque al siguiente//
                    }
                    else
                    {
                        attacked_H=Hero_numbers;        //buelbe al primer herue atacado cuando ataca al ultimo
                    }
                    this.Hero_team[attacked_H].ReceiveAttack(i.AttackValue);
                    int Hero_life=this.Hero_team[attacked_H].Health;
                    if (Hero_life<1)
                    {
                        this.Hero_team.RemoveAt(attacked_H);  //Elimina de la lista a los heures vencidos//
                            
                    }

                }
                if (this.Hero_team.Count()>0)               //comprueba que siga habiendo heoes para peliar
                {
                    foreach (Hero h in this.Hero_team)
                    {
                        this.Enemy_team[attacked_E].ReceiveAttack(h.AttackValue);
                        int Enemy_life= this.Enemy_team[attacked_E].Health;
                        if (Enemy_life<1)
                        {
                            int VP_gain=this.Enemy_team[attacked_E].VP;
                            h.Up_VP(VP_gain);
                            this.Enemy_team.RemoveAt(attacked_E);
                            attacked_E--;
                        }
                        
                    }
                    if(this.Enemy_team.Count()<1)
                    {
                        Encounter_Result="Heroes";
                        ContinueLoop=false;
                    }                
                }
                else
                {
                    Encounter_Result="Enemies";
                    ContinueLoop=false;

                }
                   
            }
            Console.WriteLine($"Los {Encounter_Result} Ganaron el Encuentro");

        }
        
    }





}