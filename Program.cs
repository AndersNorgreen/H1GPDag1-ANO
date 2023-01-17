using static System.Console;
using System.Threading;

namespace H1GPDag1
{
    class Program
    {
        static void Main(string[] args)
        {
            MainConversionMenu();

            ReadKey();
        }

        private static void MainConversionMenu()
        {
            WriteLine("Velkommen til TEC konvertering!" + Environment.NewLine);
            WriteLine("1. Afstandskonvertering (mellem centimeter og tommer, meter og yards/feet og mellem mil og kilometer)");
            WriteLine("2. Gradskonvertering (mellem celcius og fahrenheit)");
            WriteLine("3. Afslut" + Environment.NewLine);
            Write("Indtast et tal fra menuen for at vælge: ");
            var choice = HandleInputConversion(ReadLine());

            switch (choice)
            {
                case 1:
                    DistanceConverter();
                    break;
                case 2:
                    DegreeConverter();
                    break;
                case 3:
                    Quit();
                    break;
            }
        }

        public static void DistanceConverter()
        {
            WriteLine("Her vil du kunne vælge afstande at omregne");
            FinishOption();
        }

        private static void DegreeConverter()
        {
            Clear();
            WriteLine("Velkommen til TECs gradskonvertering" + Environment.NewLine);
            WriteLine("1. Celcius til fahrenheit");
            WriteLine("2. Fahrenheit til celcius");
            Write(Environment.NewLine + "Ønsker du at konvertere fra: ");

            if (HandleInputConversion(ReadLine()) == 1)
            {
                Clear();
                Write("Indtast den ønskede temperatur i celcius: ");
                
                int celcius = HandleInputConversion(ReadLine());

                WriteLine($"{celcius} grader celcius er {(float)celcius * 9 / 5 + 32} grader fahrenheit");
            }
            else if (HandleInputConversion(ReadLine()) == 2)
            {
                Clear();
                Write("Indtast den ønskede temperatur i fahrenheit: ");
                int fahrenheit = HandleInputConversion(ReadLine());

                WriteLine($"{fahrenheit} grader fahrenheit er {((float)fahrenheit - 32) * 5 / 9} grader celcius");
            }
        }

        private static int HandleInputConversion(string input)
        {
            do
            {
                if (!Int32.TryParse(input, out int i))
                {
                    Write("Det var ikke et tal! Indtast et tal fra menuen for at vælge: ");
                    input = ReadLine();
                }
                else
                {
                    return i;
                }
            }
            while (true);
        }

        private static void FinishOption()
        {
            WriteLine(Environment.NewLine + "Tryk en tast for at vende tilbage til hovedmenuen...");
            ReadKey();
            MainConversionMenu();
        }

        private static void Quit()
        {
            WriteLine("Tak for at have anvendt TEC konvertering. Farvel!");
            Thread.Sleep(3000);
            Environment.Exit(0);
        }
    }
} 
