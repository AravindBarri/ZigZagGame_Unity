using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Vector3 Direction;

    public float playerspeed;

    // Start is called before the first frame update
    void Start()
    {
        
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
}
