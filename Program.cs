    using static System.Console;

namespace H1GPDag1
{
    class Program
    {
        static void Main(string[] args)
        {
            DegreeConverter();

            ReadKey();
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
                    Write("Indtast et korrekt tal for at vælge: ");
                    input = ReadLine();
                }
                else
                {
                    return i;
                }
            }
            while (true);
        }

    }
} 
