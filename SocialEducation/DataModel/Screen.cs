//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocialEducation.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Screen
    {
        public Screen()
        {
            this.RoleScreenMaps = new HashSet<RoleScreenMap>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    
        public virtual ICollection<RoleScreenMap> RoleScreenMaps { get; set; }
    }
}
