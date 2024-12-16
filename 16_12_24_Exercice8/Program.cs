using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialisation des variables
            int taille = 0;
            int poids = 0;

            //Affichage des requêtes pour l'entrer par l'utilisateur de sa taille et son poids
            Console.Write("---Quelle taille dois-je prendre ?---\n\nEntrez votre taille (en cm) : ");
            taille = int.Parse(Console.ReadLine());
            Console.Write("Entrez votre poids (en kg) : ");
            poids = int.Parse(Console.ReadLine());
            Console.Write("\n");

            //Exclusion des valeurs en dehors du tableau
                if (taille < 145 || taille > 183 || poids < 43 || poids > 77)
                {
                    Console.WriteLine("Aucune taille ne vous correspond.");
                }
                else
                {

                switch (poids)
                {
                    case <= 47: //Calcul pour la première ligne
                        if (taille < 172) 
                        {
                            Console.WriteLine("Prenez la taille 1.");
                        }
                        else
                        {
                            Console.WriteLine("Aucune taille ne vous correspond.");
                        }; break;

                    case <= 53: //Calcul pour la deuxième ligne
                        if (taille < 169)
                        {
                            Console.WriteLine("Prenez la taille 1.");
                        }
                        else if (taille >= 169 && taille < 183)
                        {
                            Console.WriteLine("Prenez la taille 2.");
                        }
                        else
                        {
                            Console.WriteLine("Aucune taille ne vous correspond.");
                        }; break;

                    case <= 59: //Calcul pour la troisième ligne
                        if (taille < 166)
                        {
                            Console.WriteLine("Prenez la taille 1.");
                        }
                        else if (taille >= 166 && taille < 178)
                        {
                            Console.WriteLine("Prenez la taille 2.");
                        }
                        else
                        {
                            Console.WriteLine("Prenez la taille 3.");
                        }; break;

                    case <= 65: //Calcul pour la quatrième ligne
                        if (taille < 163)
                        {
                            Console.WriteLine("Prenez la taille 1.");
                        }
                        else if (taille >= 163 && taille < 175)
                        {
                            Console.WriteLine("Prenez la taille 2.");
                        }
                        else
                        {
                            Console.WriteLine("Prenez la taille 3.");
                        }; break;

                    case <= 71: //Calcul pour la cinquième (avant-dernière) ligne
                        if (taille < 160)
                        {
                            Console.WriteLine("Aucune taille ne vous correspond.");
                        }
                        else if (taille >= 160 && taille < 172)
                        {
                            Console.WriteLine("Prenez la taille 2.");
                        }
                        else
                        {
                            Console.WriteLine("Prenez la taille 3.");
                        }; break;

                    case <= 77: //Calcul pour la sixième (dernière) ligne
                        if (taille < 163)
                        {
                            Console.WriteLine("Aucune taille ne vous correspond.");
                        }
                        else
                        {
                            Console.WriteLine("Prenez la taille 3.");
                        }; break;
                };
            };

        }
    }
}