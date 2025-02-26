//using C34PracticeLinqExercise;


List<string> NintendoGames = new List<string>() { "PaperBoy,", "MarioBrothers", "Zelda" };

NintendoGames.Add("Mike Tyson Punch out");
NintendoGames.Add("Contra");

var orderedGames = NintendoGames.OrderBy(name => name.Length);

foreach (var game in orderedGames)
{
    Console.WriteLine(game);
}
