namespace NancyEmbeddedSharedDependencySample.Nancy
{
    using global::Nancy;
    using global::Nancy.TinyIoc;

    public class BootstrapperWithPassedContainer : DefaultNancyBootstrapper
    {
        private readonly TinyIoCContainer appContainer;

        public BootstrapperWithPassedContainer(TinyIoCContainer appContainer)
        {
            // Store the passed in container
            this.appContainer = appContainer;
        }

        protected override TinyIoCContainer GetApplicationContainer()
        {
            // Use the passed in container as our app container
            return appContainer;
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            // Don't call base as this will run AutoRegister and overwrite our registration
        }
    }
}