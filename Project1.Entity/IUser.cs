using System;
using System.Collections.Generic;
using System.Text;

namespace Project1.Entity
{
    interface IUser
    {
        string UserName { get; set; }
        string Password { get; set; }
        bool Login();
    }
}
