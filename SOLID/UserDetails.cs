using System.Collections.ObjectModel;

namespace SOLID
{
    public class UserDetails
    {
        private readonly Collection<User> _usersStore;
        public UserDetails(Collection<User> users)
        {
            _usersStore = users;
        }
        
        public string GetDetails(string userId)
        {
            var user = _usersStore.FirstOrDefault(u => u.Id == userId);
            if (user == null) return "User not found";

            return $"UserId: {user.Id} - UserName: {user.UserName}";
        }
    }
}