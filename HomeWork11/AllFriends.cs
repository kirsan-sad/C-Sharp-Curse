using System;
using System.Collections.Generic;
using System.Text;

namespace dz11
{
    abstract class AllFriends : IFriend
    {
        public string NikName { get; set; }

        public AllFriends()
        {
            NikName = "FriendName" + new Random().Next(0, 100);
        }
    }
}
