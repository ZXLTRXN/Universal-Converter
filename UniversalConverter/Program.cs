using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalConverter
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppForm());
            /* int SS = 8;
             int acc = 8;
             string Str = Logic.Conver_10_P.Do(0.8902, SS, acc);
             Console.WriteLine(Str);
             Console.WriteLine(Logic.Conver_P_10.Do(Str, SS, acc));
             Console.ReadLine();

             Logic.History h = new Logic.History();*/


        }
    }
}
