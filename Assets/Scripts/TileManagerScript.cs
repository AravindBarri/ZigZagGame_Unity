using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManagerScript : MonoBehaviour
{
    public GameObject[] tiles;
    public GameObject currentTile;
    private static TileManagerScript instance;

    Stack<GameObject> forwardTilePool;
    Stack<GameObject> leftTilePool;

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

        /*for (int i = 0; i < 10; i++)
        {
            SpawnTile();
        }*/

        forwardTilePool = new Stack<GameObject>();
        leftTilePool = new Stack<GameObject>();

        


    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateTiles(int value) //to create pool of tiles   
    {
        for(int i = 0; i<value; i++)
        {
            forwardTilePool.Push(Instantiate(tiles[0]));
            leftTilePool.Push(Instantiate(tiles[1]));
            forwardTilePool.Peek().SetActive(false);
            leftTilePool.Peek().SetActive(false);
            forwardTilePool.Peek().name = "ForwardTile";
            leftTilePool.Peek().name = "LeftTile";
        }
    }
    public void AddForwardTilePool(GameObject tempObj)
    {
        forwardTilePool.Push(tempObj);
        forwardTilePool.Peek().SetActive(false);
    }
    public void AddLeftTilePool(GameObject tempObj)
    {
        leftTilePool.Push(tempObj);
        leftTilePool.Peek().SetActive(false);
    }

    public void SpawnTile()
    {
        if(forwardTilePool.Count == 0 || leftTilePool.Count == 0)
        {
            CreateTiles(10);
        }

        int index = Random.Range(0, tiles.Length);

        if(index == 0)
        {
            GameObject temp = forwardTilePool.Pop();
            temp.SetActive(true);
            temp.transform.position = currentTile.transform.GetChild(index).position;
            currentTile = temp;
        }
        else if(index == 1)
        {
            GameObject temp = leftTilePool.Pop();
            temp.SetActive(true);
            temp.transform.position = currentTile.transform.GetChild(index).position;
            currentTile = temp;
        }
        //currentTile = (GameObject)Instantiate(tiles[index], currentTile.transform.GetChild(index).position, Quaternion.identity);
    }

}
