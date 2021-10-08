using System.Collections.Generic;
namespace RoleplayGame
{
    public class Cyclops: Enemy
    {
        public Cyclops(string name)
        {
            this.Name=name;
            this.VP=10; 
            this.AddItem(new Axe());

        }

    }
}