This tutorial lets you wire MVC4 and Ninject together. At the end of this tutorial you will be able to use ninject in both mvc and webapi project.

Step 1:
---
Install-Package Ninject -Version 3.2.0.0
Install-Package Ninject.Web.Common -Version 3.2.0.0
Install-Package Ninject.MVC4 -Version 3.2.1.0
Install-Package Ninject.Web.Common.WebHost -Version 3.2.0.0

Step 2:
---
Add FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters) before  RouteConfig.RegisterRoutes(RouteTable.Routes) in Global.asax

Step 3:
---
Add mapping kernel.Bind< Interface >().To < ConcreteClass >() in RegisterServices. 

Step 4:
---
Add  GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel) in CreateKernel method in NinjectWebCommon.cs

Step 5:
---
Add NinjectDependencyResolver.cs and NinjectDependencyScope.cs in App_Start
