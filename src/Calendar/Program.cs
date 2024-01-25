using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Calendar
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Account loggedInAccount;
            bool loginSuccessful = LoginFormStyled.ShowLogin(out loggedInAccount);

            if (loginSuccessful)
            {
                if (loggedInAccount.Role == "Manager")
                {
                    Application.Run(new ManagerForm(loggedInAccount));
                }
                else
                {
                    Application.Run(new TenantForm(loggedInAccount));
                }
            }
        }
    }
}
