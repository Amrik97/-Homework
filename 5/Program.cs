//Показать последнюю цифру трёхзначного числа
Console.Write("Text a number: ");
int number = Convert.ToInt32(Console.ReadLine());
string number2Text = Convert.ToString(number);
if (number2Text.Length > 2){
  Console.WriteLine("third number is " + number2Text[2]);
}
else {
  Console.WriteLine("-> no third number");
}