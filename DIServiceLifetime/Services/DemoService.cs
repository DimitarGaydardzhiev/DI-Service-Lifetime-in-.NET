namespace DIServiceLifetime.Services
{
    public class DemoService : ISingletonService, IScopedService, ITransientService
    {
        private readonly string id;

        public DemoService()
        {
            this.id = Guid.NewGuid().ToString();
        }

        public string Id => this.id;
    }
}

