using SocialEducation.DataModel;
using SocialEducation.DataModel.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialEducation.Business
{
    public class UserService
    {
        public static void Save(User user)
        {
            UserRepository.PrepareToSave(user);
            UserRepository.SaveChanges();
        }
    }
}