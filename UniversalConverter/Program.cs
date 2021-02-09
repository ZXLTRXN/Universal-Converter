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

            Console.WriteLine(UniversalConverter.Logic.Conver_10_P.Do(-362.384,7, 7));
            Console.ReadLine();
        }
    }
}
