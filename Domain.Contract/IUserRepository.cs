using Domain.Entittes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        int AddUser(User user);
        User GetUser(int Id);
        User EditUser(User user);
        User DeleteUser(User user);
    }
}
