using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Student_Business.IService;
using Student_Business.Service;
using Student_Data.DependencyConfiguration;

namespace Student_Business.DependencyConfiguration;

public static class ServiceDependency
{
    public static void AddServiceDependency(this IServiceCollection services, IConfiguration configuration) {
        services.AddRepoDependency(configuration);
        services.AddTransient<IStudentService, StudentService>();
    }
}
