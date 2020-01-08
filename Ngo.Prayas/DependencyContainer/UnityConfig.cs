using Ngo.Prayas.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Ngo.Prayas.DependencyContainer
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IEventsRepository, EventRepository>();
            container.RegisterType<IContactUsRepository, ContactUsRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}