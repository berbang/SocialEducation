using System;
using System.Web;

namespace SocialEducation.DataModel
{
    public class ContextHttpModule : IHttpModule
    {
        /// <summary>
        /// You will need to configure this module in the Web.config file of your
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule Members


        public void Dispose()
        {

        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(ContextBeginRequest);
            context.EndRequest += new EventHandler(ContextEndRequest);
        }

        #endregion

        private bool IsAspxRequest()
        {
            var request = HttpContext.Current.Request;
            return true; // request.CurrentExecutionFilePathExtension == ".aspx";
        }

        void ContextBeginRequest(object sender, EventArgs e)
        {
            if (IsAspxRequest())
            {
                ContextFactory.CreateContext();

                //Global_asax globalAsax = sender as Global_asax;
                //globalAsax.Response.Filter = new LocalizationFilter(globalAsax.Response.Filter);
            }
        }

        void ContextEndRequest(object sender, EventArgs e)
        {
            if (IsAspxRequest()) ContextFactory.DestroyContext();
        }



    }
}
