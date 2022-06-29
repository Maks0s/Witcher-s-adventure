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
            Console.WriteLine($"Gervat, come here faster!");
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine($"Choose any armor and to the entrance to Kaer Morhen...");
            Thread.Sleep(1000);
            Console.WriteLine($"Fucking drowners are became mad!");
            Thread.Sleep(1000);
            Console.WriteLine($"They began to climb out of their mud houses not only at night");
            Console.Clear();
            Thread.Sleep(1500);

        }
    }
}
