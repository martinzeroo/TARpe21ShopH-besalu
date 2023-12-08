using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TARpe21ShopHõbesalu.ApplicationServices.Services;
using TARpe21ShopHõbesalu.Core.ServiceInterface;
using TARpe21ShopHõbesalu.Data;
using TARpe21ShopHõbesalu.SpaceshipTest.Mock;
using ZendeskApi_v2.Requests;

namespace TARpe21ShopHõbesalu.SpaceshipTest
{
    public abstract class TestBase
    {
        protected IServiceProvider serviceProvider { get; set; }

        protected TestBase()
        {
            var services = new ServiceCollection();
            SetupServices(services);
            serviceProvider = services.BuildServiceProvider();
        }
        public void Dispose() { }
        protected T Svc<T>()
        {
            return serviceProvider.GetService<T>();
        }
        protected T Macro<T>() where T : IMacros
        {
            return serviceProvider.GetService<T>();
        }
        public virtual void SetupServices(IServiceCollection services)
        {
            services.AddScoped<ISpaceshipsServices, SpaceshipsServices>();
            services.AddScoped<IFilesServices, FilesServices>();
            services.AddScoped<IHostingEnvironment, MockIHostEnvironment>();

            services.AddDbContext<TARpe21ShopHõbesaluContext>
                (x =>
                {
                    x.UseInMemoryDatabase("TEST");
                    x.ConfigureWarnings(e => e.Ignore(InMemoryEventId.TransactionIgnoredWarning));
                });
            RegisterMacros(services);
        }
        private void RegisterMacros(IServiceCollection services)
        {
            var macroBaseType = typeof(IMacros);
            var macros = macroBaseType.Assembly.GetTypes()
                .Where(x => macroBaseType.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract);
            foreach (var macro in macros)
            {
                services.AddSingleton(macro);
            }
        }
    }
}