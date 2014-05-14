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
    
    public partial class User
    {
        public User()
        {
            this.Feeds = new HashSet<Feed>();
            this.Feeds1 = new HashSet<Feed>();
            this.Likes = new HashSet<Like>();
            this.Messages = new HashSet<Message>();
            this.Messages1 = new HashSet<Message>();
            this.RoleUsers = new HashSet<RoleUser>();
            this.UserLessonMaps = new HashSet<UserLessonMap>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ImageLink { get; set; }
        public string Phone { get; set; }
        public Nullable<bool> IsEmailSent { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateUser { get; set; }
    
        public virtual ICollection<Feed> Feeds { get; set; }
        public virtual ICollection<Feed> Feeds1 { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Message> Messages1 { get; set; }
        public virtual ICollection<RoleUser> RoleUsers { get; set; }
        public virtual ICollection<UserLessonMap> UserLessonMaps { get; set; }
    }
}
