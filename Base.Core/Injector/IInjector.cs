namespace Base.Core.Injector
{
    public interface IInjector
    {
        void AddScoped<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService;

        void AddSingleton<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService;

        void AddTransient<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService;

        //void AddTransient(Type service, Type implementation);
    }
}
