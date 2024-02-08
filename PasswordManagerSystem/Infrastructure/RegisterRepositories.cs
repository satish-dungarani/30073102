
using PasswordManagerSystem.Repositories;
using PasswordManagerSystem.Services;
using Unity;
using Unity.Extension;

namespace PasswordManagerSystem.Infrastructure
{
    public class RegisterRepositories :  UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IUserRepository, UserRepository>();
            Container.RegisterType<IPasswordRepository, PasswordRepository>();
            Container.RegisterType<IPasswordHistoryRepository, PasswordHistoryRepository>();
            Container.RegisterType<IUserDetailRepository, UserDetailRepository>();

            Container.RegisterType<UserService>();
            Container.RegisterType<PasswordService>();
            Container.RegisterType<PasswordHistoryService>();
            Container.RegisterType<UserDetailService>();
        }
    }
}
