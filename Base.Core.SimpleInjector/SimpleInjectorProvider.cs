using Base.Core.Injector;
using SimpleInjector;
using System;

namespace Base.Core.SimpleInjector
{
    public class SimpleInjectorProvider : IInjector, IDisposable
    {
        private readonly Container _container;
        private static SimpleInjectorProvider _currentInjector;
        private static readonly object Locker = new object();

        private SimpleInjectorProvider()
        {
            _container = new Container();
        }

        public static SimpleInjectorProvider Current()
        {
            lock (Locker)
            {
                return _currentInjector ?? (_currentInjector = new SimpleInjectorProvider());
            }
        }

        void IInjector.AddScoped<TService, TImplementation>()
        {
            _container.Register<TService, TImplementation>(Lifestyle.Scoped);
        }

        void IInjector.AddSingleton<TService, TImplementation>()
        {
            _container.Register<TService, TImplementation>(Lifestyle.Singleton);
        }

        void IInjector.AddTransient<TService, TImplementation>()
        {
            _container.Register<TService, TImplementation>(Lifestyle.Transient);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _container?.Dispose();
                _currentInjector = null;
            }
        }

        public Container GetContainer()
        {
            return _container;
        }
    }
}
