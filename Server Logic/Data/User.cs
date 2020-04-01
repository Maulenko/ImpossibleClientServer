using System;

namespace ServerLogic.Data
{
    [Serializable]
    public class User
    {
        public long Id;
        public string Login;
        public string Password;
        public UserInfo UserInfo;
        public User(string login, string password) : this() => (this.Login, this.Password) = (login, password);
        public User() { UserInfo = new UserInfo(); }

    }
}
