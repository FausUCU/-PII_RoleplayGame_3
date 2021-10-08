using System.Collections.Generic;
using System;
using System.Runtime;
using System.Linq;
using System.Text;

namespace RoleplayGame

{
    public class Encounter
    {
        protected List<Hero> Hero_team= new List<Hero>();  //Creo un lista vacia para poner a los Heroes que ban a prtisipar//
        protected List<Enemy> Enemy_team= new List<Enemy>(); //Creo un lista vacia para poner a los Enemigos que ban a prtisipar//

        public void AddHero(Hero hero ) //Funcion para agregar Heroe a la lista//
        {
            this.Hero_team.Add(hero); 
        }
        public void AddEnemy(Enemy enemy) // Funcion para agregar enemigo//
        {
            this.Enemy_team.Add(enemy);
        }
        public void RemvoeHero(Hero hero) // Funcion para sacar Heroe//
        {
            this.Hero_team.Remove(hero);
        }
        public void RemvoeEnemy(Enemy enemy) // Funcion para sacar enemigo//
        {
            this.Enemy_team.Remove(enemy);
        }
        public void printTeams()   //Imprimer los equipos//
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
        public void EnemyVsHero()  //Simula la primera parte del encuentro donde los enemigos atacan a los heroes// 
        {
            int target=0;
            foreach(Enemy e in this.Enemy_team)
            {
                Hero_team[target].ReceiveAttack(e.AttackValue);
                if(Hero_team[target].Health<1)
                {
                    this.RemvoeHero(Hero_team[target]);
                }
                target++;
                if(target>=this.Hero_team.Count())
                {
                    target=0;
                }
            }
        }
        public void HeroVsEnemy() //simula la segunda parte del encuentro donde los heroes atacan a los enemigos//
        {
            int target=0;
            int Last_Enemy=this.Enemy_team.Count()-1;
            foreach(Hero h in this.Hero_team)
            {
                while(target<= Last_Enemy)
                {
                    Enemy_team[target].ReceiveAttack(h.AttackValue);
                    if(Enemy_team[target].Health<1)
                    {
                        h.Up_VP(Enemy_team[target].VP);
                        this.RemvoeEnemy(Enemy_team[target]);
                        Last_Enemy=Last_Enemy-1;
                    }
                    target=target+1;
                }
                target=0;
                Last_Enemy=this.Enemy_team.Count()-1;
            }
        }

        public void DoEncounter() //La funcion para realizar el encuentro propiamente dicho//
        {
            //LAs funcione para remover VP, sacar a los heroes/ enemigos quue murieron e incremntar vida con los VP estan//
            //En los metodos de los encuentros individuales y de los personajes//
            string Result="";       //El resultado de el encuentro//
            bool seguirloop=true;   
            while(seguirloop)       //Loop para realizar el encuentro hasta que halla ganador//
            {
                this.EnemyVsHero(); //Uso mi funcion de ataque de enemigos//
                int N_Hero=this.Hero_team.Count(); //determino cuantos heroes quedan//
                if(N_Hero>0)        //Si quedan heroes realiza la funcion de aataque de los heroes, sino indico que ganron los enemigos//
                {
                    this.HeroVsEnemy();
                    int N_Enemy=this.Enemy_team.Count();
                    if (N_Enemy<1) //Pregunto si quedan enemigos, si no los quedadn ganaron los heroes//
                    {
                        seguirloop=false;
                        Result="Gano el equipo de Heroes";

                    }

                }
                else
                {
                    Result="Gano el equipo enemigo";
                    seguirloop=false;
                }
            }
            Console.WriteLine(Result); //impirime resultados de el encuentro//

        }

 
        
        
    }





}