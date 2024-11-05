using System;
using System.Windows.Forms;

namespace chuyen_de_hoc_tap_doanh_nghiep_06
{
    internal static class Program
    {
        public static Form loginForm = null;

        public static Form menuForm = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            loginForm = new LoginForm();

            menuForm = new MenuForm();

            Application.Run(loginForm);
        }
    }
}