using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line2 : MonoBehaviour
{
    public LineRenderer lineRenderer;
    [SerializeField] private GameObject[] cube;
    [SerializeField] bool isactive;
    public GameObject Player;
    public float diff;
    public GameObject fir1;
    public GameObject firSec1;
    public GameObject c2;
    public static int count;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 4;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isactive)
        {
            for (int i = 0; i < cube.Length; i++)
            {
                lineRenderer.SetPosition(i, cube[i].transform.position);
            }
            count = 0;

        }



    }
    private void OnMouseDown()
    {
        count++;
        if (count == 2)
        {
            if (c2.transform.position.z > 0)
            {
                float xf = c2.transform.position.x;
                float zf = Player.transform.position.z + 6;
                float x = Player.transform.position.x;
                float z = Player.transform.position.z + 6;
                Instantiate(fir1, new Vector3(xf, 0, zf), fir1.transform.rotation);
                Instantiate(firSec1, new Vector3(x, 0, z), firSec1.transform.rotation);
                cube[1] = GameObject.Find("Fir2(Clone)");
                cube[2] = GameObject.Find("Sec2(Clone)");
                isactive = true;

            }
            else
            {
                float xf = c2.transform.position.x;
                float zf = Player.transform.position.z - 6;
                float x = Player.transform.position.x;
                float z = Player.transform.position.z - 6;
                Instantiate(fir1, new Vector3(xf, 0, zf), fir1.transform.rotation);
                Instantiate(firSec1, new Vector3(x, 0, z), firSec1.transform.rotation);
                cube[1] = GameObject.Find("Fir2(Clone)");
                cube[2] = GameObject.Find("Sec2(Clone)");
                isactive = true;
            }

        }
        

    }
}
