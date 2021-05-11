using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Transform returnPoint;
    [SerializeField] private float tileLenght = 120f;
    private TilePooler tilePool;
    private Transform playerTransform;
    private bool canSpawn = true;

    private void Start()
    {
        tilePool = FindObjectOfType<TilePooler>(); 
        playerTransform = FindObjectOfType<SnakeMovement>().snakeHead.transform;
    }

    private void Update()
    {
        if(playerTransform.position.z  > spawnPoint.position.z && canSpawn is true)
        {
            GameObject newTile = tilePool.GetTile();
            newTile.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + tileLenght) ;
            canSpawn = false;
        }

        if (playerTransform.position.z > returnPoint.position.z)
        {
            if (tilePool != null)
                tilePool.ReturnTile(this.gameObject);
            canSpawn = true;
        }
        
        
    }
}
