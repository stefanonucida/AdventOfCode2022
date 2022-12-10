
System.Diagnostics.Stopwatch sw = new();
string input = await File.ReadAllTextAsync("../input.txt");
sw.Start();
var rounds = input.Split('\n'); 
int partialScore = 0; 
foreach (var round in rounds)
{
    partialScore += getVictory(round);
    partialScore += getBase(round[2]);
} 
sw.Stop(); 
System.Console.WriteLine($"Total points: {partialScore}");
System.Console.WriteLine($"Time Elapsed: {sw.ElapsedMilliseconds}ms"); 

int getVictory(string round)
{
    var hisCode = System.Text.UTF8Encoding.ASCII.GetBytes(round, 0,1).First();
    var myCode = System.Text.UTF8Encoding.ASCII.GetBytes(round, 2,1).First();
    var delta = myCode-hisCode;
    if(delta == 22 || delta == 25) return 0;
    if(delta == 24 || delta == 21) return 6; 
    return 3;
}

int getBase(char figure) => figure == 'X' ? 1 : figure == 'Y' ? 2 : 3;