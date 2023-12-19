﻿using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace RevolutionPMS.Infrastructure;

public static class Extentions
{
    public static void AddApplicationServices(this IServiceCollection services, Type serviceType)
    {
        Assembly? serviceAssembly = Assembly.GetAssembly(serviceType);
        if (serviceAssembly == null)
        {
            throw new InvalidOperationException("Invalid service type provided!");
        }

        IEnumerable<Type> serviceTypes = serviceAssembly
            .GetTypes()
            .Where(x => x.Name.EndsWith("Service") && !x.IsInterface);

        foreach (var implementationType in serviceTypes)
        {
            Type? interfaceType = implementationType.GetInterface($"I{implementationType.Name}");
            if (interfaceType == null)
            {
                throw new InvalidOperationException("Invalid service contract type provided!");
            }

            services.AddScoped(interfaceType, implementationType);
        }
    }

}

