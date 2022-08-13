Console.Write("Введите трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

void DeriveSecondNumber()
{
int result = number / 10 % 10;
Console.WriteLine(result);
}
DeriveSecondNumber();