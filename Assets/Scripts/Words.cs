using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Words : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    private void OnEnable()
    {
        ActionsManager.TriggerEntered += wordsPart2;
        ActionsManager.TriggerExited += words;
    }

    private void OnDisable()
    {
        ActionsManager.TriggerEntered -= wordsPart2;
        ActionsManager.TriggerExited -= words;
    }

    void words()
    {
        textMeshPro.text = "Word";
    }

    void wordsPart2()
    {
        textMeshPro.text = "Other Word";
    }
}
