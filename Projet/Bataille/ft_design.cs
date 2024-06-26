﻿using System;

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
            if (number == -1)
                return "\t\t";
            else
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

                    case global.SEPT:
                        figure = "SEPT";
                        break;
                    case global.HUIT:
                        figure = "HUIT";
                        break;
                    case global.NEUF:
                        figure = "NEUF";
                        break;
                    case global.DIX:
                        figure = "DIX";
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
}
