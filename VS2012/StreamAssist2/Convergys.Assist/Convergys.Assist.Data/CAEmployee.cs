//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Convergys.Assist.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class CAEmployee
    {
        public CAEmployee()
        {
            this.CAPassword = new HashSet<CAPassword>();
        }
    
        public decimal EmpId { get; set; }
        public Nullable<int> EmpNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public Nullable<decimal> SiteId { get; set; }
        public Nullable<int> TeamId { get; set; }
        public Nullable<decimal> ManagerId { get; set; }
    
        public virtual CASite CASite { get; set; }
        public virtual ICollection<CAPassword> CAPassword { get; set; }
    }
}
