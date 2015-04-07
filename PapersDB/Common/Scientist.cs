using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Scientist
    {
        public int ID { get; set; }
        public int organisationID { get; set; }

        public string Name { get; set; }
        public string organisationName { get; set; }
        public string Email { get; set; }

        public float hindex { get; set; }
    }
}
