using System;
namespace Menu
{
    class BilletSystem
    {
        public static double Billetter(double valg)
        {
            int antalbørn = 0;
            int antalvoksen = 0;
            
            double voksenpris = 65;
            double børnpris = 30;

            double rabat, beløb, beløbtilbage, totalprisUSD, beløbUSD;
            double totalpris = 0;
            if (valg == 1)
            {
                do {

                    // Rydder console for tekst, og spørg derefter antal børnebilletter
                    // Bliver ved med at spørge efter antal billetter, hvis den angivet værdi ikke er mindre end 10
                    Console.Clear();


                    Console.WriteLine("Du har valgt at købe billetter.");

                    Console.WriteLine("Du skal nu vælge, hvor mange voksen og/eller børnebilletter du ønsker");
                    Console.WriteLine("Hvor mange børnebilletter ønsker du?");
                    antalbørn = Convert.ToInt32(Console.ReadLine());

                } while (antalbørn > 10 || antalbørn < 0);
                do{ // Bliver ved med at spørge efter antal billetter, hvis den angivet værdi ikke er mindre end 10
                
                    Console.WriteLine("Hvor mange voksenbilletter ønsker du?");
                    antalvoksen = Convert.ToInt32(Console.ReadLine());

                    //Sørger for det er muligt at købe 0 børnebilletter eller 0 voksen billetter.
                    if (antalbørn == 0)
                    {
                        totalpris = antalvoksen * voksenpris;
                        Console.Clear();
                    }
                    else if (antalvoksen == 0)
                    {
                        totalpris = antalbørn * børnpris;
                        Console.Clear();
                    }
                    else
                    {

                        totalpris = antalbørn * børnpris + antalvoksen * voksenpris;
                        Console.Clear();
                    }
                } while (antalvoksen > 10 || antalvoksen < 0);

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


                    Console.WriteLine("Det betyder derfor at din nye totalpris er {0} kr", totalpris);
                        Console.WriteLine("Du har betalt {0} og skal derfor have {1} kr tilbage", beløb, beløbtilbage);
                        Console.WriteLine("");
                    for (int i = 5;  i > 0; i--){ 
                        Console.WriteLine("Du føres nu tilbage til hovedmenuen om {0} sek", i);
                        System.Threading.Thread.Sleep(1000);

                    }


                } else
                    {
                        //Hvis man ikke er medlem, bliver rabatten ikke udregnet.
                        Console.WriteLine("Ikke medlemmer kan ikke få rabat, derfor er din pris {0}", totalpris);
                        totalprisUSD = totalpris / (625.45 / 100);
                        Console.WriteLine("Udenlandske tilskuer kan ikke optjene rabat, din pris derfor på {0:N2} USD", totalprisUSD);

                    Console.WriteLine("Betaler du med DKK or USD?");
                    string svar = Console.ReadLine();

                    if (svar.ToLower() == "dkk")  // Hvis man betaler med dkk, køres denne kode.
                    {
                        Console.WriteLine("Hvad beløb du betaler med");
                        beløb = Convert.ToDouble(Console.ReadLine());
                        beløbtilbage = beløb - totalpris;

                        Console.WriteLine("Du har betalt {0} og skal derfor have {1} kr tilbage", beløb, beløbtilbage);
                    } else
                    {
                        Console.WriteLine("What amount are you paying with?");
                        beløbUSD = Convert.ToDouble(Console.ReadLine());
                        beløbtilbage = (beløbUSD - totalprisUSD) * 0.62545;

                        Console.WriteLine("You have payed {0} and will receive back {1:N2} kr back", beløbUSD, beløbtilbage);
                    }


                        

                    for (int i = 5; i > 0; i--)
                    {
                        Console.WriteLine("Du føres nu tilbage til hovedmenuen om {0} sek", i);
                        System.Threading.Thread.Sleep(1000);

                    }
                }



                


                
            }




            

            Console.Clear();
            return totalpris;
        }


    }
}