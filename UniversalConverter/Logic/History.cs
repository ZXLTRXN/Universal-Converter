using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalConverter.Logic
{
    [Serializable]
    public struct Record
    {
        int p1;
        int p2;
        string number1;
        string number2;
        public Record(int p1, int p2, string n1, string n2) 
        {
            this.p1 = p1;
            this.p2 = p2;
            this.number1 = n1;
            this.number2 = n2;
        }

        public override string ToString() 
        {
            return String.Format("{0}({1}) <=> {2}({3})", number1, p1, number2, p2);
        }
    }

    class History
    {
        List<Record> L;

        public History()
        {
            L = new List<Record>();
        }

        public Record GetRecord(int i)
        {
           return L[i];  
        }

        public void AddRecord(int p1, int p2, string n1, string n2) 
        {
            Record newRecord = new Record(p1, p2, n1, n2);
            L.Add(newRecord);
        }

        public void Clear() 
        {
            L.Clear();
        }

        public int Count() 
        {
            return L.Count;
        }
    }
}
