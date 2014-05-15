using SocialEducation.DataModel.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SocialEducation.DataModel;
using SocialEducation.Business;

namespace SocialEducation
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CommentRepository.Find(p => p.Id == 1).ToList();
        }

        protected void dfs_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

        }

        protected void btnLogon_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = txtName.Value;
            user.Surname = txtSurname.Value;
            user.UserName = txtUserName.Value;
            user.Password = txtPassword3.Value;
            user.Email = txtEmail.Value;
            UserService.Save(user);
        }
    }
}