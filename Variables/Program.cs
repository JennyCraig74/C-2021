using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter FirstName");
            string FirstName = Console.ReadLine();
            Console.WriteLine(FirstName); 

            Console.WriteLine("Enter SurName");
            string SurName = Console.ReadLine();
            Console.WriteLine(SurName);  

            Console.WriteLine("Enter ID ");
            string ID = Console.ReadLine();
            Console.WriteLine(ID);  

            Console.WriteLine("Enter YOB ");
            int YOB = int.Parse(Console.ReadLine());
            Console.WriteLine(YOB); 

            Console.WriteLine("Please Enter Current Year");
            int CurrentYear =int.Parse(Console.ReadLine());
            Console.WriteLine(CurrentYear); 
            
            Console.WriteLine("Your name is " + FirstName + " " + SurName + " Your Age Is " + (CurrentYear - YOB) ); 

            Console.ReadLine();
        }
    }
}


