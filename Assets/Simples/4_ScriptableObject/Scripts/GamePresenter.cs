using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace unity.vcontainer.example.ScriptableObject
{
    public class GamePresenter : IStartable
    {
        [Inject]
        private readonly GameSetting gameSetting;
        
        public void Start()
        {
            Debug.Log($"CameraSetting DefaultDistance:{gameSetting.cameraSetting.DefaultDistance}");
            Debug.Log($"ActorSetting MoveSpeed:{gameSetting.actorSettings.MoveSpeed}");
        }
    }
}