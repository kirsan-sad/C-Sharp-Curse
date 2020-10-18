using System;
using System.Collections.Generic;
using System.Text;

namespace dz11
{
    public interface ISocialNetworkProvider
    {
        public void Login(string email, string password);
        public void Logout(string email, string password);
        public void AddFriend(string email, string password, IFriend friend);
        public void AddUser(User user);
        public void CrashSystem();
    }
}
