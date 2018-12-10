using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CapstoneProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcomescreen();
            DisplayMainMenu();
            DisplayClosingScreen();

        }

       

        static void DisplayMainMenu()
        {
            string menuChoice;
            bool exiting = false;
            

            List<FavoriteGames> favoriteGames = new  List<FavoriteGames>();

            while (!exiting)
            {
                //
                // display menu
                //
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine();

                Console.WriteLine("\t1) Add a Favorite Game");
                Console.WriteLine("\t2) Display Current List of Games");
                Console.WriteLine("\t3) Display Game Info");
                Console.WriteLine("\t4) Remove a game from your list");
                Console.WriteLine("\t5) Search for commonalities between games");
                Console.WriteLine("\t6) Exit");
                Console.WriteLine();
                Console.Write("Enter Choice:");
                menuChoice = Console.ReadLine();

           
                
                switch (menuChoice)
                {
                    case "1":
                        DisplayAddGame(favoriteGames);
                        break;
                    case "2":
                        DisplayFavoriteGames(favoriteGames);
                        break;
                    case "3":
                        DisplayGameInfo(favoriteGames);
                        break;
                    case "4":
                        RemoveGaneFromList(favoriteGames);
                        break;
                    case "5":
                        DisplaySearchFunction(favoriteGames);
                        break;
                    case "6":
                        exiting = true;

                        break;
                    default:
                        break;
                }
            }
        }

      

        private static void RemoveGaneFromList(List<FavoriteGames> favoriteGames)
        {
            DisplayHeader("Remove a game from the list");
            string gameName;


            foreach (FavoriteGames favoriteGame in favoriteGames)
            {
                Console.WriteLine(favoriteGame.GameName);
            }
            Console.WriteLine();

            Console.WriteLine("Enter game name:");
            gameName = Console.ReadLine().ToUpper();

            bool found = false;
            foreach (FavoriteGames favoriteGame in favoriteGames)
            {
                if (favoriteGame.GameName == gameName)
                {
                    favoriteGames.Remove(favoriteGame);
                    found = true;
                    break;
                }
                else
                {
                    Console.WriteLine($"{gameName} could not be found!");
                }

                
            }




        }

        private static void DisplaySearchFunction(List<FavoriteGames> favoriteGames)
        {
            DisplayHeader("Search through your games based on developer or release year");
            string searchBy;

            Console.WriteLine("\ta) Developer");
            Console.WriteLine("\tb) Release Year");
            Console.WriteLine("\tc) Publisher");
            Console.WriteLine("\td) Return to main menu");
            searchBy = Console.ReadLine();
            switch (searchBy)
            {
                case "a":
                    SearchByDeveloper(favoriteGames);
                    break;
                case "b":
                    SearchByYear(favoriteGames);
                    break;
                case "c":
                    SearchByPublisher(favoriteGames);
                    break;
                case "d":
                     DisplayContinuePrompt();
                    break;
                default:
                    break;
            }
           
        }

        private static void SearchByPublisher(List<FavoriteGames> favoriteGames)
        {
            string gamePublisher;
            Console.WriteLine("Enter the Developer you wish to search by:");
            gamePublisher = Console.ReadLine().ToUpper();

            foreach (FavoriteGames favoriteGame in favoriteGames)
            {
                if (favoriteGame.Publisher == gamePublisher)
                {
                    Console.WriteLine(favoriteGame.GameName);

                }
            }

            DisplayContinuePrompt();
        }

        private static void SearchByYear(List<FavoriteGames> favoriteGames)
        {
            Console.WriteLine("Enter what year you would like to look for:");
            int.TryParse(Console.ReadLine(), out int gameYear);

            foreach (FavoriteGames favoriteGame in favoriteGames)
            {
                if (favoriteGame.GameReleaseYear == gameYear)
                {
                    Console.WriteLine(favoriteGame.GameName);

                }
            }

            DisplayContinuePrompt();

        }

        private static void SearchByDeveloper(List<FavoriteGames> favoriteGames)
        {
            string gameDeveloper;
            Console.WriteLine("Enter the Developer you wish to search by:");
            gameDeveloper = Console.ReadLine().ToUpper();

            foreach (FavoriteGames favoriteGame in favoriteGames)
            {
                if(favoriteGame.Developer == gameDeveloper)
                {
                    Console.WriteLine(favoriteGame.GameName);
                    
                }
            }

            DisplayContinuePrompt();


        }

        

        private static void DisplayGameInfo(List<FavoriteGames> favoriteGames)
        {
            DisplayHeader("Display a games info");
            string gameName;


            foreach (FavoriteGames favoriteGame in favoriteGames)
            {
                Console.WriteLine(favoriteGame.GameName);
            }
            Console.WriteLine();

            Console.WriteLine("Enter game name:");
            gameName = Console.ReadLine().ToUpper();

            

            foreach (FavoriteGames favoriteGame in favoriteGames)
            {
                if (favoriteGame.GameName == gameName)
                {
                    
                    Console.WriteLine($"\tRelease year: {favoriteGame.GameReleaseYear}");
                    Console.WriteLine($"\tDeveloper: {favoriteGame.Developer}");
                    Console.WriteLine($"\tPublisher: {favoriteGame.Publisher}");
                    Console.WriteLine($"\tMultiplayer: {favoriteGame.Multiplayer}");
                    Console.WriteLine($"\tCritic Reception: {favoriteGame.CriticReception}");
                    Console.WriteLine($"\tPersonal Rating: {favoriteGame.PersonalRating}");
                    Console.WriteLine($"\tWhy it made the list: {favoriteGame.Memories}");
                    break;
                }
            }


            DisplayContinuePrompt();
        }

        private static void DisplayDeleteGame(List<FavoriteGames> favoriteGames)
        {
            DisplayHeader("Delete a game from your list");

            

            foreach (FavoriteGames favoriteGame in favoriteGames)
            {
                Console.WriteLine(favoriteGame.GameName);
            }
            Console.WriteLine();

            Console.WriteLine("Enter the name of the game you wish to delete:");
            string gameName = Console.ReadLine().ToUpper();


            
            foreach (FavoriteGames favoriteGame in favoriteGames)
            {
                if (favoriteGame.GameName == gameName)
                {
                    favoriteGames.Remove(favoriteGame);
                    Console.WriteLine($"{gameName} successfully deleted from the list!");
                    
                    break;
                } 
            }

            DisplayContinuePrompt();
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
            int gameReleaseYear;
            int personalRating;

            DisplayHeader("Add a new game to the list");

            Console.WriteLine("Enter the name of the game:");
            userFavoriteGame.GameName = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter the year the game was released:");
            while(!int.TryParse(Console.ReadLine(), out gameReleaseYear))
            {
                Console.WriteLine("Please enter a valid number!");
            }
            userFavoriteGame.GameReleaseYear = gameReleaseYear;
            
            Console.WriteLine("Enter the name of the developer (Not the publisher)");
            userFavoriteGame.Developer = Console.ReadLine().ToUpper();

            Console.WriteLine("Now enter the name of the publisher:");
            userFavoriteGame.Publisher = Console.ReadLine().ToUpper();

            Console.WriteLine("Does the game have a multiplayer function:");
            if (Console.ReadLine().ToUpper() == "YES")
            {
                userFavoriteGame.Multiplayer = true;
            }
            else
            {
                userFavoriteGame.Multiplayer = false;
            }

            Console.WriteLine("Enter the Critical Reception of the game(Bad, Average, Good, Masterpiece):");
            Enum.TryParse(Console.ReadLine(), out FavoriteGames.GameCriticReception reception);
            userFavoriteGame.CriticReception = reception;

            Console.WriteLine("Enter your personal rating for the game (on a scale of 1-10):");
            while(!int.TryParse(Console.ReadLine(), out personalRating))
            {
                Console.WriteLine("Please enter a valid number!");
            }
            userFavoriteGame.PersonalRating = personalRating;

            Console.WriteLine("What makes this game a favorite:");
            userFavoriteGame.Memories = Console.ReadLine();
            
            favoriteGames.Add(userFavoriteGame);

            DisplayContinuePrompt();
            

        }
        #region HELPER METHODS
        static void DisplayWelcomescreen()
        {
            Console.WriteLine("Welcome to the favorite game compiler");
            Console.WriteLine();
            Console.WriteLine("In this application you will add your favorite games to a list and be able to filter them by different characterisitics");
            Console.WriteLine();
            Console.WriteLine("Authored by Jared Heimforth for CIT 110");
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

        private static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using my application!");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit the application.");
            Console.ReadLine();
        }

        #endregion
    }

}
