using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationWithLambda
{
    public class Validation
    {
        public const string NAME = @"^[A-Z][a-z]{2,}$";
        public const string EMAIL = @"^[a-zA-z0-9.+-]+[@][a-zA-z0-9]+[.][a-zA-z0-9.]{2,}$";
        public const string NUMBER = @"^[91 ]+[6-9][0-9]{9}$";
        public const string PASSWORD = @"^[A-Z]{1,}[a-zA-Z0-9]{0,}[0-9]{1,}[@#$%&*!]{1,}[a-zA-Z0-9]+$";
        public bool ValidateFirstNameByLambda() => Regex.IsMatch(Console.ReadLine(), NAME) ? true : false;
        public bool ValidateLastNameByLambda() => Regex.IsMatch(Console.ReadLine(), NAME) ? true : false;
        public bool ValidateEmailByLambda() => Regex.IsMatch(Console.ReadLine(), EMAIL) ? true : false;
        public bool ValidateNumberByLambda() => Regex.IsMatch(Console.ReadLine(), NUMBER) ? true : false;
        public bool ValidatePasswordByLamda() => Regex.IsMatch(Console.ReadLine(), PASSWORD) ? true : false;
    }
}
