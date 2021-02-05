using System; //Derrick Landers 113381246

namespace Sumof3
{
    class Program
    {
        static void Main(string[] args)
        {

            const double MAGICNUM = 7.777;
        
            Console.WriteLine("Please enter your first number >>");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            
            
            Console.WriteLine("Please enter your second number >>");
            double secondNum = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Please enter your third number >>");
            double thirdNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(firstNum + secondNum + thirdNum);
            
            Console.WriteLine(firstNum + secondNum + thirdNum * MAGICNUM);
            Console.ReadLine();
            
            

            

            
        }
    }
}
