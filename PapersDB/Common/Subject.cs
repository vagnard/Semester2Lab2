using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Subject() { }
        public Subject(string Name)
        {
            this.Name = Name;
        }
    }
}
