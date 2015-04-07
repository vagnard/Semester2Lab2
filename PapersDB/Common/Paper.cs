using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Paper
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Language { get; set; }
        public string Subject { get; set; }
        public int languageID { get; set; }
        public int subjectID { get; set; }
        
    }
}
