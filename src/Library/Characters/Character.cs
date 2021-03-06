using System.Collections.Generic;
namespace RoleplayGame
{ /*Converti Las interfaces Icharacter e IMagicCharacter en classes abstractas en lugar de interfaces para 
poder implementarlas y porque me ahorra codigo */
    public abstract class Character
    {   /*Le agregue la etiqueta publica todas las caracteristicas de esta clase abstracta para que las otras clases pudieran tener acceso*/
        private int health = 100;

        public List<IItem> items = new List<IItem>();
        public string Name { get; set; }  
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }
        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }
        
        /*public void RemoveItem(IItem item)
        {   
            var b=item.GetType();
            foreach(var a in this.items)
            {
                if(object.ReferenceEquals(a,b.GetType()))
                {
                    this.items.Remove(a);
                }
            }
        }*/

        public void Cure()
        {
        this.Health = 100;
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }
    }
}