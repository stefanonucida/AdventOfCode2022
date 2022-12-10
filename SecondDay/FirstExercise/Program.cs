
System.Diagnostics.Stopwatch sw = new();
string input = await File.ReadAllTextAsync("input.txt");
sw.Start();
var rounds = input.Split('\n'); 
int partialScore = 0; 
foreach (var round in rounds)
{
    partialScore += getVictory(round[0], round[2]);
    partialScore += getBase(round[2]);
} 
sw.Stop(); 
System.Console.WriteLine($"Total points: {partialScore}");
System.Console.WriteLine($"Time Elapsed: {sw.ElapsedMilliseconds}ms"); 

int getVictory(char him, char me)
{
    if (him == 'A')
    {
        switch (me)
        {
            case 'X': return 3;
            case 'Y': return 6;
            case 'Z': return 0;
        }
    }

    if (him == 'B')
    {
        switch (me)
        {
            case 'X': return 0;
            case 'Y': return 3;
            case 'Z': return 6;
        }
    }

    if (him == 'C')
    {
        switch (me)
        {
            case 'X': return 6;
            case 'Y': return 0;
            case 'Z': return 3;
        }
    } 

    return 0;
}

int getBase(char figure) => figure == 'X' ? 1 : figure == 'Y' ? 2 : 3;