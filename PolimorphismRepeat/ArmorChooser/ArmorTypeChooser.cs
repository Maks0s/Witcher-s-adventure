using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismRepeat
{
    public class ArmorTypeChooser
    {
        public IType armorTypeToChoose;
        public IType ChooseArmor()
        {
            IType[] armorType = { new LightType(), new MediumType(), new HeavyType() };
            Console.WriteLine("Choose your armor Type");
            Console.WriteLine("1 - Lite \n2 - Medium \n3 - Heavy");
            string strPlayerChoose = Console.ReadLine();
            if (strPlayerChoose != "1" && strPlayerChoose != "2" && strPlayerChoose != "3")
            {
                Thread.Sleep(500);
                Console.WriteLine("You write the wrong value");
                strPlayerChoose = Console.ReadLine();
            }
            int playerChoose = Convert.ToInt32(strPlayerChoose);
            armorTypeToChoose = armorType[playerChoose-1];
            Thread.Sleep(1500);
            Console.Clear();
            return armorTypeToChoose;
        }
    }
}
