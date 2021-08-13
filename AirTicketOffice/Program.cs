using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTicketOffice
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            do
            {
                Application.Run(new EnteringForm());

                if (User.isPassenger)
                    Application.Run(new PassengerForm());
                else if (User.isAdmin)
                    Application.Run(new OwnerForm());

            }
            while (User.isPassenger || User.isAdmin);
        }
    }
}
