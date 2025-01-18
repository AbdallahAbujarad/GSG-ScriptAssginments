using UnityEngine;

namespace Assignment35
{
    
    public class BoxingUnboxing : MonoBehaviour
    {
        int health = 100;
        object healthBoxed;
        int healthUnboxed;
        private void Start() 
        {
            healthBoxed = health;
            healthUnboxed = (int)healthBoxed;
            Debug.Log("health : "+health);
            Debug.Log("healthBoxed : "+healthBoxed);
            Debug.Log("healthUnboxed : "+healthUnboxed);
        }
    }

}