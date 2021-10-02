using System.Collections.Generic;
namespace RoleplayGame
{
    public abstract class IMagicCharacter: ICharacter
    {
        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();
        /*coloque attackvalue y Defensevalue como una nueva instancia, porque es diferente de la original y  de lo contrario hubiera tenido que marcarla como abstracta en ICharacter e colocarla en cada clase */
        public new int AttackValue  
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
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalAttackItem)
                    {
                        value += (item as IMagicalAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }
        public new int DefenseValue
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
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalDefenseItem)
                    {
                        value += (item as IMagicalDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }

        void AddItem(IMagicalItem item)
        {
            this.magicalItems.Add(item);
        }

        void RemoveItem(IMagicalItem item)
        {
            this.magicalItems.Remove(item);
        }
    }
}
