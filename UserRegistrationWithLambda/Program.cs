using System;
namespace UserRegistrationWithLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Validation reg = new Validation();
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Validate first name \n2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter first name");
                        bool result = reg.ValidateFirstNameByLambda();
                        if (result)
                            Console.WriteLine("Valid");
                        else
                            Console.WriteLine("Invalid");
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}