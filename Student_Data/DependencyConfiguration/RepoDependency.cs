using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Student_Data.IRepo;
using Student_Data.Repository;

namespace Student_Data.DependencyConfiguration;

public static class RepoDependency
{
    public static void AddRepoDependency(this IServiceCollection services, IConfiguration configuration) {
        services.AddTransient<IStudentRepo, StudentRepo>();
    }
}
