using PasswordManagerSystem.Models;
using System.Collections.Generic;
using System.Linq;
namespace PasswordManagerSystem.Repositories
{
    public class PasswordHistoryRepository : IPasswordHistoryRepository
{
    private readonly PasswordManagerContext _dbContext;

    public PasswordHistoryRepository(PasswordManagerContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<PasswordHistory> GetPasswordHistories(int passwordId)
    {
        return _dbContext.PasswordHistories.Where(ph => ph.PasswordId == passwordId).ToList();
    }

    public void CreatePasswordHistory(PasswordHistory passwordHistory)
    {
        _dbContext.PasswordHistories.Add(passwordHistory);
        _dbContext.SaveChanges();
    }
    // Add other methods if needed
}
}
