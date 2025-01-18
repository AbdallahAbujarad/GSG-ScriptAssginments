using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {

        List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };
        List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
        List<int> evenNumbers = new List<int>();
        private void Start()
        {
            numbers.Sort((x, y) => y.CompareTo(x));
            Debug.Log("The Ordered List");
            string sortedNumbersString = string.Join(", ", numbers);

            Debug.Log(sortedNumbersString);
            evenNumbers = numbers2.FindAll(x => x % 2 == 0);
            Debug.Log("The Even List");
            string sortedNumbers2String = string.Join(", ", evenNumbers);
            Debug.Log(sortedNumbers2String);
        }

    }
}

