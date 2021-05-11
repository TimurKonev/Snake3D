using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var snakeMaterial = other.gameObject.GetComponentInChildren<Renderer>();
        var humanMaterial = GetComponentInChildren<Renderer>();
        if (snakeMaterial.material.color.IsEqualTo(humanMaterial.material.color) || Fever.IsFeverEnabled)
        {
            GameManager.AddHuman();
            Destroy(gameObject);
        }
        else
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}