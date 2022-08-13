Console.WriteLine("Введите цифру, обозначающую день недели, от 1 до 7 ");
int number = Convert.ToInt32(Console.ReadLine());

void FindWeekend()
{
if((number == 6)^(number == 7)){Console.WriteLine("Да");}
else{
    if((number > 7)^(number < 1)){Console.WriteLine("Введите корректную цифру, от 1 до 7 ");}
    else{ Console.WriteLine("Нет");}
    }
}
FindWeekend();