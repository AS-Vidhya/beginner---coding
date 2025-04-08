// Program to store and display odd numbers entered by the user


List<int> number = new List<int>();
string input;
int oddNumber;
do
{
    Console.WriteLine("Enter number(type 'exit' to stop)");
    input = Console.ReadLine();
    if (input.ToLower() == "exit")
        break;
    oddNumber = Convert.ToInt32(input);
    if (oddNumber % 2 != 0)
    {
        Console.WriteLine(oddNumber + "is an odd number");
        number.Add(oddNumber);
    }
    else
    {
        Console.WriteLine(oddNumber + "is an even number");
    }
} while (true);
Console.WriteLine("the odd number is" + string.Join(",", number));
