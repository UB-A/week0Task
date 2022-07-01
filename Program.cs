using System;

namespace week0Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THIS IS AN ADDITION CALCULATOR");
            Console.WriteLine("===============================\n");
            Console.Write("First Number is : ");
            int firstNumber;
            var isNum1 = int.TryParse(Console.ReadLine(), out firstNumber);
            Console.Write("Second Number is : ");
            int secondNumber ;
            var isNum2 = int.TryParse(Console.ReadLine(), out secondNumber);
            if(isNum1 && isNum2){                
                var sum = firstNumber +secondNumber;
                Console.WriteLine("the addition of "+firstNumber+ " and "+secondNumber+ " is " + sum);
            }
            else if(!isNum1){
                Console.WriteLine("Invalid First Number Input");
            }
            else{
                Console.WriteLine("Invalid Second Number Input");
            }
            
        }
    }
}
