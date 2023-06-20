 int GetNum()
 {
    Console.WriteLine("input your number(100-999)");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
 }
int logic()
 {       
            int num2 = GetNum() / 10 %10;
            return num2;
 }


int result = logic();
Console.WriteLine(result);
 
 
 
