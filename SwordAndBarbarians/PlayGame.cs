using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordAndBarbarians
{
    class PlayGame
    {
        public void Play()
        {
            Combatant userPlayer = new();
            Combatant computer = new();            
            Console.WriteLine("Enter your name:");
            userPlayer.Name = Console.ReadLine();
            Battel battel = new();
            bool isUserTurn = true;
            while (true)
            {
                Menu(userPlayer,computer);                
                if (battel.Winner(userPlayer, computer))
                {
                    break;
                }                
                if (isUserTurn)
                {
                    var userChoice = TryParse();
                    switch (userChoice)
                    {
                        case 1:
                            battel.Attack(computer);
                            break;
                        case 2:
                            battel.BigAttack(computer);
                            break;
                        default:
                            Console.WriteLine("You must choose 1 or 2!");
                            break;
                    }
                }
                else
                {
                    battel.ComputerPlay(userPlayer);             
                }
                isUserTurn = isUserTurn == true ? isUserTurn = false : isUserTurn = true;
            }  
        }
        public void Menu(Combatant userplayer, Combatant computer)
        {
            Console.Clear();
            string format = "{0,-30} {1,5}";
            Console.WriteLine(format, userplayer.Name + "\t(HP=" + userplayer.HP + ")", computer.Name + "\t (HP=" + computer.HP + ")");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Which attck do you perfer?");
            Console.WriteLine("1.Attack");
            Console.WriteLine("2.Big attack");
        }
        private int TryParse()
        {
            int input;
            while (int.TryParse(Console.ReadLine(), out input) == false)
            {
                Console.WriteLine("you haven't entered a correct integer, try again");
            }
            return input;
        }
    }
}
