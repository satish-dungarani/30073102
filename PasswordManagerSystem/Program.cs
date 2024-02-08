using PasswordManagerSystem.Forms;
using PasswordManagerSystem.Repositories;
using PasswordManagerSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace PasswordManagerSystem
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IUnityContainer container = new UnityContainer();

            // Register types for dependency injection
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IUserDetailRepository, UserDetailRepository>();
            container.RegisterType<IPasswordRepository, PasswordRepository>();
            container.RegisterType<IPasswordHistoryRepository, PasswordHistoryRepository>();
            container.RegisterType<UserService>();
            container.RegisterType<UserDetailService>();
            container.RegisterType<PasswordService>();
            container.RegisterType<PasswordHistoryService>();

            // Resolve UserService from the container
            UserService userService = container.Resolve<UserService>();
            UserDetailService userDetailService = container.Resolve<UserDetailService>();
            PasswordService passwordService = container.Resolve<PasswordService>();
            PasswordHistoryService passwordHistoryService = container.Resolve<PasswordHistoryService>();



            Application.Run(new frmLogin(userService, userDetailService, passwordService, passwordHistoryService));
        }
    }
}
