﻿using System.Collections.ObjectModel;

namespace SOLID
{
    /// <summary>
    /// Manages user registration, getting user details, Login
    /// </summary>
    internal class UserManager
    {
        private readonly Collection<User> _usersStore;
        private readonly UserRegistration _registration;
        private readonly UserAccess _access;

        private readonly UserDetails _userDetails;
        public UserManager()
        {
            _usersStore = new();
            _registration = new UserRegistration(_usersStore);
            _access = new UserAccess(_usersStore);
            _userDetails = new UserDetails(_usersStore);

        }
        public void Register(string userId, string userName, string password)
        {
            try
            {
                _registration.Register(userId, userName, password);
                Console.WriteLine($"{userName} successfully registered");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void Login(string userName, string password)
        {
            if (_access.Login(userName, password))
            {// security mechanism
                Console.WriteLine($"{userName} successfully logged in");
              
            }
            else
            {
                Console.WriteLine($"login failed for {userName} (user does not exist)");
            }

        }

        public string GetDetails(string userId)
        {
            var user = _usersStore.FirstOrDefault(u => u.Id == userId);
            if (user == null) return "User not found";

            return $"UserId: {user.Id} - UserName: {user.UserName}";
        }



    }
}
