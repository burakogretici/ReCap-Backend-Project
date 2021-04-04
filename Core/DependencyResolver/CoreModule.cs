using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Core.DependencyResolver
{
    public class CoreModule : ICoreModule
    {
        //Uygulama için hizmet bağımlılıklarının çözüleceği yer.
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache(); //IMemoryCache enjekte edilir.
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<Stopwatch>();
        }
    }
}