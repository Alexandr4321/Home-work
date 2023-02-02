 
 /*
 int Digits()
 {
    
    int num = Convert.ToInt32(Console.ReadLine());
    int num1 = num / 100 ;
    int num2= num - (num1*100);
    int num3= num2 / 10;
    return num3;

 }
 Console.Write("input your number: ");
 int result = Digits();
 Console.WriteLine($"second digit is {result}");
*/


Console.Write("input your number:  ");
int num = Convert.ToInt32(Console.ReadLine());

if(0< num && num< 6 )
{
    Console.WriteLine("Рабочий день");
}
else 

    if(num>5 && num<8)
     Console.WriteLine("Выходной день");
 
else 
Console.WriteLine("eror"); 