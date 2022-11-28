namespace DIServiceLifetime.Services
{
    public interface IComplexService
    {
        public IScopedService ScopedService { get; }

        public ITransientService TransientService { get; }

        public ISingletonService SingletonService { get; }
    }
}