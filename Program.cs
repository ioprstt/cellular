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
            // ���������� ������
            using (ApplicationContext db = new ApplicationContext())
            {
                /*
                Passport pasp = new Passport {
                    Series = "1234",
                    Num = "567890",
                    DateOfIssue = DateTime.Now.Date,
                    IssuingAuthority = "����� ������",
                    Name = "����",
                    Surname = "������",
                    Patronymic = "��������",
                    DateOfBirth = new DateTime(1997, 09, 04),
                    Address = "������������ ���."
                };
                
                db.Passports.Add(pasp);
                db.SaveChanges();
                */
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
        }
    }
}
