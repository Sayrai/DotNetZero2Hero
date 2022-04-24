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
            // check if password is greater than 6

            if(password.Length < 6) {

                return "Password length should be more than 6";
                
            } else {
                //check if user exists
                 //check if username/password match
            
                var userExists = _usersStore.Any(x => x.UserName == userName && x.Password == password);
                //return login status
                return userExists;
            }
           
            
        }
    }
}
