using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismRepeat
{
    public class Сombat
    {
        private Random _random = new Random();
        private Pictures _pictures = new Pictures();
        private bool _isWitcherAlive = true;

        public bool IsWitcherAlive { get => _isWitcherAlive; }
        public void FightSimulation(Witcher witcher, Monster monster)
        {
            int firstHit = _random.Next(2);
            _pictures.PrintWitcherAndMonster();
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();
            if (firstHit == 0)
            {
                Fight(witcher, monster);
            }
            else
            {
                _pictures.PrintWitcherAndMonster();
                _pictures.PrintMonsterHitsWitcher();
                if (!IsDamageEvaded(witcher.Speed))
                {
                    witcher.HPReducing(monster.Damage);
                }
                Fight(witcher, monster);
            }
        }

        private void Fight(Witcher witcher, Monster monster)
        {
            while (monster.HP >= 0 && witcher.HP >= 0)
            {
                int randomHit = _random.Next(2);
                _pictures.PrintWitcherAndMonster();
                if(randomHit == 0)
                {
                    _pictures.PrintWitcherHitsMonster();
                }
                else
                {
                    _pictures.PrintWitcherSingHitMonster();
                }
                if (!IsDamageEvaded(monster.Speed))
                {
                    monster.HPReducing(witcher.CurrentSword.Damage);
                }
                _pictures.PrintWitcherAndMonster();
                _pictures.PrintMonsterHitsWitcher();
                if (!IsDamageEvaded(witcher.Speed))
                {
                    witcher.HPReducing(monster.Damage);
                }
            }

            if(witcher.HP <= 0)
            {
                _isWitcherAlive = false;
            }
            witcher.StatsRefresh();
        }

        private bool IsDamageEvaded(int speed)
        {
            int evasionChance = _random.Next(45);
            if(evasionChance <= speed)
            {
                _pictures.PrintMiss();
                return true;
            }
            return false;
        }
    }
}
