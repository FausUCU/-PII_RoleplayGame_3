using System.Collections.Generic;
namespace RoleplayGame
{
    public abstract class Enemy: Character
    {
        private int vp=0; /*Le agrego un vp inicial de 0, en cada nueva classe de enemigo le incorporo su propio VP asi varian*/
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
    }
}
