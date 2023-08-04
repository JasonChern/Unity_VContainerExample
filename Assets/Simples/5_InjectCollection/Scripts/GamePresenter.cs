using System.Collections.Generic;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace unity.vcontainer.example.collection
{
    public class GamePresenter : IStartable
    {
        [Inject]
        private IReadOnlyList<IPrint> interfacePrints;
        
        [Inject]
        private IReadOnlyList<ScriptBase> scriptBases;
        
        [Inject]
        private readonly PrintScriptA printScriptA;

        [Inject]
        private readonly PrintScriptB PrintScriptB;

        public void Start()
        {
            foreach (var interfacePrint in interfacePrints)
            {
                interfacePrint.Print("Get by interface IPrint");
            }

            foreach (var script in scriptBases)
            {
                Debug.Log($"Get by ScriptBase => {script.Name}");
            }
            
            printScriptA.Print("Get by PrintScriptA");
            PrintScriptB.Print("Get by PrintScriptB");
        }
    }
}