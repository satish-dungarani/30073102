using PasswordManagerSystem.Data;
using PasswordManagerSystem.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using static PasswordManagerSystem.Helpers.FormHelper;

namespace PasswordManagerSystem.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PasswordManagerContext _dbContext;

        public UserRepository(PasswordManagerContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User GetUserById(int userId)
        {
            return _dbContext.Users.Find(userId);
        }

        public IEnumerable<UserModel> GetAllUsers(string searchstr)
        {
            var query = from user in _dbContext.Users
                        join detail in _dbContext.UserDetails
                        on user.Id equals detail.UserId
                        where
                        string.IsNullOrEmpty(searchstr) ||
                        user.Username.Contains(searchstr) ||
                        detail.Firstname.Contains(searchstr) ||
                        detail.Lastname.Contains(searchstr) ||
                        detail.Email.Contains(searchstr) ||
                        detail.Mobile.Contains(searchstr)
                        select new UserModel
                        {
                            Id = user.Id,
                            Name = detail.Firstname + " " + detail.Lastname,
                            UserName = user.Username,
                            Password = user.Password,
                            Email = detail.Email,
                            Mobile = detail.Mobile,
                            CreatedOn = user.CreatedOn.ToString()
                        };
            return query.ToList();
        }

        public void CreateUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            var user = _dbContext.Users.Find(userId);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
        }

        public User GetUserByUsernameAndPassword(string username, string password)
        {
           return _dbContext.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
