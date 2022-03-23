using Microsoft.Extensions.DependencyInjection;
using Servicee.Contract;
using Servicee.Implementazione;

namespace Servicee
{
    public static class ServiceDependecies
    {




        public static IServiceCollection AddServices(this IServiceCollection
     services)
        {
            services
                .AddTransient<IUtenteService, UtenteService>()
                .AddTransient<IIndirizzoService, IndirizzoService>()
                .AddTransient<ICartadicreditoService, CartadiCreditoService>()
                .AddTransient<IPersonaService, PersonaService>()
                .AddTransient<IRegioneService, RegioneService>()
                .AddTransient<IBiciService, BiciService>()
                .AddTransient<IAcquistiService, AcquistiService>();


            return services;

        }
    }
}
