using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public delegate void ColorChangeAction();

    public static event ColorChangeAction OnColorChanged;
    
    public Color checkPointColor;
   

     void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            var snakeMaterial = other.gameObject.GetComponentInChildren<Renderer>();
            snakeMaterial.material.color = checkPointColor;
            if (OnColorChanged != null)
                OnColorChanged();
           
        }
    }
    
    
}
