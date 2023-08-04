using VContainer;
using VContainer.Unity;

namespace unity.vcontainer.example.HelloWord
{
    public class GamePresenter : ITickable
    {
        private readonly HelloWordService helloWordService;
        
        [Inject]
        public GamePresenter(HelloWordService helloWordService)
        {
            this.helloWordService = helloWordService;
        }

        public void Tick()
        {
            helloWordService.Hello();
        }
    }
}