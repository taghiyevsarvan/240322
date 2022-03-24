using System;
using System.Collections.Generic;
using System.Text;

namespace _2_240322
{
    internal interface IAccount
    {
        static bool PasswordChecker(string Password)
        {
            if (!string.IsNullOrEmpty(Password) && Password.Length > 7)
            {
                bool HasDigit = false;
                bool HasLower = false;
                bool HasUpper = false;
                for (int i = 0; i < Password.Length; i++)
                {
                    if(char.IsDigit(Password[i]))
                        HasDigit = true;
                    else if(char.IsLower(Password[i]))
                        HasLower = true;
                    else if(char.IsUpper(Password[i]))
                        HasUpper = true;
                }
                if (HasUpper && HasLower && HasDigit)
                    return true;
            }
            return false;
        }
        public string ShowInfo();
    }
}

