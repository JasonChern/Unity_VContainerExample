using VContainer;
using VContainer.Unity;

namespace unity.vcontainer.example.InjectSimple
{
    public class InjectSimpleScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<PrintService>(Lifetime.Singleton);
            builder.RegisterEntryPoint<InjectByConstructor>();
            builder.RegisterEntryPoint<InjectByMethod>();
            builder.RegisterEntryPoint<InjectByProperty>();
            builder.RegisterEntryPoint<InjectByField>();
        }
    }
}