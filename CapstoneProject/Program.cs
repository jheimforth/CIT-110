using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcomescreen();
            DisplayMainMenu();
            

        }


        static void DisplayMainMenu()
        {
            string menuChoice;
            bool exiting = false;
            List<FavoriteGames> favoriteGames = new  List<FavoriteGames>();



            string dataPath = @"Data\\Data.txt";

            while (!exiting)
            {
                //
                // display menu
                //
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine();

                Console.WriteLine("\t1) Add a favorite Game");
                Console.WriteLine("\t2) Display Current List of Games");
                Console.WriteLine("\t3) ");
                Console.WriteLine("\t4) ");
                Console.WriteLine("\t5) ");
                Console.WriteLine("\t6) ");
                Console.WriteLine("\tE) Exit");
                Console.WriteLine();
                Console.Write("Enter Choice:");
                menuChoice = Console.ReadLine();

                //
                // process menu
                //
                switch (menuChoice)
                {
                    case "1":
                        DisplayAddGame(favoriteGames);
                        break;
                    case "2":
                        DisplayFavoriteGames(favoriteGames);
                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":

                        break;
                    case "6":


                        break;


                    case "e":
                    case "E":
                        exiting = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private static void DisplayFavoriteGames(List<FavoriteGames> favoriteGames)
        {
            DisplayHeader("List of Current Favorite Games");

            foreach (FavoriteGames favoriteGame in favoriteGames)
            {
                Console.WriteLine(favoriteGame.FavoriteGameReception());
            }

            DisplayContinuePrompt();
        }

        private static void DisplayAddGame(List<FavoriteGames> favoriteGames)
        {
            FavoriteGames userFavoriteGame = new FavoriteGames();

            DisplayHeader("Add a new game to the list");

            Console.WriteLine("Enter the name of the game:");
            userFavoriteGame.GameName = Console.ReadLine();

            Console.WriteLine("Enter the year the game was released:");
            double.TryParse(Console.ReadLine(), out double gameReleaseYear);
            userFavoriteGame.GameReleaseYear = gameReleaseYear;

            Console.WriteLine("Enter the name of the developer (Not the publisher)");
            userFavoriteGame.Developer = Console.ReadLine();

            Console.WriteLine("Enter the Average Critical Reception of the game:");
            Enum.TryParse(Console.ReadLine(), out FavoriteGames.GameCriticReception reception);
            userFavoriteGame.CriticReception = reception;

            Console.WriteLine("Enter your personal rating for the game:");
            double.TryParse(Console.ReadLine(), out double personalRating);
            userFavoriteGame.PersonalRating = personalRating;

            favoriteGames.Add(userFavoriteGame);

            DisplayContinuePrompt();
            

        }
        #region HELPER METHODS
        static void DisplayWelcomescreen()
        {
            Console.WriteLine("Welcome to the favorite game compiler");
            Console.WriteLine();
            Console.WriteLine("In this application you will add your favorite games to a list and save them to a text file if desired");
            DisplayContinuePrompt();
        }


        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static void DisplayHeader(string headerTitle)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerTitle);
            Console.WriteLine();
        }
        #endregion
    }

}
