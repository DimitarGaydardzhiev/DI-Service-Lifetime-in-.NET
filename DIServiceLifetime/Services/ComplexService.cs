namespace DIServiceLifetime.Services
{
    public class ComplexService : IComplexService
    {
        private readonly ISingletonService singletonService;

        private readonly ITransientService transientService;

        private readonly IScopedService scopedService;

        public ComplexService(
            ISingletonService singletonService,
            ITransientService transientService, 
            IScopedService scopedService)
        {
            this.singletonService = singletonService;
            this.transientService = transientService;
            this.scopedService = scopedService;
        }

        public IScopedService ScopedService => this.scopedService;

        public ITransientService TransientService => this.transientService;

        public ISingletonService SingletonService => this.singletonService;
    }
}
