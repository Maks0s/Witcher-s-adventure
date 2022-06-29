using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismRepeat
{
    public class BootsChooser
    {
        public Boots BootsWithNoType;
        public Boots ChooseArmor()
        {
            IType[] armorType = { new LiteType(), new MediumType(), new HeavyType() };
            Console.WriteLine("Choose your armor Type");
            Console.WriteLine($"1 - Lite 2 - Medium 3 - Heavy");
            string strPlayerChoose = Console.ReadLine();
            if (strPlayerChoose != "1" || strPlayerChoose != "2" || strPlayerChoose != "3")
            {
                Thread.Sleep(1000);
                Console.WriteLine("You write the wrong value");
                strPlayerChoose = Console.ReadLine();
            }
            int playerChoose = Convert.ToInt32(strPlayerChoose);
            BootsWithNoType.ArmorType = armorType[playerChoose];
            Thread.Sleep(1000);
            return BootsWithNoType;
        }
    }
}
