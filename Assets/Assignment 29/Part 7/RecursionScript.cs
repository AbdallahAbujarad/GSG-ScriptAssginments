using UnityEngine;
namespace Assignment29
{
    public class RecursionScript : MonoBehaviour
    {
        void Start() 
        {
            Debug.Log($"used method : {nameof(FibonacciRecursive)}");
            Debug.Log(FibonacciIterative(10));
            Debug.Log(FibonacciIterative(30));
            Debug.Log($"used method : {nameof(FibonacciIterative)}");
            Debug.Log(FibonacciIterative(10));
            Debug.Log(FibonacciIterative(30));
        }
        int FibonacciRecursive(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            return FibonacciRecursive(n-1) + FibonacciRecursive(n-2);
        }
        int FibonacciIterative(int n)
        {
            int first = 0;
            int second = 1;
            int after =  0;
        
            for (int i = 2; i <= n; i++)
            {
                after = first + second;
                first = second;
                second = after;
            }
            if (n == 1)
            {
                after = 1;
            }
            return after;
        }
    }
}
