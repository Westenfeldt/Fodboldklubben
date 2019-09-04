using System;
namespace Menu
{
	class Administration
        {
            public static double Admin(double valg)
        {
            Console.WriteLine("Du prøver at tilgå den administrative del. Indtast det korrekte kodeord.");

            string kodeord = Console.ReadLine();

            if (kodeord == "admin")
            {
                Console.WriteLine("Du er nu logget ind som administator, du kan nu ændre prisen på billetterne");
                Console.WriteLine("Hvad skal prisen være for en voksen billetvære?");
                double nyvoksen = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Hvad skal prisen være for en børne billet være?");
                double nybørn = Convert.ToDouble(Console.ReadLine());

                


            } else
            {   
                int i = 0; // Tjekker om koden skrives rigtigt 3 gange, efter 3 forsøg, bliver man ført tilbage til start menuen.
                do
                {
                    i++;
                    Console.WriteLine("Koden du har indtastet er ikke korrekt, prøv igen.");
                    Console.WriteLine("Dette var forsøg {0}. Du kan maks skrive koden forkert 3 gange", i);
                    kodeord = Console.ReadLine();
                    
                } while (kodeord != "admin" && i < 2);
                for (int j = 5; j > 0; j--)
                {
                    Console.WriteLine("Du føres nu tilbage til hovedmenuen om {0} sek, da du indtastede koden forkert for mange gange", j);
                    System.Threading.Thread.Sleep(1000);

                }
            }
            double nypris = 1;



            return nypris;
        }



        
        }

}