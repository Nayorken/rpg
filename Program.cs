using System;

namespace rpg_game
{
    class Program
    {
        
        private fechar fecha = new fechar();
        
        
        
        static void Main(string[] args)
        {

            Console.WriteLine("Estás pronto para o desafio");
            Console.WriteLine("\ts - Sim");
            Console.WriteLine("\tn - Não");


            switch (Console.ReadLine())
            {
                case "s":
                    Console.WriteLine("Muito bem, antes de começarmos vamos verificar se é humano quanto é 2x4?");
                    break;

                case "n":
                    Console.WriteLine("Que pena espero que voltes com mais vontade para a proxima!");
                    Console.ReadKey();
                    
                    break;
            }

            Console.WriteLine("Estás pronto para o desafio");
            Console.WriteLine("\t2 - 2");
            Console.WriteLine("\t5 - 5");
            Console.WriteLine("\t8 - 8");
            
            switch (Console.ReadLine())
            {
                case "8":
                    Console.WriteLine("Parabens tens mais iq ");
                    break;

                case "2":
                    Console.WriteLine("Vai estudar");
                    Console.WriteLine("Game over!");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "5":
                    Console.WriteLine("Vai estudar");
                    Console.WriteLine("Game Over!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

            Console.ReadKey();
        }
    }
}
