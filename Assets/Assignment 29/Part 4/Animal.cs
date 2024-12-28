 using UnityEngine;
 public class Animal
    {
        public virtual void MakeSound()
        {
            Debug.Log("Animal sound");
        }
        public virtual void Move()
        {
            Debug.Log("Animal moves");
        }
    }
    public class Cat : Animal ,ICanFight
    {
        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }
        public override void Move()
        {
            Debug.Log("Cat runs quickly.");
        }
        public void Attack()
        {
            Debug.Log("Cat Attacks with claws!");
        }
    }
    public interface ICanFight
    {
        void Attack();
    }
    public class Warrior : ICanFight
    {
        public void Attack()
        {
            Debug.Log("Warrior attacks with a sword!");
        }
    }