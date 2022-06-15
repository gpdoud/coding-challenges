// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Collections.Generic;

List<List<int>> arr = new() {
    new List<int> { 1,7,8,7,5,5,7,3,2,3 },
    new List<int> { 1,5,1,6,4,7,3,1,7,2 },
    new List<int> { 4,1,2,5,9,6,8,6,8,4 },
    new List<int> { 5,2,4,2,6,3,9,6,7,6 }, 
    new List<int> { 5,6,2,7,8,4,4,4,6,8 }
};

foreach (var lst in arr)
{
    Console.WriteLine(SmallestMax(lst));
}

int SmallestMax(List<int> arr)
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