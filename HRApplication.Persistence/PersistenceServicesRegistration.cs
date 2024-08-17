using HRApplication.Application.Contracts.Parsistence;
using HRApplication.Application.Contracts.Parsistence.CommonServices;
using HRApplication.Application.Contracts.Parsistence.EmployeeManagement;
using HRApplication.Persistence.Repositories;
using HRApplication.Persistence.Repositories.CommonServices;
using HRApplication.Persistence.Repositories.EmployeeManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApplication.Persistence;

public static class PersistenceServicesRegistration
{
    public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<HRApplicationDBContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("HRApplicationConnectionString")));


        services.AddScoped<IUnitofWork, UnitofWork>();

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

        services.AddScoped<IEmployeeBasicInfoRepository, EmployeeBasicInfoRepository>();

        return services;
    }
}

