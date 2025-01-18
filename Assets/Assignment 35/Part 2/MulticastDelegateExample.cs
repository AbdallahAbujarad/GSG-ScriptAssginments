using UnityEngine;
namespace Assignment35
{

    delegate void MathOperation(int number);
    public class MulticastDelegateExample : MonoBehaviour
    {
        MathOperation operation;
        private void Start()
        {
            operation += DoubleNumber;
            operation += SquareNumber;
            operation += CubeNumber;
            operation?.Invoke(5);
        }
        void DoubleNumber(int number)
        {
            Debug.Log("Double : " + number * 2);
        }
        void SquareNumber(int number)
        {
            Debug.Log("Square : " + number * number);
        }
        void CubeNumber(int number)
        {
            Debug.Log("Cube : " + number * number * number);
        }
    }
}
