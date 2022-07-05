using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismRepeat 
{
    public class Witcher 
    {
        public Witcher ()
        {
            _weight = 80;
            _speed = 24;
            _hp = 100;
            _armor = 0;
            TakeGear(new LVL1Vest(), new LVL1Pants(), new LVL1Boots(), new LVL1Sword());
        }

        public void TakeGear(Vest vestLVL, Pants pantsLVL, Boots bootsLVL, Sword swordLVL)
        {
            var typeChooser = new ArmorTypeChooser();
            var pictures = new Pictures();
            CurrentVest = vestLVL;
            pictures.PrintVestPictures(vestLVL);
            CurrentVest.ArmorType = typeChooser.ChooseArmor();
            CurrentPants = pantsLVL;
            pictures.PrintPants(pantsLVL);
            CurrentPants.ArmorType = typeChooser.ChooseArmor();
            CurrentBoots = bootsLVL;
            pictures.PrintBoots(bootsLVL);
            CurrentBoots.ArmorType = typeChooser.ChooseArmor();
            CurrentSword = swordLVL;
            ValuesCounter(CurrentVest.ArmorType);
            ValuesCounter(CurrentPants.ArmorType);
            ValuesCounter(CurrentBoots.ArmorType);
            BonusValuesCalculate();
        }

        private string _name = "Gervant from Ribiya";
        public string Name { get => _name; }

        private int _weight;
        public int Weight { get => _weight; }

        private int _speed;
        public int Speed { get => _speed; }

        private void BonusValuesCalculate()
        {
            _armor = CurrentVest.Armor;
            _speed += CurrentBoots.SpeedGain;
            _weight += CurrentPants.WeightLift;
            _speed = _speed - (int)Math.Round(_weight * 10 / 100.0);
            if(_speed < 0)
            {
                _speed = 0;
            }
        }


        private int _hp;
        public int HP { get => _hp; }

        private int _armor;
        public int Armor { get => _armor; }

        
        public Vest CurrentVest { get; private set; }
        public Pants CurrentPants { get; private set; }
        public Boots CurrentBoots { get; private set; }
        public Sword CurrentSword { get; private set; }



        private void ValuesCounter ( IType armoryPart )
        {
            _weight += armoryPart.Weigth;
            _speed += armoryPart.SpeedBonus;
            _hp += armoryPart.HPBonus;
        }
        
        public void HPReducing(int damageReceived) => _hp = _hp - (damageReceived - _armor);
        
        public void StatsRefresh()
        {
            _weight = 80;
            _speed = 24;
            _hp = 100;
            _armor = 0;
        }
    }
}
