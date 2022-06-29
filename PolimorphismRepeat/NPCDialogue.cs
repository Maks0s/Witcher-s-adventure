using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismRepeat
{
    public class NPCDialogue
    {
        public void StartDialogue()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Gervat, come here faster!");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine($"Choose any armor and run to the entrance to Kaer Morhen...");
            Thread.Sleep(4500);
            Console.WriteLine($"Fucking drowners are became mad!");
            Thread.Sleep(3500);
            Console.WriteLine($"They began to climb out of their mud holes not only at night");
            Thread.Sleep(5500);
            Console.Clear();
        }

        public void ShowCurrentInfo(Witcher witcher)
        {
            Console.WriteLine($"Weight - {witcher.Weight} " +
                $"\n Speed - {witcher.Speed}" +
                $"\n Health - {witcher.HP}" +
                $"\n Armor - {witcher.Armor}");
            Console.WriteLine();
            /*Console.WriteLine($"Vest - {nameof(witcher.CurrentVest.ArmorType)}");
            Console.WriteLine($"Pants - {nameof(witcher.CurrentPants.ArmorType)}");
            Console.WriteLine($"Boots - {nameof(witcher.CurrentBoots.ArmorType)}");
            Console.WriteLine($"Sword - {nameof(witcher.CurrentSword)}");*/
        }
    }
}
