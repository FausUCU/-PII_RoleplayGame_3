using System.Collections.Generic;
using System;
using System.Runtime;
using System.Linq;
using System.Text;

namespace RoleplayGame

{
    public class Encounter
    {
        Hero[] Team_H;
        Enemy[] Team_E;


        public void AddHero(Hero hero )
        {
            this.Team_H[^1]=hero; // Estos " ^1 " significa el ultimo elemento del array//
        }
        public void AddEnemy(Enemy enemy)
        {
            this.Team_E[^1]=enemy;
        }

        public void Fight()
        {
            bool ContinueLoop=true; //Determina si continuo la battala//
            while (ContinueLoop)
           {
                int Enemy_numbers=this.Team_E.Length; //Determina el numero de Enemigo en el convate//   
                int Hero_numbers=this.Team_H.Length;  //Determina el numero de Heroes en el convate//
                int attacked=Hero_numbers;
                foreach (Enemy i in this.Team_E)
                {
                    attacked=attacked-1;         //Determina a que heroe attaka//
                    this.Team_H[attacked].ReceiveAttack(i.AttackValue);
                    int Hero_life=this.Team_H[attacked].Health;
                    if (Hero_life<1)
                    {
                       Array.Clear(this.Team_H,attacked,1);
                    }

                }
                if (this.Team_H.Length>0)
                {
                    
                }
                else
                {
                    String Encounter_Result="Enemy";
                }


               
                ///ESTOY CANSADO, PERO CREO QUE HAY QUE CAMBIAR ATTAKED A UNO PARA HERO Y OTRO PARA VILLAN///
              
                
            }

        }
        
    }





}