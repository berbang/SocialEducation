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
    
    public partial class Lesson
    {
        public Lesson()
        {
            this.Documents = new HashSet<Document>();
            this.Feeds = new HashSet<Feed>();
            this.Feeds1 = new HashSet<Feed>();
            this.UserLessonMaps = new HashSet<UserLessonMap>();
            this.Videos = new HashSet<Video>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageLink { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Createdate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string CreateUser { get; set; }
        public string Updateuser { get; set; }
        public Nullable<int> CommentControlId { get; set; }
        public Nullable<int> LikeControlId { get; set; }
    
        public virtual CommentControl CommentControl { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Feed> Feeds { get; set; }
        public virtual ICollection<Feed> Feeds1 { get; set; }
        public virtual LikeControl LikeControl { get; set; }
        public virtual ICollection<UserLessonMap> UserLessonMaps { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}
