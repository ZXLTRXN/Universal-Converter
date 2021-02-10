using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalConverter.Logic
{
    class Conver_P_10
    {
        //Преобразовать цифру в число.
        static double char_To_num(char ch) 
        {
            switch (ch)
            {
                case '0':
                    return 0;
                    break;
                case '1':
                    return 1;
                    break;
                case '2':
                    return 2;
                    break;
                case '3':
                    return 3;
                    break;
                case '4':
                    return 4;
                    break;
                case '5':
                    return 5;
                    break;
                case '6':
                    return 6;
                    break;
                case '7':
                    return 7;
                    break;
                case '8':
                    return 8;
                    break;
                case '9':
                    return 9;
                    break;
                case 'A':
                    return 10;
                    break;
                case 'B':
                    return 11;
                    break;
                case 'C':
                    return 12;
                    break;
                case 'D':
                    return 13;
                    break;
                case 'E':
                    return 14;
                    break;
                case 'F':
                    return 15;
                    break;
                default:
                    throw new Exception("Недопустимый символ");


            }
        }



/*        //Преобразовать строку в число
        private static double convert(string P_num, int P, double weight) 
        {

        }



        //Преобразовать из с.с. с основанием р 
        //в с.с. с основанием 10.
        public static double dval(string P_num, int P) 
        {

        }*/
    }

}
