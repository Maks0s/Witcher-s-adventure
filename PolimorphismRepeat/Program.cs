using System;

namespace PolimorphismRepeat
{
    class Program
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
            dialogue.PrepForThirdBattleDialogue();
            geralt.TakeGear(new LVL3Vest(), new LVL3Pants(), new LVL3Boots(), new LVL3Sword());
            dialogue.ShowCurrentInfo(geralt);
            dialogue.ThirdBattleDialogue();
            combatPart.FightSimulation(geralt, new Draug());
            if (!combatPart.IsWitcherAlive)
            {
                dialogue.DefeatDialogue();
                return;
            }
            dialogue.EndDialogue();
        }
    }
}