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

     
        static string AfficherCarte(int pi)
        {
            int fig = carte[pi];
            string figure = fig.ToString();



            if (fig == VALET) figure = "VALET";
            if (fig == DAME) figure = "DAME";
            if (fig == ROI) figure = "ROI";
            if (fig == AS) figure = "AS";



            int coul = couleur[pi];
            string colori = "";



            if (coul == PIQUE) colori = "pique";
            if (coul == CARREAU) colori = "carreau";
            if (coul == COEUR) colori = "coeur";
            if (coul == TREFLE) colori = "trefle";



            return (figure + " de " + colori);
        }



        /// <summary>
        /// AfficherLesCartes : affiche toutes les cartes du jeu 
        /// </summary>
        static void AfficherLesCartes()
        {
            int j = 0;
            for (int i = 0; i < 32; i++)
            {
                if (j % 8 == 0) Console.WriteLine();
                Console.Write("{0}\n", AfficherCarte(i));
                card[i] = i;

                j++;


            }

            Console.WriteLine("Voici toutes les cartes du jeu fusionné : ");
            for(int a = 0; a < 32; a++)
            {

                Console.Write(" {0} ", AfficherCarte(card[a]));
            }



        }



        static void addcardtoplayer(Stack player)
        {
            
            Random rnd = new Random();
 
                
            for (int a = 0; a < 16; a++)
            {
                int randomcard = rnd.Next(0, card.Length);
                player.Push(card[randomcard]);

            }                
            checkCard(global.player1, global.player2);


            foreach (int items in global.player1)
                Console.WriteLine("Le joueur 1 a ces cartes : - {0} ", AfficherCarte(items));
            Console.WriteLine("le joueur 1 a {0} de cartes", global.player1.Count);

            foreach (int item in global.player2)
                Console.WriteLine("Le joueur 2 a ces cartes - {0}", AfficherCarte(item));

        }

        static void checkCard(Stack player1, Stack player2)
        {
            foreach(int items in global.player1)
            {
            if(player1.Contains(global.player2))
                   addcardtoplayer(player1);

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine(PIQUE);

 
            CreerCartes();
            AfficherLesCartes();           
            addcardtoplayer(global.player1);

            addcardtoplayer(global.player2);

            Console.ReadKey();
        }
    }
}
