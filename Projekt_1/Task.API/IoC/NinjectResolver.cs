using AutoMapper;
using Ninject;
using Ninject.Extensions.ChildKernel;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Task.Core.Repositories;
using Task.Infrastructure.Mappers;
using Task.Infrastructure.Repositories;
using Task.Infrastructure.Services.Implementation;
using Task.Infrastructure.Services.Interface;

namespace Task.API.IoC
{
    public class NinjectResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectResolver() : this(new StandardKernel())
        {

        }

        public NinjectResolver(IKernel ninjectKernel, bool scope = false)
        {
            kernel = ninjectKernel;
            if (!scope)
            {
                AddBindings(kernel);
            }
        }

        private void AddBindings(IKernel kernel)
        {
            // singleton and transient bindings go here
        }

        private IKernel AddRequestBindings(IKernel kernel)
        {
            kernel.Bind<IGuestRepository>().To<GuestRepository>();
            kernel.Bind<IReservationRepository>().To<ReservationRepository>();
            kernel.Bind<IGuestService>().To<GuestService>();
            kernel.Bind<IReservationService>().To<ReservationService>();

            kernel.Rebind<IMapper>().ToMethod(context => AutoMapperConfig.Initialize());

            return kernel;
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectResolver(AddRequestBindings(new ChildKernel(kernel)), true);
        }

        public void Dispose()
        {
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}