// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Collections.Generic;

/*
Find the lowest value with highest frequency
 
From a List<int> return the number that occurs the most times and if more than 
one number occur the same amount of times, return the smaller of the numbers.
 
For example, the List<int> i.e. { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 }
 
The numbers 3 and 4 both occur 3 times each.
 
Return 3 because it is smaller.
*/
static class LowestValueHighestFrequency
{

    static List<List<int>> arr = new() {
        new List<int> { 1,7,8,7,5,5,7,3,2,3 },
        new List<int> { 1,5,1,6,4,7,3,1,7,2 },
        new List<int> { 4,1,2,5,9,6,8,6,8,4 },
        new List<int> { 5,2,4,2,6,3,9,6,7,6 },
        new List<int> { 5,6,2,7,8,4,4,4,6,8 }
    };

    static void Run()
    {

        foreach (var lst in arr)
        {
            Console.WriteLine(SmallestMax(lst));
        }
    }

    static int SmallestMax(List<int> arr)
    {
        // write code here
        SortedList<int, int> list = new();
        foreach (var item in arr)
        {
            if (!list.ContainsKey(item))
            {
                list[item] = 0;
            }
            list[item]++;
        }
        var anskey = 0;
        var max = 0;
        foreach (var key in list.Keys)
        {
            if (list[key] > max)
            {
                anskey = key;
                max = list[key];
            }
        }
        return anskey;
    }
}