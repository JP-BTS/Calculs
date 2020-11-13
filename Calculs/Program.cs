/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 */
using System;
using System.Linq;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse; // saisie de la réponse de l'utilisateur
            string check; // saisie du choix de l'utilsiateur puis verif
            int choix; // saisie du choix de l'utilsiateur

            // boucle sur le menu
            choix = 1;
            while (choix != 0)
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                check = Console.ReadLine();

                if (check.All(char.IsDigit))
                {
                    choix = int.Parse(check);

                    switch (choix)
                    {
                        case 1:
                            // choix de l'addition
                            val1 = rand.Next(1, 10);
                            val2 = rand.Next(1, 10);
                            // saisie de la réponse
                            Console.Write(val1 + " + " + val2 + " = ");

                            check = Console.ReadLine();
                            
                            solution = val1 + val2;

                            if (check.All(char.IsDigit))
                            {
                                reponse = int.Parse(check);

                                // comparaison avec la bonne réponse
                                if (reponse == solution)
                                {
                                    Console.WriteLine("Bravo !");
                                }
                                else
                                {
                                    Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                                Console.WriteLine("erreur de saisie");
                            }


                            break;

                        case 2:
                            // choix de la multiplication
                            val1 = rand.Next(1, 10);
                            val2 = rand.Next(1, 10);

                            // saisie de la réponse
                            Console.Write(val1 + " x " + val2 + " = ");

                            check = Console.ReadLine();
                                
                            solution = val1 * val2;

                            if (check.All(char.IsDigit))
                            {
                                reponse = int.Parse(check);


                                
                                // comparaison avec la bonne réponse
                                if (reponse == solution)
                                {
                                    Console.WriteLine("Bravo !");
                                }
                                else
                                {
                                    Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                                Console.WriteLine("erreur de saisie");
                            }


                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("erreur de saisie 12");
                            break;

                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("erreur de saisie");
                }
                    
                
            }
        }
    }
}
