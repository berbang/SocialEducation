using SocialEducation.DataModel.Repository;
//using SocialEducation.DataModel.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialEducation.DataModel
{
    public class ContextFactory
    {
        public static readonly string CONTEXT_KEY = "CONTEXT_KEY";
        public static readonly string CONTEXT_REFRESH_KEY = "CONTEXT_REFRESH_KEY";
        public static UzaktanEgitimEntities Context
        {
            get
            {
                var ctx = (UzaktanEgitimEntities)System.Web.HttpContext.Current.Items[CONTEXT_KEY];
                return ctx;
            }
        }

        public static void CreateContext()
        {
            System.Web.HttpContext.Current.Items[CONTEXT_KEY] = new UzaktanEgitimEntities();
        }

        public static void DestroyContext()
        {
            if (Context != null)
                Context.Dispose();
        }

        public static void RefreshContextIfNotRefreshed()
        {
            if (!IsContextRefreshed())
                RefreshContext();
        }

        private static void RefreshContext()
        {
            DestroyContext();
            CreateContext();
            System.Web.HttpContext.Current.Items[CONTEXT_REFRESH_KEY] = true;
        }

        private static bool IsContextRefreshed()
        {
            return ((bool?)System.Web.HttpContext.Current.Items[CONTEXT_REFRESH_KEY] == true);
        }


    }
}
