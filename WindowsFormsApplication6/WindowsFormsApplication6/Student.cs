using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6
{
    [Serializable]
    public class Student
    {
        public string surName { set; get; }
        public string name { set; get; }
        public int course { set; get; }
    }
}
