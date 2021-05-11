using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakePartColorChange : MonoBehaviour
{
    [SerializeField] private GameObject snakeHead;
    private Renderer upperPartRenderer;
    private Renderer snakePartRenderer;
    public Color upperPartColor;

    // Start is called before the first frame update
    void Start()
    {
        upperPartRenderer = snakeHead.GetComponentInChildren<Renderer>();
    }

    private void OnEnable()
    {
        CheckPoint.OnColorChanged += ChangeColor;
    }

    private void OnDisable()
    {
        CheckPoint.OnColorChanged -= ChangeColor;

    }

    private void ChangeColor()
    {
        snakePartRenderer = GetComponentInChildren<Renderer>();
        upperPartColor = upperPartRenderer.material.color;
        snakePartRenderer.material.color = upperPartColor;
    }
}
