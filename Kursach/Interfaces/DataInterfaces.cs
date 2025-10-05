using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public interface IData// что то что является инфой
    {
        string GetData();
    }
    public interface IDataBase 
    {
        void CreateDB();
        void DeleteElement(IData data);
        void AddElement(IData data);
        bool Exists(IData data);
    }







}
