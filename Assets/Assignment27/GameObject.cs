using System;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment27
{
    public class GameObject : MonoBehaviour
    {
        void Start()
        {
            int a = 5;
            int b = 8;
            int c;
            Debug.Log("a = "+a);
            Debug.Log("b = "+b);
            Debug.Log("c hasn't intialized yet");

            ByValueAdd10(a);
            Debug.Log("a after using ByValueAdd10 = " + a);
            
            ByRefAdd10(ref b);
            Debug.Log("b after using ByRefAdd10 = " + b);

            ByOutIntializeValue(out c);
            Debug.Log("c after using ByIntializeValue = " + c);

        }
        void ByValueAdd10(int num)
        {
            num+=10;
        }
        void ByRefAdd10(ref int num)
        {
            num+=10;
        }
        void ByOutIntializeValue(out int num)
        {
            num = 7;
        }
    }
}
