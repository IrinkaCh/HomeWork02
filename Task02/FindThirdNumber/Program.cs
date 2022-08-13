Console.Write("Введите трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
string result = number.ToString();
int i = 2;

void three()
{
if(number / 100 > 0){Console.WriteLine(result[i]);}
else{Console.WriteLine("Третьей цифры нет");}
}
three();