using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace unity.vcontainer.example.MonoBehaviour
{
    public class InjectMonoBehaviourByOnDontDestroy : LifetimeScope
    {
        [SerializeField]
        private MonoBehaviourForSerializeField monoBehaviourForSerializeField;
        
        [SerializeField]
        private MonoBehaviourForPrefab prefab;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<PrintService>(Lifetime.Scoped);

            // style 1
            builder.RegisterComponent(monoBehaviourForSerializeField);
            builder.RegisterComponentInHierarchy<MonoBehaviourForHierarchy>()
                .DontDestroyOnLoad();
            builder.RegisterComponentOnNewGameObject<MonoBehaviourForNewObject>(Lifetime.Scoped, "NewObject")
                .DontDestroyOnLoad();
            builder.RegisterComponentInNewPrefab(prefab, Lifetime.Scoped)
                .DontDestroyOnLoad();

            builder.RegisterBuildCallback(container =>
            {
                var triggerNewObject = container.Resolve<MonoBehaviourForNewObject>();
                var triggerPrefab = container.Resolve<MonoBehaviourForPrefab>();
            });
        }
    }
}