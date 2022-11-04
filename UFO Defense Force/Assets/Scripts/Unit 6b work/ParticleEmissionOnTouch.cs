using UnityEngine;
using UnityEngine.Events;

public class ParticleEmissionOnTouch : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Power"))
        {
            triggerEnterEvent.Invoke();
        }
    }
}
