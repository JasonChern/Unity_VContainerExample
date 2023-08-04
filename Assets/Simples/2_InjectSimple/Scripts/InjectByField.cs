using VContainer;
using VContainer.Unity;

namespace unity.vcontainer.example.InjectSimple
{
    public class InjectByField : IStartable
    {
        [Inject]
        private readonly PrintService printService;
            
        public void Start()
        {
            printService.PrintMessage("InjectByField");
        }
    }
}