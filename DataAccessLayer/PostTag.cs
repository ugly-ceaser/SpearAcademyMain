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
    
    public partial class PostTag
    {
        public int ID { get; set; }
        public int PostID { get; set; }
        public string TagContent { get; set; }
        public System.DateTime AddDate { get; set; }
        public bool isDeleted { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public int LastUpdateUserID { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
    }
}
