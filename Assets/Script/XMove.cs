using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XMove : MonoBehaviour
{
    public float sidelimit=4.0f;
    public float uplimit = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > sidelimit)
        {
            transform.position = new Vector3(sidelimit, transform.position.y, transform.position.z);

        }
        if (transform.position.x < -sidelimit)
        {
            transform.position = new Vector3(-sidelimit, transform.position.y, transform.position.z);

        }
        if (transform.position.z > uplimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, uplimit);

        }
        if (transform.position.z < -uplimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -uplimit);

        }

    }
}
