using System.Collections.ObjectModel;

namespace SOLID
{
    public class UserAccess
    {
        private readonly Collection<User> _usersStore;
        public UserAccess(Collection<User> users)
        {
            _usersStore = users;
        }
        public bool Login(string userName, string password)
        {  
            //check if user exists
            //check if username/password match
            var userExists = _usersStore.Any(x => x.UserName == userName && x.Password == password);

            //return login status
            return userExists;
        }
    }
}
