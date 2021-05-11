using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static event Action<int> OnHumansChanged;
    
    private static int humans;

    public void EndGame()
    {
        Invoke("Restart", 0.5f);
    }

    private void Restart()
    {
        humans = 0;
        Fever.RemoveGem();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Level Restarted");
    }

    public static void AddHuman()
    {
        humans++;
        if (OnHumansChanged != null)
            OnHumansChanged(humans);
    }
}
