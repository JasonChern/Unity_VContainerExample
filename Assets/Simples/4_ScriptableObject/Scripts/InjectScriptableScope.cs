using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace unity.vcontainer.example.ScriptableObject
{
    public class InjectScriptableScope : LifetimeScope
    {
        [SerializeField]
        private GameSetting gameSetting;
        
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterInstance(gameSetting);
            builder.RegisterEntryPoint<GamePresenter>(Lifetime.Scoped);
        }
    }
}