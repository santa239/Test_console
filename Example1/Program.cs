Console.WriteLine("Program started");
var data = "abacb";
PrintSubstrings(data);
Console.ReadKey();


static void PrintSubstrings(string fullstring)
{
    if (string.IsNullOrEmpty(fullstring))
        Console.WriteLine("string is empty");

    if (fullstring.Length < 2)
        Console.WriteLine("string length isn't enough");

    for(int i = 1; i < fullstring.Length - 1; i++)
    {
        var left = fullstring.Substring(0, i);
        var right = fullstring.Substring(i, fullstring.Length - i - 1);
        var leftCount = GetDifferentCharsCount(left);
        var rightCount = GetDifferentCharsCount(right);
        if (leftCount == rightCount)
            Console.WriteLine($"{left} - {right}");
    }
}

static int GetDifferentCharsCount(string str)
{
    var listDifferentChars = new List<char>();
    foreach(var ch in str.ToCharArray())
    {
        if(!listDifferentChars.Contains(ch))
            listDifferentChars.Add(ch);
    }
    return listDifferentChars.Count();
}




