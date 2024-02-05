using PasswordManagerSystem.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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

    public void CreatePassword(Password password)
    {
        _dbContext.Passwords.Add(password);
        _dbContext.SaveChanges();
    }

    public void UpdatePassword(Password password)
    {
        _dbContext.Entry(password).State = EntityState.Modified;
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
