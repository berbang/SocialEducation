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
    
    public partial class Feed
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<int> User1Id { get; set; }
        public Nullable<int> User2Id { get; set; }
        public string PublicText { get; set; }
        public string PrivateText { get; set; }
        public Nullable<int> LessonId { get; set; }
        public Nullable<int> VideoId { get; set; }
        public Nullable<int> DocumentId { get; set; }
    
        public virtual Document Document { get; set; }
        public virtual Lesson Lesson { get; set; }
        public virtual Lesson Lesson1 { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual Video Video { get; set; }
    }
}