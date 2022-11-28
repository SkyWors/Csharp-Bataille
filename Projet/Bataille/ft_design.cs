using System;

namespace Bataille
{
    class ft_design
    {
        public static void design(string arg, Boolean line)
        {
            if (line == true)
                Console.WriteLine($"  |  {arg}");
            else
                Console.Write($"{arg}");
        }

        public static string translate(int value, string type)
        {
            if (type == "card")
            {
                switch (value)
                {
                    case 2:
                        return ("DEUX ");
                    case 3:
                        return ("TROIS ");
                    case 4:
                        return ("QUATRE ");
                    case 5:
                        return ("CINQ ");
                    case 6:
                        return ("SIX ");
                    case 7:
                        return ("SEPT ");
                    case 8:
                        return ("HUIT ");
                    case 9:
                        return ("NEUF ");
                    case 10:
                        return ("DIX ");
                    case 11:
                        return ("VALET ");
                    case 12:
                        return ("DAME ");
                    case 13:
                        return ("ROI ");
                    case 14:
                        return ("AS ");
                }
            }
            else
            {
                switch (value)
                {
                    case 0:
                        return ("PIQUE ");
                    case 1:
                        return ("CARREAU");
                    case 2:
                        return ("COEUR ");
                    case 3:
                        return ("TREFLE ");
                }
            }
            return ("null");
        }
    }
}
