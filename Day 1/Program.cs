var values = new StreamReader("input.txt").ReadToEnd().Split('\n').ToList();
var elves = new Dictionary<int, int>();
var curElf = 0;
foreach (var value in values)
{
    if (value == "")
    {
        curElf++;
        continue;
    }

    if (elves.ContainsKey(curElf))
    {
        elves[curElf] += int.Parse(value);
    }
    else
    {
        elves.Add(curElf, int.Parse(value));
    }
}

// 1
Console.WriteLine(elves.Max(x => x.Value));
// 2
Console.WriteLine(elves.OrderByDescending(x => x.Value).Take(3).Sum(x => x.Value));