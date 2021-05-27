using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tiles;
    public GameObject currenttile;

    public bool playertouch = false;
    // Start is called before the first frame update
    void Start()
    {
            //TileSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(playertouch == true)
        {
            TileSpawn();
            playertouch = false;
        }
    }
    void TileSpawn()
    {
        for (int i = 0; i < 1; i++)
        {
            int index = Random.Range(0, tiles.Length);
            currenttile = (GameObject)Instantiate(tiles[index], currenttile.transform.GetChild(index).position, Quaternion.identity);
        }
        
    }
}
