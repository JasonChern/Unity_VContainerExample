using VContainer;
using VContainer.Unity;

namespace unity.vcontainer.example.InjectSimple
{
    public class InjectByConstructor : IStartable
    {
        private readonly PrintService printService;
        
        [Inject]
        public InjectByConstructor(PrintService printService)
        {
            this.printService = printService;
        }

        public void Start()
        {
            printService.PrintMessage("InjectByConstructor");
        }
    }
}