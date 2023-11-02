using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CloudSuite.Infrastructure.CrossCutting.DependencyInjector
{
    public static class MediatorServiceCollectionExtension
    {
        public static IServiceCollection AddMediator(this IServiceCollection services)
        {
            var assembly = AppDomain.CurrentDomain.Load("CloudSuite.Modules.Application");

            AssemblyScanner
                .FindValidatorsInAssembly(assembly)
                .ForEach(result => services.AddScoped(result.InterfaceType, result.ValidatorType));

            //services.AddScoped(typeof(IPipelineBehavior<,>), typeof(FailFastRequestBehavior<,>));

            services.AddMediatR(assembly);
            return services;
        }
        
    }
}