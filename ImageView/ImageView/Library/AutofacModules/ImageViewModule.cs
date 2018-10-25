﻿using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Autofac;
using AutoMapper;
using GeneralToolkitLib.Storage.Memory;
using ImageViewer.Managers;
using ImageViewer.Repositories;
using ImageViewer.Services;
using Module = Autofac.Module;

namespace ImageViewer.Library.AutofacModules
{
    public class ImageViewModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PasswordStorage>().SingleInstance();

            builder.RegisterAssemblyTypes(typeof(ManagerBase).Assembly)
                .AssignableTo<ManagerBase>()
                .AsSelf()
                .AsImplementedInterfaces()
                .SingleInstance();

            builder.RegisterAssemblyTypes(typeof(ServiceBase).Assembly)
                .AssignableTo<ServiceBase>()
                .AsSelf()
                .AsImplementedInterfaces()
                .SingleInstance();
            
            builder.RegisterAssemblyTypes(typeof(RepositoryBase).Assembly)
                .AssignableTo<RepositoryBase>()
                .AsSelf()
                .AsImplementedInterfaces()
                .SingleInstance();

            builder.Register(context => context.Resolve<MapperConfiguration>()
                    .CreateMapper())
                .As<IMapper>()
                .AutoActivate()
                .SingleInstance();

            builder.Register(Configure)
                .AutoActivate()
                .AsSelf()
                .AsImplementedInterfaces()
                .SingleInstance();

            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly)
                .AssignableTo<Form>()
                .AsSelf()
                .InstancePerDependency();
        }

        private static MapperConfiguration Configure(IComponentContext context)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                var innerContext = context.Resolve<IComponentContext>();
                cfg.ConstructServicesUsing(innerContext.Resolve);

                foreach (var profile in context.Resolve<IEnumerable<Profile>>())
                {
                    cfg.AddProfile(profile);
                }
            });

            return configuration;
        }
    }
}
