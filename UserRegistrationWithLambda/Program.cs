﻿using System;
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
                Console.WriteLine("\nChoose option to perform \n1.Validate first name \n2.Validate last name \n3.Validate E-Mail \n4.Validate Phone Number \n5.Validate Password \n6.Exit");
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
                        Console.WriteLine("Enter last name");
                        bool lastName = reg.ValidateLastNameByLambda();
                        if (lastName)
                            Console.WriteLine("Valid");
                        else
                            Console.WriteLine("Invalid");
                        break;
                    case 3:
                        Console.WriteLine("Enter E-Mail");
                        bool email = reg.ValidateEmailByLambda();
                        if (email)
                            Console.WriteLine("Valid");
                        else
                            Console.WriteLine("Invalid");
                        break;
                    case 4:
                        Console.WriteLine("Enter Phone number");
                        bool number = reg.ValidateNumberByLambda();
                        if (number)
                            Console.WriteLine("Valid");
                        else
                            Console.WriteLine("Invalid");
                        break;
                    case 5:
                        Console.WriteLine("Enter Password");
                        bool password = reg.ValidatePasswordByLamda();
                        if (password)
                            Console.WriteLine("Valid");
                        else
                            Console.WriteLine("Invalid");
                        break;
                    case 6:
                        flag = false;
                        break;
                }
            }
        }
    }
}