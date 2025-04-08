// Unique Number Entry System using C#


List<int> numbers = new List<int>();
string input;
int countnumbers;
do
{
    Console.WriteLine("Enter number(type 'exit' to stop)");
    input = Console.ReadLine();
    if (input.ToLower() == "exit")
        break;
    countnumbers = Convert.ToInt32(input);
    numbers.Add(countnumbers);
} while (true);
numbers = numbers.Distinct().ToList();
Console.WriteLine("unique number entered:" + string.Join(",", numbers));