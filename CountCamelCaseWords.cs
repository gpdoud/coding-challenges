static class CountCamelCaseWords
{

    static int CountWords(string str)
    {
        List<int> indexes = new();
        char[] chr = str.ToCharArray();
        for(var i = 0; i < chr.Length; i++) {
            if(char.IsUpper(chr[i]))
                indexes.Add(i);
        }
        return indexes.Count + 1;
    }
    static void main()
    {

        string[] strings = { "aBigString", "saveChangesInTheEditor", "thisStringHasLotsOfWordWithinIt" };
        foreach (var s in strings)
        {
            Console.WriteLine($"String: {s} has {CountWords(s)} words.");
        }
    }
}

