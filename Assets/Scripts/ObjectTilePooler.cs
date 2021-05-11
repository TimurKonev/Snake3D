using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTilePooler : MonoBehaviour
{
    [SerializeField] private GameObject[] tilePrefab;
    [SerializeField] private int poolStartSize = 10;

    private Queue<GameObject> tilePool = new Queue<GameObject>();
    private void Start()
    {
        for (int i = 0; i < poolStartSize; i++)
        {
            GameObject tile = Instantiate(tilePrefab[Random.Range(0,3)]);
            tilePool.Enqueue(tile);
            tile.SetActive(false);
        }
    }

    public GameObject GetTile()
    {
        if (tilePool.Count > 0)
        {
            GameObject tile = tilePool.Dequeue();
            tile.SetActive(true);
            return tile;
        }
        else
        {
            GameObject tile = Instantiate(tilePrefab[Random.Range(0,2)]);
            return tile;
        }
    }

    public void ReturnTile(GameObject tile)
    {
        tilePool.Enqueue(tile);
        tile.SetActive(false);
    }
}

