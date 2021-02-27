using System;
using System.Collections.Generic;
using System.Linq;

namespace testGame
{
    /*
    ДЗ: Реализовать консольную игру, позволяющую пользователю решить данную задачу.

     Крестьянину нужно перевезти через реку волка, козу и капусту. 
     Но лодка такова, что в ней может поместиться только крестьянин, а с ним или один волк, или одна коза, или одна капуста. 
     Но если оставить волка с козой, то волк съест козу, а если оставить козу с капустой, то коза съест капусту. 
     Как перевез свой груз крестьянин?
    */

    public static class Game
    {
        private static List<string> firstIsland = new List<string> { "Wolf", "Goat", "Cabbage" };

        private static List<string> secondIsland = new List<string>();

        private static List<string> onBoard = new List<string>();

        private static bool ItIsSecondIslandNow = false;


        public static void StartGame()
        {
            ShowStatistics();
            Console.WriteLine(@"
Чтобы взять пассажира на лодку нажмите: 1
Чтобы преплыть на Второй остров нажмите: 2
Чтобы преплыть на Первый остров нажмите: 3");

            int select = Convert.ToInt32(Console.ReadLine());

            switch (select)
            {
                case 1:
                    PutPassangerOnBoard();
                    break;
                case 2:
                    SailToSecondIsland();
                    break;
                case 3:
                    SailToFirstIsland();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Неизвестная команда");
                    StartGame();
                    break;
            }
        }

        public static void PutPassangerOnBoard()
        {
            if (onBoard.Count() >= 1)
            {
                Console.Clear();
                Console.WriteLine("В лодке уже есть пассажир");
                StartGame();
            }

            Console.WriteLine("Кого берем на борт?\nВолк - 1\nКоза - 2\nКапуста - 3");

            int select = Convert.ToInt32(Console.ReadLine());

            switch (select)
            {
                case 1:
                    TransferOnBoard("Wolf");
                    break;
                case 2:
                    TransferOnBoard("Goat");
                    break;
                case 3:
                    TransferOnBoard("Cabbage");
                    break;
                default:
                    Console.Clear();
                    PutPassangerOnBoard();
                    Console.WriteLine("Неизвестная команда");
                    break;
            }
        }

        private static void TransferOnBoard(string passanger)
        {
            Console.Clear();
            if (ItIsSecondIslandNow == false)
            {
                if (firstIsland.Contains(passanger))
                {
                    onBoard.Add(passanger);
                    firstIsland.Remove(passanger);

                    Console.WriteLine($"{passanger} погружен на лодку");
                }
                else
                    Console.WriteLine($"Island haven't the {passanger}");
            }
            else
            {
                if (secondIsland.Contains(passanger))
                {
                    onBoard.Add(passanger);
                    secondIsland.Remove(passanger);

                    Console.WriteLine($"{passanger} погружен на лодку");
                }
                else
                    Console.WriteLine($"Island haven't the {passanger}");
            }

            StartGame();
        }

        private static void ShowStatistics()
        {
            Console.WriteLine("\nНа первом острове находятся:");
            Console.WriteLine("************************");
            if (firstIsland.Count == 0)
                Console.WriteLine("Пусто");
            foreach (var item in firstIsland)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nНа борту находятся:");
            Console.WriteLine("************************");
            if (onBoard.Count == 0)
                Console.WriteLine("Пусто");
            foreach (var item in onBoard)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nНа втором острове находятся:");
            Console.WriteLine("************************");
            if (secondIsland.Count == 0)
                Console.WriteLine("Пусто");
            foreach (var item in secondIsland)
            {
                Console.WriteLine(item);
            }
        }

        public static void OutPassangerOnIsland(List<string> island)
        {
            if (onBoard.Count() >= 1)
            {
                var passanger = onBoard.ElementAt(0);
                TransferOnIsland(passanger, island);
                Console.Clear();
                Console.WriteLine($"Вы переплыли на другой остров и высадили {passanger}");
                if (secondIsland.Count() == 3)
                {
                    Console.WriteLine("You Win!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Лодка пуста");
            }

            StartGame();
        }

        private static void TransferOnIsland(string passanger, List<string> island)
        {
            onBoard.Remove(passanger);
            if (island == secondIsland)
            {
                secondIsland.Add(passanger);
            }
            else
            {
                firstIsland.Add(passanger);
            }

        }

        public static void SailToFirstIsland()
        {
            if (CheckCompatibility())
            {
                ItIsSecondIslandNow = false;
                OutPassangerOnIsland(firstIsland);
            }
        }

        public static void SailToSecondIsland()
        {
            if (CheckCompatibility())
            {
                ItIsSecondIslandNow = true;
                OutPassangerOnIsland(secondIsland);
            }
        }

        private static bool CheckCompatibility()
        {
            if ((firstIsland.Contains("Goat") && firstIsland.Contains("Wolf")) || ((secondIsland.Contains("Goat") && secondIsland.Contains("Wolf"))))
            {
                Console.Clear();
                Console.WriteLine("Wolf eat Goat");
                Console.WriteLine("You lose!");
                return false;
            }
            else if ((firstIsland.Contains("Goat") && firstIsland.Contains("Cabbage")) || ((secondIsland.Contains("Goat") && secondIsland.Contains("Cabbage"))))
            {
                Console.Clear();
                Console.WriteLine("Koza eat Cabbage");
                Console.WriteLine("You lose!");
                return false;
            }
            else
                return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(@"
Крестьянину нужно перевезти через реку волка, козу и капусту. 
Но лодка такова, что в ней может поместиться только крестьянин, а с ним или один волк, или одна коза, или одна капуста. 
Но если оставить волка с козой, то волк съест козу, а если оставить козу с капустой, то коза съест капусту. 
Как перевез свой груз крестьянин?");

            Game.StartGame();

        }
    }
}
