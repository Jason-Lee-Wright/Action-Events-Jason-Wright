using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public Light sunlight;
    public int Num, num2;

    private void OnEnable()
    {
        ActionsManager.TriggerEntered += Brightness;
        ActionsManager.TriggerExited += Darkness;
    }

    private void OnDisable()
    {
        ActionsManager.TriggerEntered -= Brightness;
        ActionsManager.TriggerExited -= Darkness;
    }

    void Brightness()
    {
        sunlight.intensity = Num;
    }

    void Darkness()
    {
        sunlight.intensity = num2;
    }
}
