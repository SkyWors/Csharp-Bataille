using System;
using System.Runtime.ConstrainedExecution;

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

        public static string translate(int number)
        {
            string figure = global.carte[number].ToString();
            switch (global.carte[number])
            {
                case global.VALET:
                    figure = "VALET";
                    break;
                case global.DAME:
                    figure = "DAME";
                    break;
                case global.ROI:
                    figure = "ROI";
                    break;
                case global.AS:
                    figure = "AS";
                    break;
            }

            string color = "";
            switch (global.couleur[number])
            {
                case global.PIQUE:
                    color = "PIQUE";
                    break;
                case global.CARREAU:
                    color = "CARREAU";
                    break;
                case global.COEUR:
                    color = "COEUR";
                    break;
                case global.TREFLE:
                    color = "TREFLE";
                    break;
            }

            return (figure + " de " + color);
        }
    }
}
