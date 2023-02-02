 
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





/*
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
*/




/*
int num2=0 ;
int num1=0 ;

Console.Write("input your number:  ");
int number = Convert.ToInt32(Console.ReadLine());
if(number<99)
{
 Console.WriteLine("your number not 3 digit");
}
    else 
    if(number>99 && 999>number)
    {
     num1 = number %10;
     Console.WriteLine($"3 digit is : {num1}");
    } 
    else if(number>999 && 9999>number)
    {
    num1 = number/10;
     num2 = num1 %10;
    Console.WriteLine($"3 digit is : {num2}");
    }
  else 
{
    if(number>9999 && 99999>number)
    {
        num1 = number/100;
        num2 = num1 %10;
        Console.WriteLine($"3 digit is : {num2}");
    }
    else 
        
    {
        if(number>99999 && 999999>number)
        {
        num1 = number/1000;
        num2 = num1 %10;
        Console.WriteLine($"3 digit is : {num2}");
        }
        if(number>999999 && 9999999>number)
        {
        num1 = number/10000;
        num2 = num1 %10;
        Console.WriteLine($"3 digit is : {num2}");
        }
    }
}
*/


/*
int Digits3()
{
    int num =Convert.ToInt32(Console.ReadLine());
    int num1;
    int num2;
if(num<99)
{
 Console.WriteLine("your number not 3 digit");
}
else 
    if(num>99 && 999>num)
    {
     num1 = num %10;
     return num1;
    } 
    else 
    if(num>999 && 9999>num)
    {
    num1 = num/10;
    num2 = num1 %10;
    return num2;
    }
  else 
{
    if(num>9999 && 99999>num)
    {
        num1 = num/100;
        num2 = num1 %10;
        return num2;
    }
    else      
    {
        if(num>99999 && 999999>num)
        {
        num1 = num/1000;
        num2 = num1 %10;
        return num2;
        }
        else
        if(num>999999 && 9999999>num)
        {
        num1 = num/10000;
        num2 = num1 %10;
        return num2;
        }
    }
}
}

Console.WriteLine("input your number:  ");
int result = Digits3();
Console.WriteLine(result);
*/
   


