using System.Linq;
using System.Windows.Forms;

namespace PasswordManagerSystem.Helpers
{
    public static class FormHelper
    {
        public static void ClearForm(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox box)
                {
                    box.Clear();
                }
            }
        }

        public static void MinimizeForm(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        public static void CloseForm(Form form)
        {
            //form.Close();
            Application.Exit();
        }

        public enum ApplicationType
        {
            Website = 1,
            Software = 2,
            Game = 3
        }
    }
}
