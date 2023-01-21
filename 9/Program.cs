//Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());

if (number % 5 == 0 && number % 23 == 0)
   { Console.WriteLine("Кратно 5, некратно 23" );
   }
else if (number % 5 == 0)
    Console.WriteLine("Кратно 5, некратно 23");

else if (number % 23 == 0)
    Console.WriteLine("Кратно 23, некратно 5");
else{
Console.WriteLine("Некратно 5 и 23");
}
