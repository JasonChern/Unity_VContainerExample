using VContainer;
using VContainer.Unity;

namespace unity.vcontainer.example.InjectSimple
{
   public class InjectByMethod : IStartable
   {
       private PrintService printService;
       
       [Inject]
       private void InjectServices(PrintService printService)
       {
           this.printService = printService;
       }

       public void Start()
       {
           printService.PrintMessage("InjectByMethod");
       }
   }
}