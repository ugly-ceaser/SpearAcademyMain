//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProcessType
    {
        public ProcessType()
        {
            this.Log_Table = new HashSet<Log_Table>();
        }
    
        public int ID { get; set; }
        public string ProcessName { get; set; }
    
        public virtual ICollection<Log_Table> Log_Table { get; set; }
    }
}
