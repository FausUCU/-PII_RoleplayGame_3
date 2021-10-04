using System.Collections.Generic;
using System;
using System.Runtime;
using System.Linq;
using System.Text;

namespace RoleplayGame

{
    public class Encounter
    {
        Hero[] Team_H; ///Halgo anda mal aka//
        Enemy[] Team_E;

        public void printTeams()
        {   
            foreach (Hero i in this.Team_H)
            {   
                Console.WriteLine(i.Name);  
            }
            foreach (Enemy i in this.Team_E)
            {
                Console.WriteLine(i.Name);
            }

        }
        public void AddHero(Hero hero )
        {
            this.Team_H[^1]=hero; // Estos " ^1 " significa el ultimo elemento del array//
        }
        public void AddEnemy(Enemy enemy)
        {
            this.Team_E[^1]=enemy;
        }

        public void Fight()
        {   String Encounter_Result=""; //Resultado del combate
            bool ContinueLoop=true; //Determina si continuo la battala//
            while (ContinueLoop)
           {
                int Enemy_numbers=this.Team_E.Length; //Determina el numero de Enemigo en el convate//   
                int Hero_numbers=this.Team_H.Length;  //Determina el numero de Heroes en el convate//
                int attacked_H=Hero_numbers;          // Uso esto para ir determinando el Hero que deve atacar el Enemigo, como cada enemigo attacka a cada hero determino como se reduce este numero en el loop del encuento
                int attacked_E=Enemy_numbers-1;        // Uso esto para ir determinando el Enemigo que deve atacar el Heroe, como todos los heroes empiezan attacando a el mismo enemigo, incialiso con -1 para atacar al ultimo del Array y lo redusco en el loop
                foreach (Enemy i in this.Team_E)
                {   
                    if (attacked_H>0)
                    {
                        attacked_H=attacked_H-1;        //Determina a que heroe attaka y lo reduce para que ataque al siguiente//
                    }
                    else
                    {
                        attacked_H=Hero_numbers;        //buelbe al primer herue atacado cuando ataca al ultimo
                    }
                    this.Team_H[attacked_H].ReceiveAttack(i.AttackValue);
                    int Hero_life=this.Team_H[attacked_H].Health;
                    if (Hero_life<1)
                    {
                       Array.Clear(this.Team_H,attacked_H,1);       //Elimina de la lista a los heures vencidos//
                    }

                }
                if (this.Team_H.Length>0)               //comprueba que siga habiendo heoes para peliar
                {
                    foreach (Hero h in this.Team_H)
                    {
                        this.Team_E[attacked_E].ReceiveAttack(h.AttackValue);
                        int Enemy_life= this.Team_E[attacked_E].Health;
                        if (Enemy_life<1)
                        {
                            int VP_gain=this.Team_E[attacked_E].VP;
                            h.Up_VP(VP_gain);
                            Array.Clear(this.Team_E,attacked_E,1);
                            attacked_E--;
                        }
                        
                    }
                    if(this.Team_E.Length<1)
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