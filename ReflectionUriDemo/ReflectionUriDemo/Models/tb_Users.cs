//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReflectionUriDemo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Users()
        {
            this.tb_UserMappedRoles = new HashSet<tb_UserMappedRoles>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Passwod { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_UserMappedRoles> tb_UserMappedRoles { get; set; }
    }
}
