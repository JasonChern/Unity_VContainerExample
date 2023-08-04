using VContainer;
using VContainer.Unity;

namespace unity.vcontainer.example.InjectSimple
{
    public class InjectByProperty : IStartable
    {
        [Inject]
        private PrintService printService { get; set; }

        public void Start()
        {
            printService.PrintMessage("InjectByProperty");
        }
    }
}