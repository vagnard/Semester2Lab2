using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Language
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Language() { }
        public Language(string Name)
        {
            this.Name = Name;
        }
    }
}
