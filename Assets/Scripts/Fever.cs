using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Fever : MonoBehaviour
{
    public static event Action<int> OnGemCollected;
    public static event Action<int> OnGemRemoved; 

    
    [SerializeField] private GameObject _gem;
    [SerializeField] private float _gemCountInterval = 120f;
    
    public static bool IsInputEnabled = true;
    public static bool IsFeverEnabled;
    public static float _feverTimer = 5f;
    
    public static int  _gemCount { get; private set; }
   
    public static void AddGem()
    {
        _gemCount++;
        if (OnGemCollected != null)
            OnGemCollected(_gemCount);
    }
    public static void RemoveGem()
    {
        _gemCount = 0;
        if (OnGemRemoved != null)
            OnGemRemoved(_gemCount);
    }

    void FixedUpdate()
    {
        if (_gemCount > 0)
        {
            _gemCountInterval -= Time.deltaTime;
            if (_gemCountInterval > 0 && _gemCount >= 3)
            {
                FeverMode();
                RemoveGem();
            }
            else if(_gemCountInterval <= 0 && _gemCount < 3)
            {
                RemoveGem();
                _gemCountInterval = 0;
            }
            
        }

        if (IsFeverEnabled)
        {
            _feverTimer -= Time.deltaTime;
            _gemCount = 0;
        }

        if (_feverTimer <= 0)
        {
            IsInputEnabled = true;
            IsFeverEnabled = false;
            _gemCountInterval = 120f;

            _feverTimer = 5f;
            RemoveGem();
        }
    }

    private void FeverMode()
    {
        Debug.Log("FeverMode is On");
        IsInputEnabled = false;
        IsFeverEnabled = true;
    }
}
