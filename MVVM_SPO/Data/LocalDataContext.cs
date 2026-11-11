using MVVM_SPO.Model;

namespace MVVM_SPO.Data
{
    public static class LocalDataContext
    {
        public static List<Role> Roles = new List<Role>()
        {
            new Role(){Id = 0, Name = "user" },
            new Role(){Id = 1, Name = "manager" },
            new Role(){Id = 2, Name = "admin" },
        };
        public static List<User> Users = new List<User>()
        {
            new User() {Id = 0, Name = "user_1", Login = "1", Password = "1", Role = Roles[0]},
            new User() {Id = 1, Name = "user_2", Login = "2", Password = "2", Role = Roles[1]},
            new User() {Id = 2, Name = "user_3", Login = "3", Password = "3", Role = Roles[2]}
        };
    }
}
