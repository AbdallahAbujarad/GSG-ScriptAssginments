using UnityEngine;

namespace Assignment35
{

    public class MethodChainingExample : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log($"Origins :: Position : {transform.position}, Rotatiom : {Quaternion.identity}, Scale : {transform.localScale}");

            SetPosition(new Vector3(0, 1, 0))
            .SetRotation(new Vector3(45, 0, 0))
            .SetScale(new Vector3(2, 2, 2));

            Debug.Log($"After Changing :: Position : {transform.position}, Rotation : {transform.rotation.eulerAngles}, Scale : {transform.localScale}");
        }
        public MethodChainingExample SetPosition(Vector3 vector3)
        {
            transform.position = vector3;
            return this;
        }
        public MethodChainingExample SetRotation(Vector3 vector3)
        {
            transform.rotation = Quaternion.Euler(vector3);
            return this;
        }
        public MethodChainingExample SetScale(Vector3 vector3)
        {
            transform.localScale = vector3;
            return this;
        }
    }
}
