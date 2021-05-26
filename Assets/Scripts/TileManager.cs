using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tiles;
    public GameObject currenttile;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            TileSpawn();
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
    void TileSpawn()
    {
        int index = Random.Range(0, tiles.Length);
        currenttile = (GameObject)Instantiate(tiles[index], currenttile.transform.GetChild(index).position, Quaternion.identity);
    }
}
