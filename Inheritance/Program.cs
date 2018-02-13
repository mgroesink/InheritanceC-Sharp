using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circles and points");
            Console.Write("Geef de gewenste straal voor de cirkel (0,00): ");
            double radius;
            while (!double.TryParse(Console.ReadLine(), out radius))
            {
                playAlarm();
                Console.WriteLine("Ongeldige invoer");
                Console.Write("Geef de gewenste straal voor de cirkel (0,00): ");

            }
            Circle circle = new Circle();
            circle.Radius = radius;
            writeEmptyLines(2);
            Console.WriteLine("*".PadRight(110,'*'));
            string area = string.Format("De oppervlakte van een cirkel met een straal van {0:0.00} is {1:0.00}", radius, circle.Area);
            string circumference = string.Format("De omtrek van een cirkel met een straal van {0:0.00} is {1:0.00}", radius, circle.Circumference);
            Console.WriteLine("**   " + area + " ".PadRight(110 - area.Length - 7) + "**");
            Console.WriteLine("**   " + circumference + " ".PadRight(110 - circumference.Length - 7) + "**");
            Console.WriteLine("*".PadRight(110,'*'));
            writeEmptyLines(3);

            Console.WriteLine("Rectanges and staffs");
            Console.Write("Geef de gewenste lengte voor het vierkant (0,00): ");
            double length;
            while (!double.TryParse(Console.ReadLine(), out length))
            {
                playAlarm();
                Console.WriteLine("Ongeldige invoer");
                Console.Write("Geef de gewenste lengte voor het vierkant (0,00): ");

            }

            Console.Write("Geef de gewenste hoogte voor het vierkant (0,00): ");
            double height;
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                playAlarm();
                Console.WriteLine("Ongeldige invoer");
                Console.Write("Geef de gewenste hoogte voor het vierkant (0,00): ");

            }

            Rectangle rect = new Rectangle(length , height);
            writeEmptyLines(2);
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*".PadRight(110, '*'));
            area = string.Format("De oppervlakte van een vierkant met een lengte van {0:0.00} en een hoogte van {1:0.00} is {2:0.00}", 
                length, height , rect.Area);
            Console.WriteLine("**   " + area + " ".PadRight(110 - area.Length - 7) + "**");
            Console.WriteLine("*".PadRight(110, '*'));
            writeEmptyLines(3);
            Console.ForegroundColor = oldColor;


            Console.Write("Geef de gewenste lengte voor de staaf (0,00): ");
            while (!double.TryParse(Console.ReadLine(), out length))
            {
                playAlarm();
                Console.WriteLine("Ongeldige invoer");
                Console.Write("Geef de gewenste lengte voor de staaf (0,00): ");

            }

            Console.Write("Geef de gewenste hoogte voor de staaf (0,00): ");
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                playAlarm();
                Console.WriteLine("Ongeldige invoer");
                Console.Write("Geef de gewenste hoogte voor de staaf (0,00): ");

            }

            double depth;
            Console.Write("Geef de gewenste diepte voor de staaf (0,00): ");
            while (!double.TryParse(Console.ReadLine(), out depth))
            {
                playAlarm();
                Console.WriteLine("Ongeldige invoer");
                Console.Write("Geef de gewenste diepte voor de staaf (0,00): ");

            }

            Staff staff = new Staff(length, height , depth);
            writeEmptyLines(2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*".PadRight(110, '*'));
            area = string.Format("Het volume van een staaf met lengte {0:0.00}, hoogte {1:0.00} en diepte {2:0.00} is {3:0.00}",
                length, height, depth , staff.Volume);
            Console.WriteLine("**   " + area + " ".PadRight(110 - area.Length - 7) + "**");
            Console.WriteLine("*".PadRight(110, '*'));
            writeEmptyLines(3);
            Console.ForegroundColor = oldColor;


            Console.WriteLine("Druk op een toets om applicatie af te sluiten");
            Console.ReadKey();
        }

        #region Helper Methods
        /// <summary>
        /// Plays the alarm.
        /// </summary>
        private static void playAlarm()
        {
            for (int i = 1000; i < 1500; i += 10)
            {
                Console.Beep(i, 5);
            }
        }

        /// <summary>
        /// Writes empty lines.
        /// </summary>
        /// <param name="amount">The amount of empty lines.</param>
        private static void writeEmptyLines(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine();

            }
        } 
        #endregion
    }
}
