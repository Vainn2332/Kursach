using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        public Student(int ID,string firstName,string lastName,string surName,int age,int course,string specialisation,string descryption)
        {
            this.ID = ID;
            FirstName = firstName;
            LastName = lastName;
            SurName = surName;
            Age = age;
            Course = course;
            Specialisation = specialisation;
            Descryption = descryption;
        }
        public string GetData()
        {
            return $"{ID}\t{FirstName}\t{LastName}\t{SurName}\t{Age}\t{Course}\t{Specialisation}";
        }

    }
}
