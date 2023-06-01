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
        public bool ValidateFirstNameByLambda() => Regex.IsMatch(Console.ReadLine(), NAME) ? true : false;
        public bool ValidateLastNameByLambda() => Regex.IsMatch(Console.ReadLine(), NAME) ? true : false;
    }
}
