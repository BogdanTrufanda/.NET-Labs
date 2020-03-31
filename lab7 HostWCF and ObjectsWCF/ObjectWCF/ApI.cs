using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1;

namespace ObjectWCF
{
    public class ApI : Interface1
    {
        void Interface1.Add(string a, string b, string c, string d, string e, string f, string g)
        {
            Class1.Add(a, b, c, d, e, f, g);
        }
        void Interface1.Remove(string a)
        {
            Class1.Remove(a);
        }
        void Interface1.Update(string a, string b, string c)
        {
            Class1.Update(a, b, c);
        }
        IEnumerable<string> Interface1.GetColumnNames()
        {
            return Class1.GetColumnNames();
        }

        int Interface1.AddNewColumn(string a)
        {
            return Class1.AddNewColumn(a);
        }
        void Interface1.DeleteColumn(string a)
        {
            Class1.DeleteColumn(a);
        }

        List<string> Interface1.GetAll()
        {
            return Class1.GetAll();
        }
        List<string> Interface1.GetNames()
        {
            return Class1.GetNames();
        }
        List<string> Interface1.Get(string a)
        {
            return Class1.Get(a);
        }//return listtbtt
        List<string> Interface1.CheckBDIntegrity()
        {
            return Class1.CheckBDIntegrity();
        }
   
        void Interface1.RemovePath(string a)
        {
            Class1.RemovePath(a);
        }
    }


    }

