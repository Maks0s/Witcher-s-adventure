using System;

namespace PolimorphismRepeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dialogue = new NPCDialogue();
            /*dialogue.StartDialogue();*/
            Witcher geralt = new Witcher();
            dialogue.ShowCurrentInfo(geralt);
            var combatPart = new Сombat();
            combatPart.FightSimulation(geralt, new Drowner());
            if(!combatPart.IsWitcherAlive)
            {
                dialogue.DefeatDialogue();
                return;
            }
            Console.WriteLine("Найс пиздилка");
        }
    }
}