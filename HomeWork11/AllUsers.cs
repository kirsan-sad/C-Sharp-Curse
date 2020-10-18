using System;
using System.Collections.Generic;
using System.Text;

namespace dz11
{
    delegate void AccountHandler(object sender, AccountEventArgs e);

    public class AccountEventArgs : EventArgs
    {
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }

    abstract public class AllUsers : ISocialNetworkProvider
    {
        Dictionary<User, List<IFriend>> users = new Dictionary<User, List<IFriend>>();
        Dictionary<User, List<IFriend>> logined = new Dictionary<User, List<IFriend>>();

        public void Login(string email, string password)
        {
            var user = GetUserByEmailAndPassword(email, password);

            if (user.Key != null)
            {
                if (logined.ContainsKey(user.Key))
                {
                    Console.WriteLine("Пользователь уже авторизован");
                }
                else
                {
                    logined.Add(user.Key, user.Value);
                    Console.WriteLine("Вы залогинены");
                }
            }
            else
            {
                Console.WriteLine("Неверный адрес почты или пароль");
            }
        }

        public void Logout(string email, string password)
        {
            var user = GetUserByEmailAndPassword(email, password);

            if (user.Key != null)
            {
                if (logined.ContainsKey(user.Key))
                {
                    logined.Remove(user.Key);
                    Console.WriteLine("Вы вышли из сети");
                }
                else
                {
                    Console.WriteLine("Вы не авторизированы");
                }
            }
            else
            {
                Console.WriteLine("Неверный адрес почты или пароль");
            }
        }

        public void AddFriend(string email, string password, IFriend friend)
        {
            var user = GetUserByEmailAndPassword(email, password);
            if (logined.ContainsKey(user.Key))
            {
                if (friend is FriendVk && this is Vk || friend is FriendFb && this is Fb || friend is FriendInst && this is Inst)
                {
                    users[user.Key].Add(friend);
                    Console.WriteLine($"{user.Key.Email} добавлен друг: {friend.NikName}");
                }
                //else
                //{
                //    Console.WriteLine($"Невозвможно добавить пользователя из другой соц сети");
                //}
            }
            else
            {
                Console.WriteLine("Вы не авторизованы");
            }

        }

        public void AddUser(User user)
        {
            if (users.ContainsKey(user))
            {
                Console.WriteLine("Такой пользователь уже зарегистрирован");
            }
            else
            {
                users.Add(user, new List<IFriend>());
                Notify += user.Message;

            }
        }

        public void ShowAllUsers()
        {
            Console.WriteLine($"Все зарегистрированные пользователи {GetType().Name}: ");

            foreach (var user in users)
            {
                Console.WriteLine($"Пользователь {user.Key.Email}");

                if (user.Value.Count != 0)
                {
                    Console.WriteLine("Друзья:");
                    foreach (var friend in user.Value)
                    {
                        Console.WriteLine(friend.NikName);
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }

        event AccountHandler Notify;

        public void CrashSystem()
        {
            foreach (var user in logined.Keys)
            {
                Logout(user.Email, user.Password);
            }

            Notify?.Invoke(this, new AccountEventArgs()
            {
                Date = DateTime.Now,
                Message = $"Система упала в {DateTime.Now} из-за этого вы были вылогинены из системы",
            });
        }

        public void SubscribeUsers()
        {
            foreach (var user in users.Keys)
            {
                Notify += user.Message;
            }
        }

        private KeyValuePair<User, List<IFriend>> GetUserByEmailAndPassword(string email, string password)
        {
            foreach (var user in users)
            {
                if (user.Key.Email == email && user.Key.Password == password)
                {
                    return user;
                }
            }

            return new KeyValuePair<User, List<IFriend>>();
        }

    }
}
