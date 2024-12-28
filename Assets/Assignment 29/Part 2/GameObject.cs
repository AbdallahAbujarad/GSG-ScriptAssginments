using UnityEngine;

namespace Assignment29
{
    public class GameObject : MonoBehaviour
    {
        CustomObject obj1 = new CustomObject(1,"Ahmed Mo7sen");
        CustomObject obj2 = new CustomObject(2,"Aseel");
        private void Start() {
            print(obj1.ToString());
            print($"Are they equal? {obj1 == obj2}");
            print($"Are they unequal? {obj1 != obj2}");
        }


    }
}
