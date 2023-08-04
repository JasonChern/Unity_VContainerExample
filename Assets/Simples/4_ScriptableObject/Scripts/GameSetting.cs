using System;
using UnityEngine;

namespace unity.vcontainer.example.ScriptableObject
{
    [CreateAssetMenu(fileName = "GameSettings", menuName = "MyGame/Settings")]
    public class GameSetting : UnityEngine.ScriptableObject
    {
        [SerializeField]
        public CameraSettings cameraSetting;

        [SerializeField]
        public ActorSettings actorSettings;
    }
    
    [Serializable]
    public class CameraSettings
    {
        public float MoveSpeed = 10f;
        public float DefaultDistance = 5f;
        public float ZoomMax = 20f;
        public float ZoomMin = 5f;
    }

    [Serializable]
    public class ActorSettings
    {
        public float MoveSpeed = 0.5f;
        public float FlyingTime = 2f;
        public Vector3 FlyingInitialVelocity = Vector3.zero;
    }
}