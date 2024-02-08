using PasswordManagerSystem.Helpers;
using PasswordManagerSystem.Models;
using PasswordManagerSystem.UI;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using static PasswordManagerSystem.Helpers.FormHelper;

namespace PasswordManagerSystem.Repositories
{
    public class PasswordRepository : IPasswordRepository
    {
        private readonly PasswordManagerContext _dbContext;

        public PasswordRepository(PasswordManagerContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Password GetPasswordById(int passwordId)
        {
            return _dbContext.Passwords.Find(passwordId);
        }

        public IEnumerable<Password> GetAllPasswords()
        {
            return _dbContext.Passwords.ToList();
        }

        public IEnumerable<PasswordModel> GetAllPasswordsByUserId(int userId, string searchstr)
        {
            var query = from password in _dbContext.Passwords
                        join user in _dbContext.Users
                        on password.UserId equals user.Id
                        where (password.UserId == userId || Properties.Settings.Default.IsAdmin) &&
                        (string.IsNullOrEmpty(searchstr) ||
                        password.PasswordValue.Contains(searchstr) ||
                        password.Username.Contains(searchstr))
                        select new PasswordModel
                        {
                            Id = password.Id,
                            ApplicationType = ((ApplicationType)password.ApplicationType).ToString(),
                            AppName = password.ApplicationName,
                            AppPassword = password.PasswordValue,
                            AppUsername = password.Username,
                            Username = user.Username,
                            IsActive = password.IsActive ? "true" : "false",
                            IsDeleted = password.IsDeleted ? "true" : "false",
                        };
            return query.ToList();
        }

        public void CreatePassword(Password password)
        {
            _dbContext.Passwords.Add(password);
            _dbContext.SaveChanges();
        }

        public void UpdatePassword(Password password)
        {
            var history = new PasswordHistory()
            {
                PasswordId = password.Id,
                CreatedBy = password.CreatedBy,
                CreatedOn = password.CreatedOn,
                OldPassword = _dbContext.Passwords.Find(password.Id).PasswordValue
            };

            _dbContext.Passwords.AddOrUpdate(password);
            _dbContext.PasswordHistories.Add(history);
            _dbContext.SaveChanges();
        }

        public void DeletePassword(int passwordId)
        {
            var password = _dbContext.Passwords.Find(passwordId);
            if (password != null)
            {
                _dbContext.Passwords.Remove(password);
                _dbContext.SaveChanges();
            }
        }
    }
}
