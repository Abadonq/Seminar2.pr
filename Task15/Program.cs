int GetNum()
{
    Console.WriteLine("Введите число от 1 до 7");
    int user_input = Convert.ToInt32(Console.ReadLine());
    return user_input;
}

switch(GetNum())
{
case 1:
 Console.WriteLine("нет");
break;

case 2:
 Console.WriteLine("нет");
break;

case 3:
 Console.WriteLine("нет");
break;

case 4:
 Console.WriteLine("нет");
break;

case 5:
 Console.WriteLine("нет");
break;

case 6:
 Console.WriteLine("да");
break;

case 7:
Console.WriteLine("да");
break;

default:
 Console.WriteLine("число не правильное");
break;
}



