using System;

namespace ServerLogic.Data
{
    public class UserInfo
    {
        public string Name { get; internal set; } = "Unclown";
        public string Surname { get; internal set; } = "Unclown";
        public UserGender Gender { get; internal set; } = UserGender.Unclown;
        public DateTime RegistrationDate { get; internal set; } = DateTime.MinValue;
        public DateTime LastJoin { get; internal set; } = DateTime.MinValue;
    }
}
