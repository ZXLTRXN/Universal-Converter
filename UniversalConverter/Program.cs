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

            Console.WriteLine(Logic.Conver_10_P.Do(18.835,8, 4));
            Console.ReadLine();
        }
    }
}
