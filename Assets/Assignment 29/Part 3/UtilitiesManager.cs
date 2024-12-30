using UnityEngine;

namespace Assignment29
{
    public class UtilitiesManager : MonoBehaviour
    {
        void Start()
        {
            Debug.Log("1,2,6,7");
            Debug.Log(Utilities.Add(1,2,6,7));
            string name = "Avdul";
            int num = 5;
            Debug.Log(name + ", " + num);
            Debug.Log(name.RepeatString(5));
        }
    }
}
