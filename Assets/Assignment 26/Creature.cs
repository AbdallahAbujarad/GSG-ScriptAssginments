using UnityEngine;

namespace Assignment26
{
    public class Creature
    {
        public virtual void Speak()
        {
            Debug.Log("Make a sound");
        } 
    }
    public interface IRunable
    {
        void Run();
    }
    public interface IJumpable
    {
        void Jump();
    }
    public interface ISwimable
    {
        void Swim();
    }
    public class Kangaroo : Creature ,IRunable,IJumpable
    {
        public void Run()
        {
            Debug.Log("Kangaroo runs.");
        }
        public void Jump()
        {
            Debug.Log("Kangaroo jumps.");
        }
        public override void Speak()
        {
            Debug.Log("Kangaroo Says : Hop!");
        }
        
    }
    public class Duck : Creature ,IRunable,ISwimable
    {
        public void Run()
        {
            Debug.Log("Duck runs.");
        }
        public void Swim()
        {
            Debug.Log("Duck swims.");
        }
        public override void Speak()
        {
            Debug.Log("Duck Says : Quack!");
        }
        
    }
}

