/**
* titre : Dénombrements
* description : L'application permet de réaliser 3 calculs mathématiques : permutation, arrangement et combinaison
* Auteur : Cned
* Optimisation : CedUX
* date de création : 2020
* date de dernière modification : 05/11/2021
**/
using System;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///La fonction Saisie(texte lors de l'affichage utilisateur) permet à l'utilisateur de saisir un nombre entier et de tester une erreur de saisie avec le try and catch.
            ///</summary>
            int Saisie(string texte)
            {
                int saisie = 0;
                bool correct = false;
                while (!correct)
                {

                    try
                    {
                        // affichage utilisateur
                        Console.Write(texte);
                        saisie = int.Parse(Console.ReadLine()); // saisir le nombre
                        correct = true;

                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie veuillez réessayer\n... ");
                    }
                }
                return saisie;
            }
            //Déclaration variables
            string c = "1";
            int n, t;
            long r, r1, r2;
            while (c != "0")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = Console.ReadLine();

                switch (c)
                {
                    case "0":
                        Environment.Exit(0);
                        break;

                    case "1":
                        n = Saisie("nombre total d'éléments à gérer = ");
                        // calcul de r
                        r = 1;
                        for (int k = 1; k <= n; k++)
                            r *= k;
                        Console.WriteLine(n + "! = " + r);
                        break;

                    case "2":
                        t = Saisie("nombre total d'éléments à gérer = ");
                        n = Saisie("nombre d'éléments dans le sous ensemble = ");
                        // calcul de r
                        r = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r *= k;
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                        break;

                    case "3":
                        t = Saisie("nombre total d'éléments à gérer = ");
                        n = Saisie("nombre d'éléments dans le sous ensemble = ");
                        // calcul de r1
                        r1 = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r1 *= k;
                        // calcul de r2
                        r2 = 1;
                        for (int k = 1; k <= n; k++)
                            r2 *= k;
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                        break;

                    default:
                        Console.WriteLine("Erreur de saisie veuillez réessayer\n... ");
                        break;
                }

            }
            Console.ReadLine();
        }
    }
}
