using System;
using Boxed.Mapping;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Commands;
using WebApplication1.Mappers;
using WebApplication1.Repositories;
using WebApplication1.Services;

namespace WebApplication1
{
    /// <summary>
    /// ������� ������ �������
    /// </summary>
    public static class ProjectServiceCollectionExtensions
    {
        public static IServiceCollection AddProjectCommands(this IServiceCollection services) =>
            services
                .AddTransient<IDeleteTenantCommand, DeleteTenantCommmand>()
                .AddTransient<IGetTenantRequest, GetTenantRequest>()
                .AddTransient<IGetTenantPageRequest, GetTenantPageRequest>()
                .AddTransient<IPostTenantCommand, PostTenantCommand>()
                .AddTransient<IPutTenantCommand, PutTenantCommand>()
                .AddTransient<IPatchTenantCommand, PatchTenantCommand>();

        public static IServiceCollection AddProjectRepositories(this IServiceCollection services)=>
            services.AddSingleton<ITenantRepository,TenantRepository>();

        public static IServiceCollection AddProjectMappers(this IServiceCollection services) =>
            services
                .AddTransient<IMapper<Data.Tenant, ViewModels.Tenant>, TenantToTenantMapper>()
                .AddSingleton<IMapper<Data.Tenant, ViewModels.SaveTenant>, TenantToSaveTenantMapper>()
                .AddSingleton<IMapper<ViewModels.SaveTenant, Data.Tenant>, TenantToSaveTenantMapper>();

        public static IServiceCollection AddProjectServices(this IServiceCollection services) =>
            services
                .AddSingleton<IClockService, ClockService>()
                .AddScoped<IHostTenantInfo, HostTenantInfo>();
    }
}
