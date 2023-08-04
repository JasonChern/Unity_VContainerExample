using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace unity.vcontainer.example.MonoBehaviour
{
    public class InjectMonoBehaviourByParentScope : LifetimeScope
    {
        [SerializeField]
        private Transform parent;
        
        [SerializeField]
        private MonoBehaviourForSerializeField monoBehaviourForSerializeField;
        
        [SerializeField]
        private MonoBehaviourForPrefab prefab;
        
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<PrintService>(Lifetime.Scoped);

            // style 1
            // builder.RegisterComponent(monoBehaviourForSerializeField);
            // builder.RegisterComponentInHierarchy<MonoBehaviourForHierarchy>()
            //     .UnderTransform(parent);
            // builder.RegisterComponentOnNewGameObject<MonoBehaviourForNewObject>(Lifetime.Scoped, "NewObject")
            //     .UnderTransform(parent);
            // builder.RegisterComponentInNewPrefab(prefab, Lifetime.Scoped)
            //     .UnderTransform(parent);
            
            // style 2
            builder.UseComponents(parent,components =>
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