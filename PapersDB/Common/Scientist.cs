//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common
{
    using System;
    using System.Collections.Generic;
    
    public partial class Scientist
    {
        public Scientist()
        {
            this.Auths_papers = new HashSet<Auths_papers>();
            this.Reviewers_papers = new HashSet<Reviewers_papers>();
        }
    
        public int s_id { get; set; }
        public Nullable<double> s_hindex { get; set; }
        public Nullable<int> org_id { get; set; }
        public string s_name { get; set; }
        public string s_email { get; set; }
    
        public virtual ICollection<Auths_papers> Auths_papers { get; set; }
        public virtual Organisation Organisation { get; set; }
        public virtual ICollection<Reviewers_papers> Reviewers_papers { get; set; }
    }
}
