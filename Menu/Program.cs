using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int kør = 0;

            do
            {
                int valg = Menu.StartMenu();
                // double nypris = Administration.Admin(valg); VIRKER IKKE
                BilletSystem.Billetter(valg);
            } while (kør == 0);


        }

    }
    
}
