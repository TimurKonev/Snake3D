using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private SkinnedMeshRenderer[] humanRenderer;

    [SerializeField] private Color[] newColor;
    public static Color humanColor { get; private set; }

    void Start()
    {
        humanRenderer = GetComponentsInChildren<SkinnedMeshRenderer>();
        humanColor = newColor[Random.Range(0,6)];
        for (int i = 0; i < humanRenderer.Length; i++)
        {
            humanRenderer[i].material.color = humanColor;
        }
    }
}
