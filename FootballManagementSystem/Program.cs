using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagementSystem
{
   
        class Program
        {
            static void Menu()
            {
                Console.WriteLine("1. Create new Player");
                Console.WriteLine("2. List of players");
                Console.WriteLine("3. Search player by name");
                Console.WriteLine("4. Raise attack event");
                Console.WriteLine("5. Raise defense event");
                Console.WriteLine("6. Exit");
            }
            static void Main(string[] args)
            {
                Club<IPlayer> club = new Club<IPlayer>();
                Menu();
                while (true)
                {
                    Console.Write("Please choose an option: ");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            Player player = new Player();
                            club.Add(player);
                            break;
                        case 2:
                            Console.WriteLine("List of players:");
                            if (club.PlayerList.Count == 0)
                            {
                                Console.WriteLine("No players!");
                            }
                            else
                            {
                                foreach (IPlayer player1 in club)
                                {
                                    player1.GetInfo();
                                }
                            }
                            break;
                        case 3:
                            if (club.PlayerList.Count == 0)
                            {
                                Console.WriteLine("No players!");
                            }
                            else
                            {
                                Console.Write("Input player name you want to search: ");
                                string name = Console.ReadLine();
                                bool found = false;
                                foreach (IPlayer player1 in club)
                                {
                                    if (name.Equals(player1.Name))
                                    {
                                        player1.GetInfo();
                                        found = true;
                                    }
                                }
                                if (!found)
                                {
                                    Console.WriteLine("The name {0} is not found!", name);
                                }
                            }
                            break;
                        case 4:
                            club.RaiseAttackEvent();
                            break;
                        case 5:
                            club.RaiseDefenseEvent();
                            break;
                        case 6: return;
                    }
                }
            }
        }
    }


