using System;

namespace PolimorphismRepeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dialogue = new NPCDialogue();
            dialogue.StartDialogue();
            Witcher geralt = new Witcher();
            dialogue.ShowCurrentInfo(geralt);
            var combatPart = new Сombat();
            combatPart.FightSimulation(geralt, new Drowner());
            if(!combatPart.IsWitcherAlive)
            {
                dialogue.DefeatDialogue();
                return;
            }
            dialogue.PrepForSecondBattleDialogue();
            geralt.TakeGear(new LVL2Vest(), new LVL2Pants(), new LVL2Boots(), new LVL2Sword());
            dialogue.ShowCurrentInfo(geralt);
            dialogue.SecondBattleDialogue();
            combatPart.FightSimulation(geralt, new Wilkołak());
            if (!combatPart.IsWitcherAlive)
            {
                dialogue.DefeatDialogue();
                return;
            }
        }
    }
}