using System;

namespace Lab3_z3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite brojeve (razdvojene razmakom):");
            string unos = Console.ReadLine();
            string[] pojedinacniUnosi = unos.Split(" ");

           
            List<int> brojevi = new List<int>();
            try
            {
                foreach (var s in pojedinacniUnosi)
                    brojevi.Add(Int32.Parse(s));
            }
            catch(Exception e)
            {
                Console.Write("Pogrešan/prazan unos.");
                return;
            }


            var parni = brojevi.Where(broj => broj % 2 == 0).ToList();
            var neparni = brojevi.Where(broj => broj % 2 != 0).ToList();

            List<int> redukovaniBrojevi;
            if (parni.Count > neparni.Count)
                redukovaniBrojevi = parni;
            else
                redukovaniBrojevi = neparni;

            int suma = 0;
            redukovaniBrojevi.ForEach(broj => suma += broj);

            if (suma < 0)
                Console.WriteLine("Greška! Dobili ste sumu: {0}", suma);
            else
            {
                Console.Write("Elementi: ");
                foreach (var broj in redukovaniBrojevi)
                    Console.Write("{0} ", broj);
                Console.Write("\nSuma: {0}", suma);
            }
        }
    }
}