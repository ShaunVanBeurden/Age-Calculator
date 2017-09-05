using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Birthday
    {
        int age;

        // Berekent de leeftijd
        public void calculateBirthday(string input)
        {
            DateTime birthDay;

            // Checkt of het parsen wel goed is gebaseerd op de user input
            bool valid = DateTime.TryParseExact(input, "dd-MM-yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out birthDay);

            // Als de user input fout is komt de gebruiker in een loop
            while (!valid)
            {
                // Hij moet opnieuw zijn geboortedatum invoeren
                Console.WriteLine("Je vulde een ongeldige geboortedatum in! Probeer het opnieuw.");
                Console.Write("Voer je geboortedatum in (dd-MM-yyyy): ");
                input = Console.ReadLine();

                // Vervolgens wordt gecheckt of de invoer nu wel dd-MM-yyyy is
                if (DateTime.TryParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDay))
                {
                    // Zoja dan leaven we de loop
                    break;
                }
            }

            // Stopt de huidige datum in een variabele
            DateTime currentDate = DateTime.Today;

            // De leeftijd wordt berekent op basis van het huidige jaar - het geboortejaar
            age = currentDate.Year - birthDay.Year;

            // Ten slotte wordt gecheckt of de persoon al jarig is geweest dit jaar of niet
            if (currentDate < birthDay.AddYears(age))
            {
                // Zonee dan is de persoon 1 jaar jonger omdat hij nog niet jarig is geweest
                age--;
            }
        }

        // Returned de leeftijd
        public int Age()
        {
            return age;
        }
    }
}
