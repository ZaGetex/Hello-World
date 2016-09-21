using System;


namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            string Antwort;
            do
            {
                Console.WriteLine("Hallo bist du da?");
                Antwort = Console.ReadLine();

                if (Antwort == "Ja")
                    Console.WriteLine("Ich bin auch da!");
                        if (Antwort == "ja")
                    Console.WriteLine("Ich bin auch da!");
                   

                if (Antwort == "Illuminati")
                    Console.WriteLine("WOHER WUSSSTEST DU DAS?");
                if (Antwort == "Wie geht es dir?")
                    Console.WriteLine("Gut? Und dir?");
                if (Antwort == "Auch gut")
                    Console.WriteLine("Das weiß ich, denn ich bin allwissend!");
                if (Antwort == "Nein")
                    Console.WriteLine("Wenn du nicht da bist gehe ich jetzt!");

                if (Antwort == "nein")
                {
                    Console.WriteLine("Wenn du nicht da bist gehe ich jetzt!");
                    Antwort = "Nein";
                    break;
                 }

            }

            while (Antwort != "Nein");

            Console.WriteLine("Tschüß!");
            Console.ReadKey();
        }
    }
}
 //while (Antwort != "Ja" || Antwort != "Nein");