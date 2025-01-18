using UnityEngine;

namespace Assignment35
{
    public class TestAbstractClass : MonoBehaviour
    {
        DerivedClassExample derived = new DerivedClassExample();
        void Start()
        {
            derived.PerformAction();
            derived.PrintInfo();
        }
    }

}
