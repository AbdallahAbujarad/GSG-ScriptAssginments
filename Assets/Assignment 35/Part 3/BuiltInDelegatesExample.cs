using System;
using UnityEngine;

namespace Assignment35
{

    public class BuiltInDelegatesExample : MonoBehaviour
    {
        Action<string> logMassage;
        Func<int, int> square;
        public static Predicate<int> isEven;
        private void Start()
        {
            logMassage = (string str) => Debug.Log(str);
            logMassage?.Invoke("Hello from Action delegate!");
            square = x => x * x;
            Debug.Log($"Square = {square?.Invoke(5)}");
            isEven = x => x % 2 == 0;
            Debug.Log($"Is 4 Even? {isEven(4)}");
        }

    }
}