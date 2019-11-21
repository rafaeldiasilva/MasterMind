using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();



        }

        static void menu()
        {
            bool sair = false;
            while (true)
            {
                if (sair) break;
                Console.Clear();
                Console.WriteLine("1. iniciar\nEscape para sair");
                var keyData = Console.ReadKey(false).Key;
                Console.Clear();
                switch (keyData)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        subMenu();
                        break;
                    case ConsoleKey.Escape:
                        sair = true;
                        break;
                }
            }
        }


        static void subMenu()
        {

            Console.WriteLine("------- Digite o numero correspondente ao carro --------");

            bool sair = false;

            while (true)
            {
                if (sair) break;
                Console.Clear();
                Console.WriteLine("1. carro WV\n2. carro SEAT\nEscape para sair");

                var keyData = Console.ReadKey(false).Key;
                Console.Clear();
                switch (keyData)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        //cmd.Comandos_Carro(cWV);
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        //cmd.Comandos_Carro(cSEAT);
                        break;

                    case ConsoleKey.Escape:
                        sair = true;
                        break;
                }
            }

        }



    }
}
