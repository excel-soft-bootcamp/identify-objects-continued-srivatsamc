using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
#region Definition of Class
    class Student_Info
    {
#region User defined private data types
        private string id;
        private string name;
        private int marks;
        #endregion

#region Intializing User defined data types
        public string Getid()
        {
            return this.id;
        }

        public void Setid(string id)
        {
           this.id=id;
        }

        public string Getname()
        {
            return this.name;
        }

        public void Setname(string name)
        {
             this.name=name;
        }

        public int Getmarks()
        {
            return this.marks;
        }

        public void Setmarks(int marks)
        {
            this.marks=marks;
        }
#endregion
    }
#endregion
}
