using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIGemText : MonoBehaviour
{
    private TextMeshProUGUI tmproText;

    private void Awake()
    {
        tmproText = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        Fever.OnGemCollected += HandleOnGemsChanged;
        Fever.OnGemRemoved += HandleOnGemsChanged;
    }

    private void HandleOnGemsChanged(int _gemCount)
    {
        tmproText.text = _gemCount.ToString();
    }
}
