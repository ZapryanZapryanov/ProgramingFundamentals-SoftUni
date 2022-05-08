using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int first = 6;
            const int second = 10;
            const int number = 2;
            string password = Console.ReadLine();
            bool ispass = PrintResult(password, first, second, number);



            if (ispass)
            {
                Console.WriteLine("Password is valid");
            }




        }
        static bool PrintResult(string password, int first, int second, int number)
        {
            bool passValid = true;
            if (!GetFirstProblem(password, first, second))
            {
                Console.WriteLine($"Password must be between {first} and {second} characters");
                passValid = false;

            }
            if (!GetSecondProblemOnlyLettersDigit(password))
            {
                Console.WriteLine($"Password must consist only of letters and digits");
                passValid = false;

            }
            if (!GetThirdProblemNeedOnlyTwoNum(password, number))
            {
                Console.WriteLine($"Password must have at least {number} digits");
                passValid = false;

            }

            return passValid
                ;
        }
        static bool GetFirstProblem(string password, int first, int second)
        {


            if (password.Length >= first && password.Length <= second)
            {
                return true;
            }
            return false;
        }
        static bool GetSecondProblemOnlyLettersDigit(string password)
        {


            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;

        }
        static bool GetThirdProblemNeedOnlyTwoNum(string password, int number)
        {
            int consta = 0;
            foreach (char item in password)
            {
                if (char.IsDigit(item))
                {
                    consta++;

                }

            }
            return consta >= number;
        }
    }
}
