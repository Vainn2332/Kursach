using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kursach
{
    internal class StudentFileDB : IDataBase
    {
        public  const string filename = "StudentDataBase";
        public void AddElement(IData data)
        {
            StreamWriter sw = new StreamWriter(filename, true);
            sw.WriteLine(data.GetData());
            sw.Close();
        }
        
        public void CreateDB()
        {
            StreamWriter sw = new StreamWriter(filename, false);
            sw.Close();
        }

        public void DeleteElement(IData data)
        {
            string[] fileLines = File.ReadAllLines(filename);
            var newlist = fileLines.Where(x => x != data.GetData());//LINQ запрос где нет данного элемента
            File.WriteAllLines(filename, newlist);
        }

        public bool Exists(IData data)
        {
            string[] fileLines = File.ReadAllLines(filename);
            if (fileLines.Contains(data.GetData()))
                return true;
            else return false;
        }
    }
}
