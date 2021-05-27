using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManagerScript : MonoBehaviour
{
    public GameObject[] tiles;
    public GameObject currentTile;
    private static TileManagerScript instance;

    public static TileManagerScript Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<TileManagerScript>();
            }
            return instance;
        }

    }


    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 10; i++)
        {
            SpawnTile();
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnTile()
    {
        int index = Random.Range(0, tiles.Length);
        currentTile = (GameObject)Instantiate(tiles[index], currentTile.transform.GetChild(index).position, Quaternion.identity);
    }

}
