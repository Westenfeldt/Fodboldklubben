using System;
namespace Menu
{
    class BilletSystem
    {
        public static double Billetter(double valg)
        {
            int antalbørn, antalvoksen;
            double rabat, beløb, beløbtilbage, totalprisUSD;
            double totalpris = 0;
            if (valg == 1)
            {
                do {

                    // Rydder console for tekst, og spørg derefter antal billetter og udregning
                    Console.Clear();
            
                    Console.WriteLine("Du har valgt at købe billetter.");

                    Console.WriteLine("Du skal nu vælge, hvor mange voksen og/eller børnebilletter du ønsker");
                    Console.WriteLine("Hvor mange børnebilletter ønsker du?");
                    antalbørn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hvor mange voksenbilletter ønsker du?");
                    antalvoksen = Convert.ToInt32(Console.ReadLine());
                    totalpris = antalbørn * 30 + antalvoksen * 65;
                    Console.Clear();
                    Console.WriteLine("Ved køb af {0} voksenbilletter og {1} børnebilletter, ligger din pris på {2} kr",antalvoksen, antalbørn, totalpris);
                    // Totalprisen er nu udregning og udskrevet

                    

                    //Udregning af rabat
                    Console.WriteLine("Er du medlem af vores forening? - Ja/Nej");
                    string medlem = Console.ReadLine();
                    Console.Clear();
                    if (medlem.ToLower() == "ja")
                    {
                        
                        Console.WriteLine("Da du er medlem af vores forening vil du dermed opnå 10% rabat");
                        rabat = totalpris * 0.10;
                        
                        totalpris = totalpris - rabat;
                        Console.WriteLine("Du har derfor med dit køb opnået {0} kr rabat og din totalpris er derfor nu {1}", rabat, totalpris);
                        Console.WriteLine("Hvad beløb du betaler med");
                        beløb = Convert.ToDouble(Console.ReadLine());
                        beløbtilbage = beløb- totalpris;
                        Console.Clear();
                        // Udenlandske tilskuer kan ikke være en del af foreningen, og opnår derfor ikke rabat.
                        totalprisUSD = totalpris / (625.45 / 100);
            
                        Console.WriteLine("Det betyder derfor at din nye totalpris er {0} kr", totalpris);
                        Console.WriteLine("Udenlandske tilskuer kan ikke optjene rabat, din pris derfor på {0:N2} USD", totalprisUSD);
                        Console.WriteLine("Du har betalt {0} og skal derfor have {1} kr tilbage", beløb, beløbtilbage);

                    } else
                    {
                        //Hvis man ikke er medlem, bliver rabatten ikke udregnet.
                        Console.WriteLine("Ikke medlemmer kan ikke få rabat, derfor er din pris {0}", totalpris);
                        Console.WriteLine("Hvad beløb du betaler med");
                        beløb = Convert.ToDouble(Console.ReadLine());
                        beløbtilbage = beløb- totalpris;
                       
                        Console.WriteLine("Du har betalt {0} og skal derfor have {1} kr tilbage", beløb, beløbtilbage);
                    }



                } while (antalbørn < 1  || antalvoksen < 1);


                
            }




            if (valg == 2)
            {
                Console.WriteLine("Du trykkede 2");
            }
            
            
            return totalpris;
        }


    }
}