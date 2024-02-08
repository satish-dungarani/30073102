using PasswordManagerSystem.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
namespace PasswordManagerSystem.Repositories
{
    public class UserDetailRepository : IUserDetailRepository
{
    private readonly PasswordManagerContext _dbContext;

    public UserDetailRepository(PasswordManagerContext dbContext)
    {
        _dbContext = dbContext;
    }

    public UserDetail GetUserDetailById(int userDetailId)
    {
        return _dbContext.UserDetails.Find(userDetailId);
    }

    public IEnumerable<UserDetail> GetAllUserDetails()
    {
        return _dbContext.UserDetails.ToList();
    }

    public void CreateUserDetail(UserDetail userDetail)
    {
        _dbContext.UserDetails.Add(userDetail);
        _dbContext.SaveChanges();
    }

    public void UpdateUserDetail(UserDetail userDetail)
    {
            _dbContext.UserDetails.AddOrUpdate(userDetail);
        //_dbContext.Entry(userDetail).State = EntityState.Modified;
        _dbContext.SaveChanges();
    }

    public void DeleteUserDetail(int userDetailId)
    {
        var userDetail = _dbContext.UserDetails.Find(userDetailId);
        if (userDetail != null)
        {
            _dbContext.UserDetails.Remove(userDetail);
            _dbContext.SaveChanges();
        }
    }
    }
}
