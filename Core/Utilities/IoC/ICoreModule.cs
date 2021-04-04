using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Utilities.IoC
{
    //Farklı projelerde kullanabileceğimiz enjeksiyonların yönetimini sağlar.
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}
