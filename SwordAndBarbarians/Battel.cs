using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndBarbarians
{
    class Battel
    {
        public void Attack(Combatant combatant)
        {
            int damage = 2;
            combatant.HP -= damage;
        }
        public void BigAttack(Combatant combatant)
        {
            int randomAttackPower = new Random().Next(0, 3);
            int dagmage = 2 * randomAttackPower;
            combatant.HP -= dagmage;
        }
        public void ComputerPlay(Combatant userPlayer)
        {
            var computerChoice = new Random().Next(1, 3);

            if (computerChoice == 1)
            {
                Attack(userPlayer);
            }
            else
            {
                BigAttack(userPlayer);
            }
        }
        public bool Winner(Combatant player,Combatant computer)
        {        
            if (computer.HP <= 0)
            {
                Console.WriteLine($"Player {player.Name} won!");
                return true;
            }
            if(player.HP<=0)
            {
                Console.WriteLine($"Player {computer.Name} won!");
                return true;
            }
            return false;
        }
    }
}
