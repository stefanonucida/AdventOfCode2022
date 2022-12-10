System.Diagnostics.Stopwatch sw = new();
string input = await File.ReadAllTextAsync("input.txt"); 
var ruckSacks = input.Split('\n');

FirstExercise(ruckSacks);
SecondExercise(ruckSacks);

int smallAAscii;
int bigAAscii;

void FirstExercise(string[] ruckSacks)
{
    sw.Start();
    smallAAscii = System.Text.UTF8Encoding.ASCII.GetBytes("a").First();
    bigAAscii = System.Text.UTF8Encoding.ASCII.GetBytes("A").First();
    int prioritySum = 0; 
    foreach (var ruckSack in ruckSacks)
    { 
        List<char> firstHalf = ruckSack.Substring(0,ruckSack.Length/2).ToList();
        List<char> secondHalf = ruckSack.Substring(ruckSack.Length/2).ToList();
        List<char> calculatePriority = new();
        prioritySum += firstHalf.Intersect(secondHalf).Where(w => !calculatePriority.Contains(w)).Sum(s=> getPriorityFromChar(s)); 
    } 
    System.Console.WriteLine(prioritySum);
    sw.Stop();
    System.Console.WriteLine($"Elapsed Time: {sw.ElapsedMilliseconds}ms");
    sw.Reset(); 
}

int getPriorityFromChar(char ch) => 
    System.Text.UTF8Encoding.ASCII.GetBytes(ch.ToString()).First() - (ch.ToString() == ch.ToString().ToLower() ? (smallAAscii - 1) : (bigAAscii - 27)); 

void SecondExercise(string[] ruckSacks)
{ 
    sw.Start();  

    sw.Stop();
    System.Console.WriteLine($"Elapsed Time: {sw.ElapsedMilliseconds}ms");
    sw.Reset();
}