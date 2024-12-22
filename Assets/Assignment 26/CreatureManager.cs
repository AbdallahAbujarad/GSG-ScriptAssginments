using System.Collections.Generic;
using Assignment26;
using UnityEngine;

namespace Assignment26
{
    
    public class CreatureManager : MonoBehaviour
    {
        void Start()
        {
            List<Creature> creatures = new List<Creature>();
            Kangaroo kangaroo1 = new Kangaroo();
            Duck duck1 = new Duck();
            creatures.Add(kangaroo1);
            creatures.Add(duck1);
            List<IRunable> runables = new List<IRunable>();
            List<IJumpable> jumpables = new List<IJumpable>();
            List<ISwimable> swimables = new List<ISwimable>();
            
            runables.Add(kangaroo1);
            jumpables.Add(kangaroo1);

            runables.Add(duck1);
            swimables.Add(duck1);

            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }
            foreach (IRunable runable in runables)
            {
                runable.Run();
            }
            foreach (IJumpable jumpable in jumpables)
            {
                jumpable.Jump();
            }
            foreach (ISwimable swimable in swimables)
            {
                swimable.Swim();
            }


        }

    }
}
