using UnityEngine;

namespace Assignment29
{
    public class UnitySpecificScript : MonoBehaviour
    {
        public GameObject joker;
        public GameObject target;
        void OnEnable() 
        {
            print("GameObject Enabled");
        }
        void OnDisable() 
        {
            print("GameObject Disabled");
        }
        void Start()
        {
            print("Game Started!");
            GameObject targetObject = GameObject.Find("TargetObject");
            CheckObject(targetObject,"name");
            GameObject jokerObject = GameObject.FindGameObjectWithTag("Joker");
            CheckObject(jokerObject,"tag");
            Light light = GameObject.FindFirstObjectByType<Light>();
            CheckObject(light.gameObject,"type");
        }
        void Update() 
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (target != null)
                {
                    target.SetActive(false);
                }
                print("TargetObject Deactivated");
                
            }    
        }
        void CheckObject(GameObject gameObject , string str)
        {
            if (gameObject == null)
            {
                print("No " + nameof(gameObject) +" Object found");
            }
            else
            {
                print("Found object by " + str +": "+gameObject.name);
            }
        }
    } 
}
