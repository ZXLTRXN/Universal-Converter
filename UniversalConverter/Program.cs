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
        //[STAThread]
        static void Main()
        {
            /*            Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Form1());*/
            int SS = 5;
            int acc = 9;
            string Str = Logic.Conver_10_P.Do(0.36, SS, acc);
            Console.WriteLine(Str);
            Console.WriteLine(Logic.Conver_P_10.Do(Str, SS, acc));
            Console.ReadLine();

            Logic.History h = new Logic.History();


        }
    }
}
