using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIFeverText : MonoBehaviour
{
    private TextMeshProUGUI tmProText;
    void Start()
    {
        tmProText = GetComponent<TextMeshProUGUI>();
        tmProText.enabled = false;
    }

   
    void Update()
    {
        if (Fever.IsFeverEnabled)
            tmProText.enabled = true;
        else
        {
            tmProText.enabled = false;
        }
    }
}
