using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using ConsoleApplication1.ADD;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Company> objList = new List<Company>();

            Company obj1 = new Company();
            obj1.Id = 1001;
            obj1.Name = "A";
            obj1.Salary = 5000;

            objList.Add(obj1);

            Company obj2 = new Company();
            obj2.Id = 1002;
            obj2.Name = "B";
            obj2.Salary = 6000;

            objList.Add(obj2);

            Company obj3 = new Company();
            obj3.Id = 1003;
            obj3.Name = "C";
            obj3.Salary = 7000;

            objList.Add(obj3);

            Company obj4 = new Company();
            obj4.Id = 1004;
            obj4.Name = "D";
            obj4.Salary = 8000;

            objList.Add(obj4);

            XmlSerializer dsdsd = new XmlSerializer(typeof(List<Company>));
            StringWriter stream = new StringWriter();

               dsdsd.Serialize(stream, objList);
                string dfgd=stream.ToString();


             
        }

        
    }
}
