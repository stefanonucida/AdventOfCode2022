System.Diagnostics.Stopwatch stopwatch = new();
string input = await File.ReadAllTextAsync("input.txt");  
stopwatch.Start();
var highest = 0;
foreach(string elf in input.Split("\n\n"))
{
    int subSum = elf.Split('\n').Sum(s=> int.Parse(s));
    if(subSum > highest) highest = subSum;
}
stopwatch.Stop();
System.Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds}ms");
System.Console.WriteLine(highest);  