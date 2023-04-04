using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;
    public static bool isobt;
    public static bool isobc;
    public static bool isobt1;
    public static bool isobc1;
    public float horizontalaxis;
    public float VerticalAxis;
    public GameObject firstpoint;
    
    public GameObject firstpoint1;
    
    public GameObject firstpoint2;
    
    public GameObject firstpoint3;
    
    public float sidelimit=4.0f;
    public float uplimit=4.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        c1 = GameObject.Find("Target");
        c2 = GameObject.Find("Cube");
        c3 = GameObject.Find("Target(Clone)");
        c4 = GameObject.Find("Cube 1(Clone)");
        firstpoint = GameObject.Find("Fir");
        firstpoint1 = GameObject.Find("Fir2");
        firstpoint2 = GameObject.Find("Fir3");
        firstpoint3 = GameObject.Find("Fir4");
        Debug.Log(true);
       
        

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(true);
        VerticalAxis = Input.GetAxis("Vertical");
        horizontalaxis = Input.GetAxis("Horizontal");
        if (isobt)
        {
            c1.transform.Translate(Vector3.right * horizontalaxis*5f*Time.deltaTime);
            c1.transform.Translate(Vector3.forward * VerticalAxis* 5f * Time.deltaTime);
        }
        else if (isobc)
        {
            c2.transform.Translate(Vector3.right * horizontalaxis * 5f*Time.deltaTime);
            c2.transform.Translate(Vector3.forward * VerticalAxis * 5f * Time.deltaTime);
        }
        else if (isobt1)
        {
            c3.transform.Translate(Vector3.right * horizontalaxis * 5f * Time.deltaTime);
            c3.transform.Translate(Vector3.forward * VerticalAxis * 5f * Time.deltaTime);
        }
        else if (isobc1)
        {
            c4.transform.Translate(Vector3.right * horizontalaxis * 5f * Time.deltaTime);
            c4.transform.Translate(Vector3.forward * VerticalAxis * 5f * Time.deltaTime);
        }
        if (transform.position.x > sidelimit)
        {
            transform.position = new Vector3(sidelimit,transform.position.y,transform.position.z);

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

        float xc1=c1.transform.position.x;
        firstpoint.transform.position = new Vector3(xc1, firstpoint.transform.position.y, firstpoint.transform.position.z);
        float xc2 = c2.transform.position.x;
        firstpoint1.transform.position = new Vector3(xc2, firstpoint1.transform.position.y, firstpoint1.transform.position.z);
        float xc3 = c3.transform.position.x;
        firstpoint2.transform.position = new Vector3(xc3, firstpoint2.transform.position.y, firstpoint2.transform.position.z);
        float xc4 = c4.transform.position.x;
        firstpoint3.transform.position = new Vector3(xc4, firstpoint3.transform.position.y, firstpoint3.transform.position.z);



    }
    private void OnMouseDown()
    {
        if (gameObject.CompareTag("t1"))
        {
            isobt = true;
            isobc = false;
            isobt1 = false;
            isobc1 = false;
        }
        else if (gameObject.CompareTag("t2"))
        {
            isobc = true;
            isobt = false;
            isobt1 = false;
            isobc1 = false;
        }
        else if (gameObject.CompareTag("t3"))
        {
            isobt1 = true;
            isobc = false;
            isobt = false;
            isobc1 = false;

        }
        else if (gameObject.CompareTag("t4"))
        {
            isobc1 = true;
            isobt1 = false;
            isobc = false;
            isobt = false;

        }
    }
}
