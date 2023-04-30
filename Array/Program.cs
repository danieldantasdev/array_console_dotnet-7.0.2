//Array
var numbers = new int[10] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var numbersCopy = new int[10];

var numbersString = ("0 1 2 3 4 5 6 7 8 9 10").Split(" ");
var numbersConvert = Array.ConvertAll(numbersString, Convert.ToInt32);

for (var i = 0; i < numbers.Length; i++)
{
    numbersCopy[i] = numbers[i];
    // Console.WriteLine(numbers[i]);
}

//List
var list = new List<int> { 0, 1, 2, 3, 4 };
var listFromArray = new List<int>(numbers);

list.Add(5);
list.AddRange(new List<int> { 6, 7 });
list.AddRange(new int[] { 8, 9 });

//Count
var count = list.Count;
var contains = list.Contains(12);

//Reverse
Console.WriteLine("List reverse");
list.Reverse();
list.ForEach(l => Console.WriteLine(l));

Console.WriteLine("List ordered");
list.Sort();
list.ForEach(l => Console.WriteLine(l));

//Remove
list.Remove(4);
list.RemoveAll(l => l > 5);

//Clear
list.Clear();