using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjectsFalse : MonoBehaviour
{
    public GameObject ParticalSystem;
    // Start is called before the first frame update
    void Start()
    {
        ParticalSystem.SetActive(false);
    }

    private void OnEnable()
    {
        ActionsManager.TriggerEntered += appear;
        ActionsManager.TriggerExited += disapear;
    }

    private void OnDisable()
    {
        ActionsManager.TriggerEntered -= appear;
        ActionsManager.TriggerExited -= disapear;
    }

    void appear()
    {
        ParticalSystem.SetActive(true);
    }

    void disapear()
    {
        ParticalSystem.SetActive(false);
    }
}
