using System.Collections.Generic;
namespace RoleplayGame
{
    public abstract class ICharacter
    {
        private int health = 100;

        private List<IItem> items = new List<IItem>();
        string Name { get; set; }

        int Health { get; }

        int AttackValue { get; }

        int DefenseValue { get; }

        void AddItem(IItem item);

        void RemoveItem(IItem item);

        void Cure();

        void ReceiveAttack(int power);
    }
}