using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class TypeManagementScript : MonoBehaviour
    {
        List<ICanFight> canFights = new List<ICanFight>();
        void Start()
        {
            Cat cat = new Cat();
            Animal animal = cat;
            animal.MakeSound();
            animal.Move();//there is no way that it log animal moves
            Cat downcastedCat = animal as Cat;
            downcastedCat.MakeSound();
            downcastedCat.Move();
            Warrior warrior = new Warrior();
            canFights.Add(cat);
            canFights.Add(warrior);
            foreach (var fighter in canFights)
            {
                fighter.Attack();
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