namespace SOLID
{
    public class User
    {
        public string? Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }

        public static User Register(string id, string userName, string password)
        {
            return new(id, userName, password);
        }

        private User(string id, string userName, string password)
        {

            Id = id;
            UserName = userName;
            Password = password;

        }
    }
}
