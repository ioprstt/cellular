using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cellular
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // добавление данных
            using (ApplicationContext db = new ApplicationContext())
            {
                /*
                Passport pasp = new Passport {
                    Series = "1234",
                    Num = "567890",
                    DateOfIssue = DateTime.Now.Date,
                    IssuingAuthority = "ОУФМС России",
                    Name = "Иван",
                    Surname = "Иванов",
                    Patronymic = "Иванович",
                    DateOfBirth = new DateTime(1997, 09, 04),
                    Address = "Владимирская обл."
                };
                
                db.Passports.Add(pasp);
                db.SaveChanges();
                */
            }

<<<<<<< HEAD
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
=======
>>>>>>> acb11c1 (ef6 and net472)
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
        }
    }
}
