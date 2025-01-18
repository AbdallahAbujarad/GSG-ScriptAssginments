using UnityEngine;
using UnityEngine.Events;

namespace Assignment35
{
    public class UnityEventExample : MonoBehaviour
    {
        UnityEvent onEventTriggered;
        private void Start()
        {
            onEventTriggered = new UnityEvent();
            onEventTriggered.AddListener(OnEventResponse);
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                onEventTriggered?.Invoke();
            }
        }
        void OnEventResponse()
        {
            Debug.Log("The event has been triggered!");
        }
    }
}
