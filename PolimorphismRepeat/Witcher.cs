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
            var vestChoose = new VestChooser{ VestWithNoType = new LVL1Vest()};
            CurrentVest = vestChoose.ChooseArmor();
            var pantsChoose = new PantsChooser { PantsWithNoType = new LVL1Pants() };
            CurrentPants = pantsChoose.ChooseArmor();
            var bootsChoose = new BootsChooser { BootsWithNoType = new LVL1Boots() };
            CurrentBoots = bootsChoose.ChooseArmor();
        }

        readonly string _name = "Gervant from Ribiya";

        private int _weight = 80;

        private int _speed = 24;

        private void SpeedCalculate()
        {
            _speed = _speed - (int)Math.Round(_weight * 10 / 100.0);
        }

        private void WeightCalculate()
        {
            if (CurrentPants != null)
            {
                _weight =  _weight - CurrentPants.WeightLift;
            }
        }

        private int _hp;

        private int _armor;
        public int Armor { get; private set; }

        
        public Vest CurrentVest { get; set; }
        public Pants CurrentPants { get; set; }
        public Boots CurrentBoots { get; set; }
        public Sword CurrentSword { get; set; }



        private void ValuesCounter ( IType armoryPart )
        {
            WeightCalculate ();
            _weight += armoryPart.Weigth;
            SpeedCalculate();
            _speed += armoryPart.SpeedBonus;
            _hp += armoryPart.HPBonus;
        }
    }
}
