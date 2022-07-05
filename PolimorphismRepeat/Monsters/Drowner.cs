using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismRepeat
{
    public class Drowner : Monster
    {
        public Drowner ()
        {
            _name = "Swag Drowner";
            _speed = 18;
            _hp = 100;
            _armor = 0;
            _damage = 35;
        }
    }
}
