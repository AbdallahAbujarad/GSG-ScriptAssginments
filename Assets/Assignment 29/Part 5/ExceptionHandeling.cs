using System;
using UnityEngine;
namespace Assignment29
{
    public class ExceptionHandeling : MonoBehaviour
    {
        int playerScore = 100;
        int diviser = 0;
        void Start() 
        {
            try
            {
                Debug.Log("Attempting to calculate score multiplier...");
                int totalScore = playerScore/diviser;
            }
            catch(DivideByZeroException)
            {
                Debug.Log("Error: Division by zero occurred while calculating score multiplier.");
            }
            finally
            {
                Debug.Log("Score calculation complete. Cleaning upresources.");
            }
        }

    }

}
