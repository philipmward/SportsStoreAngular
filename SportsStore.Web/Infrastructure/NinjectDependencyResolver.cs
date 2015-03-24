using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SportsStore.Web.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        #region --fields--

        private IKernel kernel;

        #endregion --fields--

        #region --public methods--

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        #endregion --public methods--

        #region --private methods--

        private void AddBindings()
        {
            //kernel.Bind<IProductRepository>().To<EFProductRepository>();
        }

        #endregion --private methods--

        #region --ctor--

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        #endregion --ctor--
    }
}