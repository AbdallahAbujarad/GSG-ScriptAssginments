using System;
using UnityEngine;

namespace Assignment29
{
    public class BasicsScripts : MonoBehaviour
    {
        private void Start() {
            var integer = 9; 
            var str = "String";
            var boolean = "true";
            Debug.Log(integer % 2 == 0?integer + " is even":integer + " is odd");
            DateTime current = DateTime.Now;
            Debug.Log(DateTime.Now.ToString("yyyy-MM-dd"));
            Debug.Log(DateTime.Now.ToString("HH:mm:ss"));
            Debug.Log(DateTime.Now.DayOfWeek.ToString());

        }
    }
}

