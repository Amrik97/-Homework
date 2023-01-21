//По заданному номеру дня недели вывести его название
Console.Write("Choose a number of a day: ");
int day = int.Parse(Console.ReadLine());
switch (day) 
{
    case 1: Console.WriteLine ("Monday"); 
    break;
    case 2: Console.WriteLine ("Tuesday"); 
    break;
    case 3: Console.WriteLine ("Wednesday"); 
    break;
    case 4: Console.WriteLine ("Thursday"); 
    break;
    case 5: Console.WriteLine ("Friday"); 
    break;
    case 6: Console.WriteLine ("Saturday");
    break;
    case 7: Console.WriteLine ("Sunday"); 
    break;
}
    if (day == 6 || day == 7) 
    {
        Console.WriteLine("You shoudn't go to work");
        }
    else {
        Console.WriteLine("You should go to work");
        }