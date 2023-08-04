using VContainer;
using VContainer.Unity;

namespace unity.vcontainer.example.HelloWord
{
    public class GameLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<HelloWordService>(Lifetime.Singleton);
            builder.RegisterEntryPoint<GamePresenter>();
        }
    }
}