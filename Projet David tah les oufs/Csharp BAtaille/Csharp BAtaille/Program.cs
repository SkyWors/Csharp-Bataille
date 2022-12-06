using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_BAtaille
{
    internal class Program
    {
        public const int SEPT = 7, HUIT = 8, NEUF = 9, DIX = 10, VALET = 11, DAME = 12, ROI = 13, AS = 14;
        public const int PIQUE = 0, COEUR = 1, CARREAU = 2, TREFLE = 3; // couleurs
        public static int[] carte = new int[32];
        public static int[] couleur = new int[32];
        public static int[] card = new int[32];

        static class global
        {        
            public static Stack player1 = new Stack();
            public static Stack player2 = new Stack();

            public static int[] randomSlot = new int[32];
        }


        static void CreerCartes()
        {
            int i = 0; //Int i = 0 // indice de la carte
            for (int c = 0; c < 4; c++)
            { // For(int c = 0; c < 4; c++) // pour chaque couleur
                for (int f = 7; f < 15; f++)
                {  // For(int f = 7 ; f < 15; f++) // pour chaque figure
                    carte[i] = f;   // Carte[i] = f   // sa figure
                    couleur[i] = c; // sa couleur
                    i++;
                }
            }
        }// fin creercarte

     
        static string translateCard(int number)
        {
            string figure = carte[number].ToString();
            switch (carte[number])
            {
                case VALET:
                    figure = "VALET";
                    break;
                case DAME:
                    figure = "DAME";
                    break;
                case ROI:
                    figure = "ROI";
                    break;
                case AS:
                    figure = "AS";
                    break;
            }

            string color = "";
            switch (couleur[number])
            {
                case PIQUE:
                    color = "PIQUE";
                    break;
                case CARREAU:
                    color = "CARREAU";
                    break;
                case COEUR:
                    color = "COEUR";
                    break;
                case TREFLE:
                    color = "TREFLE";
                    break;
            }

            return (figure + " de " + color);
        }

        static void addCard()
        {
            int j = 0;
            for (int i = 0; i < 32; i++)
            {
                if (j % 8 == 0) Console.WriteLine();

                card[i] = i;
                j++;
            }
        }

        static void displayCard()
        {
            for(int a = 0; a < 32; a++)
            {
                Console.Write(" {0} ", translateCard(card[a]));
            }
        }

        static void addcardtoplayer(Stack player)
        {           
            Random rnd = new Random();

            int a = 0;
            while (a < 16)
            {
                int randomCard = rnd.Next(32);
                if (!(global.randomSlot.Contains(randomCard)))
                {
                    player.Push(card[randomCard]);
                    global.randomSlot[randomCard] = randomCard;
                    a++;
                }
            }

            foreach (int items in player)
                Console.WriteLine("Le joueur a ses cartes : - {0} ", translateCard(items));

            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            foreach (int items in card)
            {
                global.randomSlot[items] = -1;
            }

            CreerCartes();
            addCard();

            displayCard();

            addcardtoplayer(global.player1);
            addcardtoplayer(global.player2);

            Console.WriteLine("le joueur 1 a {0} de cartes", global.player1.Count);
            Console.WriteLine("le joueur 2 a {0} de cartes", global.player2.Count);

            Console.ReadKey();
        }
    }
}
