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
            // Create Unity container
            IUnityContainer container = new UnityContainer();

            // Register types for dependency injection
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<UserService>();

            // Resolve UserService from the container
            UserService userService = container.Resolve<UserService>();



            Application.Run(new frmLogin(userService));
        }
    }
}
