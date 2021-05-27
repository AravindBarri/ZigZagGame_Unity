using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDestroyScript : MonoBehaviour
{
    Transform tileDestroyPoint;
    // Start is called before the first frame update
    void Start()
    {
        tileDestroyPoint = GameObject.Find("ObjectDestroyPoint").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z < tileDestroyPoint.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
