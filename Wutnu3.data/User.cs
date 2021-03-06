//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wutnu.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.UserAssignments = new HashSet<UserAssignment>();
            this.WutLinks = new HashSet<WutLink>();
        }
    
        public int UserId { get; set; }
        public string UserOID { get; set; }
        public string PrimaryEmail { get; set; }
        public string ExtClaims { get; set; }
        public string ApiKey { get; set; }
        public string iss { get; set; }
        public string idp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAssignment> UserAssignments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WutLink> WutLinks { get; set; }
    }
}
