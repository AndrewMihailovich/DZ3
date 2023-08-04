Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 2;
if (result == 0)
{
Console.Write(number + " – чётное");
}
else 
{
Console.Write(number + " – нечётное");
}