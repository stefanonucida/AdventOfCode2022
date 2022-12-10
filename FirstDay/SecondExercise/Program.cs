System.Diagnostics.Stopwatch stopwatch = new();
var input = await File.ReadAllTextAsync("input.txt"); 
PriorityQueue<int,int> q = new();
stopwatch.Start();
foreach(var cal in input.Split("\n\n"))
{
    int subSum = cal.Split("\n").Sum(s=> int.Parse(s)); 
    if(q.Count<3)
    {
        q.Enqueue(subSum,subSum);
    }
    else
    {
        q.EnqueueDequeue(subSum,subSum);
    } 
}
int totalValue = q.UnorderedItems.Sum(s => s.Element);
stopwatch.Stop(); 
System.Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds}ms");
System.Console.WriteLine(totalValue);

 