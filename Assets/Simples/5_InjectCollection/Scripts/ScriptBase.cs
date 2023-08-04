using UnityEngine;

namespace unity.vcontainer.example.collection
{
    public interface IPrint
    {
        void Print(string message);
    }
    
    public abstract class ScriptBase
    {
        public abstract string Name { get; }
    }
    
    public class PrintScriptA : ScriptBase, IPrint
    {
        public override string Name => "A";
        public void Print(string message)
        {
            Debug.Log($"{Name}: {message}");
        }
    }
    
    public class PrintScriptB : ScriptBase, IPrint
    {
        public override string Name => "B";
        public void Print(string message)
        {
            Debug.Log($"{Name}: {message}");
        }
    }
}