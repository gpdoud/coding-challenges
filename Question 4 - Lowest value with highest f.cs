/*

Question 4 - Lowest value with highest frequency

From a List<int> return the number that occurs the most times and if more than 
one number occur the same amount of times, return the smaller of the numbers.

For example, the List<int> i.e. { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 }

The numbers 3 and 4 both occur 3 times each.

Return 3 because it is smaller.

List<List<int>> arr = new() {
    new List<int> { 1,7,8,7,5,5,7,3,2,3 },
    new List<int> { 1,5,1,6,4,7,3,1,7,2 },
    new List<int> { 4,1,2,5,9,6,8,6,8,4 }
};

foreach(var lst in arr) {
    Console.log(SmallestMax(lst));
}

int SmallestMax(IEnumberable<int> arr) {
    // write code here
}

*/