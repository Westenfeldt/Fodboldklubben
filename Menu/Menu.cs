using System;
namespace Menu
{
    class Menu
    {
        public static int StartMenu()
        {


            //Dato
            Console.SetCursorPosition(90, 0);
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Idag er datoen: {0}", dateTime);






            // Der kan tilføjes flere valgmuligheder
            //Sætter farve på overskrift 
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Velkommen til F O D B O L D K L U B B E N - D 33");
            //Nulstiller farven
            Console.ResetColor();
            Console.WriteLine("Vil du gerne købe billetter. Tryk: 1");
            
            Console.WriteLine("MULIGHED. Tryk: 2");
            
            Console.WriteLine("MULIGHED. Tryk: 3");
            
            Console.WriteLine("MULIGHED. Tryk: 4");
            
            string valg = Console.ReadLine();
            return Convert.ToInt32(valg);



        }

    }




}