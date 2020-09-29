using AutoMapper;
using Session6_WebApi.API.Common.Settings;
using Session6_WebApi.IoC.Configuration.AutoMapper;
using Session6_WebApi.Services;
using Session6_WebApi.Services.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Session6_WebApi.IoC.Configuration.DI
{
    public static class ServiceCollectionExtensions
    {
        public static AppSettings ConfigureBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            var appSettingsSection = configuration.GetSection(nameof(AppSettings));
            if (appSettingsSection == null)
                throw new System.Exception("No appsettings section has been found");

            var appSettings = appSettingsSection.Get<AppSettings>();

            if (!appSettings.IsValid())
                throw new Exception("No valid settings.");

            services.Configure<AppSettings>(appSettingsSection);

            //Automap settings
            services.AddAutoMapper();
            MappingConfigurationsHelper.ConfigureMapper();

            services.AddTransient<IUserService, UserService>();

            return appSettings;
        }
    }
}
