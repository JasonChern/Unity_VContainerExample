using VContainer;

namespace unity.vcontainer.example.MonoBehaviour
{
    public class MonoBehaviourForHierarchy : UnityEngine.MonoBehaviour
    {
        [Inject]
        private readonly PrintService printService;
        
        private void Start()
        {
            printService.PrintMessage($"Hello by {nameof(MonoBehaviourForHierarchy)}!");
        }
    }
}