using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalSystem : MonoBehaviour
{
    public GameObject partical;
    private void Move()
    {

        partical.transform.position = transform.position + new Vector3(0, 2, 0);
    }

    void Return()
    {
        partical.transform.position = transform.position - new Vector3(0, 2, 0);
    }

    private void OnEnable()
    {
        ActionsManager.TriggerEntered += Move;
        ActionsManager.TriggerExited += Return;
    }

    private void OnDisable()
    {
        ActionsManager.TriggerEntered -= Move;
        ActionsManager.TriggerExited -= Return;
    }
}
