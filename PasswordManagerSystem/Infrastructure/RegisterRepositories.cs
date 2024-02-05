
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
            // Register repositories
            Container.RegisterType<IUserRepository, UserRepository>();
            Container.RegisterType<IPasswordRepository, PasswordRepository>();
            Container.RegisterType<IPasswordHistoryRepository, PasswordHistoryRepository>();
            Container.RegisterType<IPasswordApplicationRepository, PasswordApplicationRepository>();
            Container.RegisterType<IUserDetailRepository, UserDetailRepository>();

            // Register services
            Container.RegisterType<UserService>();
            Container.RegisterType<PasswordService>();
            Container.RegisterType<PasswordHistoryService>();
            Container.RegisterType<PasswordApplicationService>();
            Container.RegisterType<UserDetailService>();
        }
    }
}
