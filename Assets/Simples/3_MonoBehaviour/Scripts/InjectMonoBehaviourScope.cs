using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace unity.vcontainer.example.MonoBehaviour
{
    public class InjectMonoBehaviourScope : LifetimeScope
    {
        [SerializeField]
        private MonoBehaviourForSerializeField monoBehaviourForSerializeField;
        
        [SerializeField]
        private MonoBehaviourForPrefab prefab;
        
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<PrintService>(Lifetime.Scoped);

            // style 1
            // builder.RegisterComponent(monoBehaviourForSerializeField); // or builder.RegisterInstance(monoBehaviourForReference);
            // builder.RegisterComponentInHierarchy<MonoBehaviourForHierarchy>();
            // builder.RegisterComponentOnNewGameObject<MonoBehaviourForNewObject>(Lifetime.Scoped, "NewObject");
            // builder.RegisterComponentInNewPrefab(prefab, Lifetime.Scoped);
            
            // style 2
            builder.UseComponents(components =>
            {
                components.AddInstance(monoBehaviourForSerializeField);
                components.AddInHierarchy<MonoBehaviourForHierarchy>();
                components.AddOnNewGameObject<MonoBehaviourForNewObject>(Lifetime.Scoped, "NewObject");
                components.AddInNewPrefab(prefab, Lifetime.Scoped);
            });
            
            builder.RegisterBuildCallback(container =>
            {
                var triggerNewObject = container.Resolve<MonoBehaviourForNewObject>();
                var triggerPrefab = container.Resolve<MonoBehaviourForPrefab>();
            });
        }
    }
}