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
    
    public partial class UserLessonMap
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LessonId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
    
        public virtual Lesson Lesson { get; set; }
        public virtual User User { get; set; }
    }
}
