Student Record Entry System using C#:

List<int> mark = new List<int>();
string input;
int number;
do
{
    Console.WriteLine("Enter name (or type 'exit' to stop):");
    input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;  // Stop the loop before asking for marks

    Console.WriteLine("Enter number:");
    number = Convert.ToInt32(Console.ReadLine());

    name.Add(input);
    mark.Add(number);

} while (true);
Console.WriteLine("Details of student name and mark");
for (int i = 0; i < name.Count; i++)
{
    Console.WriteLine($"Student Name: {name[i]}, Mark: {mark[i]}");
}