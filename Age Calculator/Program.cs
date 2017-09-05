using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Age_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // We maken een nieuw object aan van Birthday
            Birthday birthday = new Birthday();

            // We vragen de gebruiker om zijn geboortedatum
            Console.Write("Voer je geboortedatum in (dd-MM-yyyy): ");

            // De geboortedatum wordt ingevoerd en opgeslagen
            string input = Console.ReadLine();

            // Vervolgens roepen we de calculateBirthday methode aan om de leeftijd te gaan berekenen
            birthday.calculateBirthday(input);

            // Laat het resultaat zien op het scherm
            Console.WriteLine("Je leeftijd is " + birthday.Age());
            Console.ReadKey();
        }
    }
}
