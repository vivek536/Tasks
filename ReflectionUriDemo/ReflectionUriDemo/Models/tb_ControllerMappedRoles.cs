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
    
    public partial class tb_ControllerMappedRoles
    {
        public int Id { get; set; }
        public Nullable<int> ControllerId { get; set; }
        public Nullable<int> roleId { get; set; }
    
        public virtual tb_Controller tb_Controller { get; set; }
        public virtual tb_Roles tb_Roles { get; set; }
    }
}
