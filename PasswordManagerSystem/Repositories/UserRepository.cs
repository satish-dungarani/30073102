using PasswordManagerSystem.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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

        public IEnumerable<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();
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
    }
}
