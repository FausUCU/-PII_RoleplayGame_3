using System.Collections.Generic;
namespace RoleplayGame
{
    public abstract class Hero: ICharacter
    {   
        private int vp=0;
        public int VP
        {
            get
            {
                return this.vp;
            }
            set
            {
                this.vp=value;
            }
        }

        public void Up_VP(int Vp_enemy)
        {
            this.VP=VP+Vp_enemy;
        }
        

    }

}