using System.Diagnostics.Metrics;

// Frequency Counter / Multiple Pointers - areThereDuplicates
// Implement a function called, areThereDuplicates which accepts a variable number of arguments, and checks whether there are any duplicates among the arguments passed in.
// You can solve this using the frequency counter pattern OR the multiple pointers pattern.
//
// Examples:
//
// areThereDuplicates(1, 2, 3) // false
// areThereDuplicates(1, 2, 2) // true 
// areThereDuplicates('a', 'b', 'c', 'a') // true 
// Restrictions:
//
// Time - O(n)
//
// Space - O(n)
//
// Bonus:
//
// Time - O(n log n)
//
// Space - O(1)

areThereDuplicates(1, 2, 3); // false

void areThereDuplicates(params object[] args)
{
    var freq = new Dictionary<object, int>();
    foreach (var  arg in args)
    {
        if (freq.ContainsKey(arg))
        {
            //Console.WriteLine(freq);
            //return;
            freq[arg] += 1;
        }
        freq[arg] = 1;
    } 
    Console.WriteLine(freq);
    foreach (var kvp in freq)
    {
        Console.Write($"Key: {kvp.Key}, Value: {kvp.Value}");
    }

}