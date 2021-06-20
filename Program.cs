using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student_Info instance = new Student_Info();
            instance.Setid("S100");
            instance.Setname("Tom");
            instance.Setmarks(70);

            string idvalue = instance.Getid();
            string namevalue = instance.Getname();
            int marksvalue = instance.Getmarks();

            System.Console.WriteLine(idvalue);
            System.Console.WriteLine(namevalue);
            System.Console.WriteLine(marksvalue);
        }
    }
}
