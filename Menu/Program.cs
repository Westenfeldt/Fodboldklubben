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
                Administration.Admin(valg); // TJEK AF KODEORD VIRKER ---- RESTEN VIRKER IKKE.
                BilletSystem.Billetter(valg);
            } while (kør == 0);


        }

    }
    
}
