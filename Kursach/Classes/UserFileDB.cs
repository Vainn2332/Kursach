using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    internal class UserFileDB : IDataBase
    {
        public const string name = "UserDataBase";       
        public void CreateDB()
        {           
            StreamWriter sw = new StreamWriter(name, false);
            sw.Close();
        }
        public bool ExistsByLogin(IData data)
        {
            string[] fileLines = File.ReadAllLines(name);
            string[] line  = data.GetData().Split(new char[] { '\t' });
            string target = line[0];
            foreach (string fileline in fileLines)
            {
                string[] file_line_arr=fileline.Split(new char[] { '\t' });
                string first_part = file_line_arr[0];
                if (target == first_part)
                    return true;
            }
            return false;
        }
        public bool Exists(IData data)
        {
            string[] fileLines = File.ReadAllLines(name);
            if (fileLines.Contains(data.GetData()))
                return true;
            else return false;
        }
        public void AddElement(IData data)
        {
            StreamWriter sw = new StreamWriter(name, true); 
            sw.WriteLine(data.GetData());
            sw.Close();
        }

        public void DeleteElement(IData data)
        {
            string[] fileLines = File.ReadAllLines(name);
            var newlist = fileLines.Where(x => x != data.GetData());//LINQ запрос где нет данного элемента
            File.WriteAllLines(name, newlist);
        }
    }
}
