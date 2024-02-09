using PasswordManagerSystem.Data;
using PasswordManagerSystem.Models;
using System.Collections.Generic;
using System.Linq;
using static PasswordManagerSystem.Helpers.FormHelper;

namespace PasswordManagerSystem.Repositories
{
    public class PasswordHistoryRepository : IPasswordHistoryRepository
    {
        private readonly PasswordManagerContext _dbContext;

        public PasswordHistoryRepository(PasswordManagerContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<HistoryModel> GetPasswordHistoriesByUserId(int userId, string searchstr)
        {
            var query = from history in _dbContext.PasswordHistories
                        join password in _dbContext.Passwords
                        on history.PasswordId equals password.Id
                        join user in _dbContext.Users
                        on password.UserId equals user.Id
                        where (password.UserId == userId || Properties.Settings.Default.IsAdmin) &&
                        (string.IsNullOrEmpty(searchstr) ||
                        password.PasswordValue.Contains(searchstr) ||
                        user.Username.Contains(searchstr) ||
                        password.ApplicationName.Contains(searchstr) ||
                        password.Username.Contains(searchstr) ||
                        ((ApplicationType)password.ApplicationType).ToString().Contains(searchstr))
                        select new HistoryModel
                        {
                            Id = password.Id,
                            Username = user.Username,
                            AppType = ((ApplicationType)password.ApplicationType).ToString(),
                            AppName = password.ApplicationName,
                            AppUsername = password.Username,
                            PrePassword = history.OldPassword,
                            RecPassword = password.PasswordValue,
                            UpdatedDate = history.CreatedOn.ToString()
                        };
            return query.ToList();
        }

        public void CreatePasswordHistory(PasswordHistory passwordHistory)
        {
            _dbContext.PasswordHistories.Add(passwordHistory);
            _dbContext.SaveChanges();
        }
    }
}
