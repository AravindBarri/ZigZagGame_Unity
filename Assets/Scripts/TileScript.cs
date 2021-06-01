using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    Rigidbody tempRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        tempRigidbody = GetComponentInParent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerExit(Collider other)
    {
        
        if (other.tag == "Player")
        {
            TileManagerScript.Instance.SpawnTile();
            StartCoroutine("FallDown");
            //Debug.Log("Spawn TILE");
        }
    }
    IEnumerator FallDown()
    {
        yield return new WaitForSeconds(3);
        tempRigidbody.isKinematic = false;
        yield return new WaitForSeconds(1);
        tempRigidbody.isKinematic = true;
        if (tempRigidbody.gameObject.name == "ForwardTile")
        {

            TileManagerScript.Instance.AddForwardTilePool(tempRigidbody.gameObject);
            //Debug.Log("Added to forward pool");
        }
        else if (tempRigidbody.gameObject.name == "LeftTile")
        {

            TileManagerScript.Instance.AddLeftTilePool(tempRigidbody.gameObject);
            //Debug.Log("Added to left pool");
        }
    }
}
