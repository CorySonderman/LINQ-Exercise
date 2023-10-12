namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
            {
                "Super Mario Brothers",
                "Pong",
                "Space Invaders",
                "Asteroids",
                "Pitfall",
                "Joust",
                "Def Jam Vendetta",
                "Pac-Man",
                "Rampage",
                "Utopia(Intellivision)",
            };
            // That's ugly!!! Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Yes, I really am that old!");           
            Console.WriteLine();

            var gamesAscending = videoGames
                .OrderBy(game => game.Length)
                .ThenBy(game => game)
                .Select(game => game.ToLower())
                .ToList();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ascending:");
            foreach (var game in gamesAscending)
            {
                Console.WriteLine(game);
            }

            var gamesDescending = videoGames
                .OrderBy(game => game.Length)
                .ThenByDescending(game => game)
                .Select(game => game.ToUpper())
                .ToList();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nDescending:");
            foreach (var game in gamesDescending)
            {
                Console.WriteLine(game);
            }

            var gamesAlphabetical = videoGames
                .OrderBy(game => game)
                .ThenBy(game => game.Length)
                .ToList();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nAlphabetically:");
            foreach (var game in gamesAlphabetical)
            {
                Console.WriteLine(game);
            }

            int gameCountAscending = gamesAscending.Count;
            //int gameCountDescending = gamesDescending.Count;
            //int gameCountAlphabetical = gamesAlphabetical.Count;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Total Games Count: {gameCountAscending}");
            //Console.WriteLine($"Total Games Count: {gameCountDescending}");
            //Console.WriteLine($"Total Games Count: {gameCountAlphabetical}");
            Console.ResetColor();
        }
    }
}
