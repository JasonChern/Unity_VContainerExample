using VContainer;
using VContainer.Unity;

namespace unity.vcontainer.example.collection
{
    public class InjectCollectionScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<GamePresenter>(Lifetime.Scoped);
            builder.Register<ScriptBase, PrintScriptA>(Lifetime.Scoped).AsImplementedInterfaces().AsSelf();
            builder.Register<ScriptBase, PrintScriptB>(Lifetime.Scoped).AsImplementedInterfaces().AsSelf();
        }
    }
}