using System;
using System.Collections.Generic;

namespace dz11
{
    #region Условия задачи
       //Создать приложение(консольное приложение), с помощью которого
       //пользователь сможет залогиниться, вылогиниться, добавить друга в
       //социальной сети и повредить систему(VK, Facebook).

       //1. Нужно реализовать интерфейс ISocialNetworkProvider который будет
       //иметь три метода. (Login, Logout, AddFriend(), CrashSystem())

       //2. Создать для пользователя класс User(поля определить самим.Точно
       //будут Email и Password)

       //3. Создать интерфейс IFriend(базовы) и конкретные интерфейсы, и
       //реализации для трех соц.сетей Vk и Facebook, и Instagram.

       //4. При реализации метода логин – проверяем в коллекции существующих
       //пользователей что юзер существует(проверка идет по Email и
       //Password) и добавляем User в коллекцию залогиненных.Данные две
       //коллекции хранятся в классе конкретного провайдера.

       //5. При вызове AddFriend проверяем что пользователь залогинен и если
       //да – добавляем ему в коллекцию друзей нового. Если пытаемся
       //добавить пользователя не того типа – пишем на консоль не могу
       //добавить пользователя Facebook в Instagram.

       //6. Коллекция друзей – это Dictionary&lt; User, T&gt;. T берется из
       //ISocialNetworkProvider&lt;T&gt;

       //7. Когда вызывается метод CrashSystem удаляются все пользователи из
       //коллекции залогиненных пользователей и им всем отправляется
       //сообщение, что система упала в «текущее время» из-за этого вы были
       //вылогинены из системы

       //Добавить поддержку трех соцсетей Vk и Facebook(обязательно) и Instagram
       //(по желанию).
    #endregion
    class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            var Fb = new Fb();
            var Vk = new Vk();
            var Inst = new Inst();

            static List<User> GetUsers(int count)
            {
                var users = new List<User>();
                for (int i = 0; i < count; i++)
                {
                    users.Add(new User());
                }
                return users;
            }

            var usersFb = GetUsers(5);
            var usersVk = GetUsers(5);
            var usersInst = GetUsers(5);

            static void AddUsers(List<User> users, ISocialNetworkProvider soc)
            {
                foreach (var user in users)
                {
                    soc.AddUser(user);
                }
            }

            AddUsers(usersFb, Fb);
            AddUsers(usersVk, Vk);
            AddUsers(usersInst, Inst);

            AddFriends(usersFb, Fb);
            AddFriends(usersVk, Vk);
            AddFriends(usersInst, Inst);

            static void AddFriends(List<User> users, ISocialNetworkProvider soc)
            {
                foreach (var user in users)
                {
                    soc.Login(user.Email, user.Password);
                    Console.WriteLine();

                    var friends = GetFriends(10);

                    foreach (var friend in friends)
                    {
                        soc.AddFriend(user.Email, user.Password, friend);
                    }

                    Console.WriteLine();
                    soc.Logout(user.Email, user.Password);
                }
            }

            static List<IFriend> GetFriends(int count)
            {
                var friends = new List<IFriend>();

                for (int i = 0; i < count; i++)
                {
                    switch (rnd.Next(0, 3))
                    {
                        case 0:
                            friends.Add(new FriendFb());
                            break;
                        case 1:
                            friends.Add(new FriendVk());
                            break;
                        case 2:
                            friends.Add(new FriendInst());
                            break;
                        default:
                            break;
                    }
                }

                return friends;
            }

            Fb.ShowAllUsers();
            Vk.ShowAllUsers();
            Inst.ShowAllUsers();

            Fb.CrashSystem();
            Vk.CrashSystem();
            Inst.CrashSystem();

        }
    }
}
