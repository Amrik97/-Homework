//Удалить вторую цифру трёхзначного числа
Console.Write("Text a number: ");
int number = Convert.ToInt32(Console.ReadLine());
string number2Text = Convert.ToString(number);
if (number2Text.Length > 2){
  Console.WriteLine("second number is " + number2Text[0]+number2Text[2]);
}
else {
  Console.WriteLine("no second number");
}