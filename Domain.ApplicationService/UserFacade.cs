using Domain.Contract;
using Domain.Entittes;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ApplicationService
{
    public class UserFacade : IUserFacade
    {
        private readonly IUserRepository userRepository;
        public UserFacade(IUserRepository  userRepository)
        {
            this.userRepository = userRepository;
        }
        public int AddUser(User user)
        {
            return userRepository.AddUser(user);
        }

        public User DeleteUser(User user)
        {
            return userRepository.DeleteUser(user);
        }

        public User EditUser(User user)
        {
            return userRepository.EditUser(user);
        }

        public User GetUser(int Id)
        {
            return userRepository.GetUser(Id);
        }

        public List<User> GetUsers()
        {
            return userRepository.GetUsers();
        }
    }
}
