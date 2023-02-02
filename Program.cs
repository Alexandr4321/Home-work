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
