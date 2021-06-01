using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Vector3 Direction;

    public float playerspeed;

    TileManager tlmobject;

    // Start is called before the first frame update
    void Start()
    {
        tlmobject = FindObjectOfType<TileManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(Direction == Vector3.forward)
            {
                Direction = Vector3.left;
            }
            else
            {
                Direction = Vector3.forward ;
            }
        }
        transform.Translate(Direction * playerspeed * Time.deltaTime);
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "FirstTile")
        {
            tlmobject.playertouch = true;
        }
    }*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            other.gameObject.SetActive(false);
        }
    }
}
