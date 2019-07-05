using Project1.Entity;
using System;

namespace Project1.Business
{
    public class BusUser
    {
        public static bool LoginUser(string userName, string password)
        {
            var user = new User()
            {
                UserName = "emrullah"
            };
            ChangeUserName(user);
            ChangeUser(user);

            return false;
        }
        private static void ChangeUserName(User user)
        {
            user.UserName = "a";
        }
        private static void ChangeUser(User user)
        {
            user = new User()
            {
                UserName = "b"
            };
        }
    }
}
