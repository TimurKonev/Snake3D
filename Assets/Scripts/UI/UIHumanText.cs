using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIHumanText : MonoBehaviour
{
    private TextMeshProUGUI tmproText;

    private void Awake()
    {
        tmproText = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        GameManager.OnHumansChanged += HandleOnHumansChanged;
    }

    private void HandleOnHumansChanged(int humans)
    {
        tmproText.text = humans.ToString();
    }
}
