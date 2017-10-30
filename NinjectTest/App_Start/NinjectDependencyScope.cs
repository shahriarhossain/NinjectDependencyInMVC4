using System;
using System.Web.Http.Dependencies;
using Ninject;
using Ninject.Syntax;

namespace NinjectTest
{
    public class NinjectDependencyScope : IDependencyScope
    {
        IResolutionRoot resolver;

        public NinjectDependencyScope(IResolutionRoot resolver)
        {
            this.resolver = resolver;
        }

        public object GetService(Type serviceType)
        {
            if (resolver == null)
                throw new ObjectDisposedException("this", "This scope has been disposed");

            //This will give detail error
            //IRequest request = resolver.CreateRequest(serviceType, null, new Parameter[0], true, true);
            //return resolver.Resolve(request).SingleOrDefault();

            return resolver.TryGet(serviceType);
        }

        public System.Collections.Generic.IEnumerable<object> GetServices(Type serviceType)
        {
            if (resolver == null)
                throw new ObjectDisposedException("this", "This scope has been disposed");

            //This will give detail error
            //IRequest request = resolver.CreateRequest(serviceType, null, new Parameter[0], true, true);
            //return resolver.Resolve(request).ToList();

            return resolver.GetAll(serviceType);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);       
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                IDisposable disposable = resolver as IDisposable;
                if (disposable != null)
                    disposable.Dispose();

                resolver = null;
            }
        }
    }
}