using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ActionsManager.TriggerEntered.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        ActionsManager.TriggerExited.Invoke();
    }
}
