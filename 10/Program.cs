//Найти третью цифру числа или сообщить, что её нет
Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string number2Text = Convert.ToString(number);
if (number2Text.Length > 2){
  Console.WriteLine("третья цифра -> " + number2Text[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}