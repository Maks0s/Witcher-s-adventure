using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismRepeat
{
    public class Monster
    {
        protected string _name;
        public string Name { get => _name; }

        protected int _speed;
        public int Speed { get => _speed; }

        protected int _hp;
        public int HP { get => _hp; }

        protected int _armor;
        public int Armor { get => _armor; }

        protected int _damage;
        public int Damage { get => _damage; }

        public int HPReducing(int damageReceived) => _hp = _hp - (damageReceived - _armor);
    }
}
