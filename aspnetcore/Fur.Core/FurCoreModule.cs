﻿using Autofac;
using Fur.DatabaseAccessor.Repositories.Interceptors;

namespace Fur.Core
{
    public class FurCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FurDbEntityInterceptor>()
                .As<IDbEntityInterceptor>()
                .SingleInstance();
        }
    }
}