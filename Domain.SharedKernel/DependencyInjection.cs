using Domain.SharedKernel.HelperFunctions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.SharedKernel
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomainShardKernelCollection(this IServiceCollection services,
            IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            var workerId = configuration.GetValue<int>("Snowflake:WorkerId");
            IdGeneratorFactory.Initialize(workerId);

            //for mediatR,register it at the application layer
            return services;
        }
    }
}
