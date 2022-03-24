using System;
using System.Collections.Generic;
using System.Text;

namespace _2_240322
{
    internal class User
    {
        public string _fullName;
        private string _password;
        public string _email;
        public User (string fullName,string email)
        {
            fullName = FullName;
            email = Email;
        }
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                if (value.Length > 8)
                _fullName = value;
            }
        }
        public string Email
        {
            get
            {
                
                return _email;
            }
            set
            {
                if (value.Length > 10)
                _email = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (IAccount.PasswordChecker(value))
                    _password = value;
            }
        }
        public string ShowInfo()
        {
            return $"FulName: {_fullName} Email: {_email}";
        }
    }
}
