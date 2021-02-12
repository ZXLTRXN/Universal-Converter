using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalConverter.Logic
{
    class Editor
    {
        //Поле для хранения редактируемого числа.
        string number = "";


        //Свойство для чтения редактируемого числа.
        public string Number
        { get { return number; } }


        //Добавить цифру.
        public string AddDigit(int n)
        {

            String temp = number;
            temp += Conver_10_P.int_to_Char(n);
            return temp;
        }


        //Точность представления результата.
        /*public int Acc() { 
      }
        */

        //Добавить ноль.
        public string AddZero()
        {
            String temp = number;
            temp += '0';
            return temp;
        }


        //Добавить разделитель.
        public string AddDelim()
        {
            String temp = number;
            temp += Const.Sep;
            return temp;
        }


        //Удалить символ справа.
        public string Bs()
        {
            String temp = number;
            temp.Remove(temp.Length - 1);
            return temp;
        }


        //Очистить редактируемое число.
        public string Clear()
        {

            String temp = "";
            return temp;
        }


        //Выполнить команду редактирования.
        public string DoEdit(int j)
        {
            return "12345678";///////////////////////////////////////hardcoded
        }

    }

}
