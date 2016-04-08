﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using ConfigCenter.Common;

namespace ConfigCenter.Admin
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ObjectMapping.Init();

            if (!ZooKeeperHelper.Exists(ZooKeeperHelper.ZooKeeperRootNode))
            {
                ZooKeeperHelper.Create(ZooKeeperHelper.ZooKeeperRootNode, null);
            }

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
