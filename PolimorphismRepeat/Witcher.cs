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
            var typeChooser = new ArmorTypeChooser();
            var pictures = new Pictures();
            CurrentVest = new LVL1Vest();
            pictures.PrintVestPictures();
            CurrentVest.ArmorType = typeChooser.ChooseArmor();
            CurrentPants = new LVL1Pants();
            pictures.PrintPants();
            CurrentPants.ArmorType = typeChooser.ChooseArmor();
            CurrentBoots = new LVL1Boots();
            pictures.PrintBoots();
            CurrentBoots.ArmorType = typeChooser.ChooseArmor();
            CurrentSword = new LVL1Sword();
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
            _armor += CurrentVest.Armor;
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

        
        public Vest CurrentVest { get; set; }
        public Pants CurrentPants { get; set; }
        public Boots CurrentBoots { get; set; }
        public Sword CurrentSword { get; set; }



        private void ValuesCounter ( IType armoryPart )
        {
            _weight += armoryPart.Weigth;
            _speed += armoryPart.SpeedBonus;
            _hp += armoryPart.HPBonus;
        }
    }
}
