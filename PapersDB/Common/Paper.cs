using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Paper
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Abstract { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Language { get; set; }
        public string JournalName { get; set; }
        public string UDC { get; set; }
        public string Subject { get; set; }

        
    }
}
