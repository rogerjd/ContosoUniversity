using Entities.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Entities.Context;
using System.Data.Entity.Infrastructure.Interception;

namespace ContosoUniversity
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //can put in Configuration too
            //            DbInterception.Add(new SchoolInterceptorTransientErrors());
            DbInterception.Add(Creator.site);
            DbInterception.Add(new SchoolInterceptorLogging());


/* alt: initializer seed
            IDatabaseInitializer<SchoolContext> strategy = null;
            Database.SetInitializer<SchoolContext>(strategy); 
*/
        }
    }
}
