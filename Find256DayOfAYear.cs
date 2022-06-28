static class First256DayOfAYear
{

    static void Run()
    {

        Console.WriteLine("Ready!");

        int[] years = { 1918, 1996, 2000, 2001, 2100, 2104 };

        foreach (var yr in years)
        {
            Console.WriteLine($"Year: {yr}, date: {GetDateOfDay256(yr)}");
        }
    }

    static string GetDateOfDay256(int year)
    {
        if (year == 1918)
            return "26.09.1918";
        else if (((year <= 1917) && (year % 4 == 0)) || ((year > 1918) && (year % 400 == 0 || ((year % 4 == 0) && (year % 100 != 0)))))
            return $"12.09.{year}";
        else
            return $"13.09.{year}";

    }


}