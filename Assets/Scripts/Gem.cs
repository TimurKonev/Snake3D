using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public delegate void GemCollectedAction();
    
    
    private void OnTriggerEnter(Collider other)
    {
        Fever.AddGem();
        Destroy(gameObject);
        
    }
}
