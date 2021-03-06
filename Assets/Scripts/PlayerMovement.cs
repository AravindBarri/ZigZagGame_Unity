using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Vector3 Direction;

    public float playerspeed;

    TileManager tlmobject;

    public ParticleSystem particleprefab;

    ScoreManagerScript ScObject;

    public GameObject GameoverCanva;

    // Start is called before the first frame update
    void Start()
    {
        tlmobject = FindObjectOfType<TileManager>();
        ScObject = FindObjectOfType<ScoreManagerScript>();
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

        if(transform.position.y < -10)
        {
            this.GetComponent<Rigidbody>().isKinematic = true;
            playerspeed = 0f;
            GameoverCanva.SetActive(true);
        }
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
            Instantiate(particleprefab, transform.position, Quaternion.identity);
            ScObject.scorebool = true;
        }
    }
}
