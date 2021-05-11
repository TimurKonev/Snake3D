using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if( Fever.IsFeverEnabled)
            Destroy(gameObject);
        else
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
