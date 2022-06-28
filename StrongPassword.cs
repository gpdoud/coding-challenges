static class StrongPassword
{

    static int MinCharsForStrongPassword(string password)
    {
        bool IsSpecial(char ch) {
            var specialcharacters = "!@#$%^&*()-+";
            return specialcharacters.Contains(ch);
        }

        bool digit = false;
        bool lowercase = false;
        bool uppercase = false;
        bool special = false;
        int remaining = 4;
        foreach (var ch in password.ToCharArray())
        {
            if (!digit && char.IsDigit(ch)) { digit = true; remaining--; }
            if (!lowercase && char.IsLower(ch)) { lowercase = true; remaining--; }
            if (!uppercase && char.IsUpper(ch)) { uppercase = true; remaining--; }
            if (!special && IsSpecial(ch)) { special = true; remaining--; }
        }
        var minLen = 6 - password.Length;
        return minLen > remaining ? minLen : remaining;
    }
    static void main()
    {
        string[] passwords = { "Ab1", "2bbbb", "2bb#A", "#HackerRank" };
        foreach(var str in passwords)
            Console.WriteLine($"password {str} needs {MinCharsForStrongPassword(str)} character(s).");
    }
}