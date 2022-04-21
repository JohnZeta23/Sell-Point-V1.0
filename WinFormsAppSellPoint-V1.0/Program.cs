using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppSellPoint_V1._0.Formularios_Crud;

namespace WinFormsAppSellPoint_V1._0
{
    internal static class Program
    {
        public static bool boolUserAuthenticated = false;
        public static bool LoginConfirm = true;
        public static string stringUserName = String.Empty;
        public static string stringUserRol = String.Empty;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new SplashForm());

            Application.Run(new FormLogin());

            if (boolUserAuthenticated)
            {
                Application.Run(new FormMenu());
            }
        }
    }
}
