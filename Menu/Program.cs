using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int valg = Menu.StartMenu();
            
            BilletSystem.Billetter(valg);
            
        }

    }
    
}
