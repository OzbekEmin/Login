using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Entity
{
    public class User : IUser
    {
        private string _userName;
        private string _passWord;

        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _passWord; set => _passWord = value; }

        public int A { get; set; }

        public bool Login()
        {
            return false;
        }
    }
}










