using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    internal class Student : IData
    {
        public int ID {  get; private set; }
        public string FirstName { get; private set; }
        public string LastName{get;private set;}
        public string SurName{get;private set;}//отчество
        public int Age{get;private set;}
        public int Course{get;private set;}
        public string Specialisation{get;private set;}
        public string Descryption { get; set; }//описание студента
        public string GetData()
        {
            return $"{ID}\t{FirstName}\t{LastName}\t{SurName}\t{Age}\t{Course}\t{Specialisation}";
        }
    }
}
