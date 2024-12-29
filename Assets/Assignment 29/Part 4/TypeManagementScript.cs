using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class TypeManagementScript : MonoBehaviour
    {
        List<ICanFight> canFights = new List<ICanFight>();
        Cat cat = new Cat();
        Animal animal = new Animal();
        void Start()
        {
            //upcasting
            animal = cat;
            animal.MakeSound();
            animal.Move();
            //downcasting
            cat = animal as Cat;
            cat.MakeSound();
            cat.Move();
            Warrior warrior = new Warrior();
            canFights.Add(cat);
            canFights.Add(warrior);
            foreach (var fighter in canFights)
            {
                fighter.Attack();
            }
            foreach (var fighter in canFights)
            {
                if (fighter is Cat)
                {
                    Debug.Log("it's a cat");
                }
                else if (fighter is Warrior)
                {
                    Debug.Log("He is a warrior");
                }
            }
            
        }

    }
}