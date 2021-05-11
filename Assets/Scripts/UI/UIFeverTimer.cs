using TMPro;
using UnityEngine;

public class UIFeverTimer : MonoBehaviour
{
    private TextMeshProUGUI tmProText;

    private void Start()
    {
        tmProText = GetComponent<TextMeshProUGUI>();
        tmProText.enabled = false;
    }

    void Update()
    {
        if (Fever.IsFeverEnabled)
        {
            tmProText.enabled = true;
            float seconds = Mathf.FloorToInt(Fever._feverTimer % 60);

            tmProText.text = Fever._feverTimer.ToString();
            tmProText.text = string.Format("{0}", seconds);
        }
        else
        {
            tmProText.enabled = false;
        }
    }
}
