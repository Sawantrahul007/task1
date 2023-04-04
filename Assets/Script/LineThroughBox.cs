using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineThroughBox : MonoBehaviour
{
    public LineRenderer lineRenderer;
    [SerializeField] private GameObject[] cube;
    [SerializeField] public bool isactive;
    [SerializeField] public bool isactive1;
    [SerializeField] public bool isactive3;
    [SerializeField] public bool isactive4;
    [SerializeField] public static bool isplayer;
    public GameObject Player;
    public GameObject fir;
    public GameObject firSec;
    public GameObject fir1;
    public GameObject firSec1;
    public GameObject c1;
    public GameObject c2;
    public GameObject c3;
    public GameObject c4;








    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 4;
        Player = GameObject.Find("Player");
        c1 = GameObject.Find("Target");
        c2 = GameObject.Find("Cube");
        c3 = GameObject.Find("Target(Clone)");
        c4 = GameObject.Find("Cube 1(Clone)");
        cube[3] = Player;





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
            if (c1.transform.position.z < 0)
            {
                float xf = c1.transform.position.x;
                float zf = Player.transform.position.z - 6;
                float x = Player.transform.position.x;
                float z = Player.transform.position.z - 6;
                cube[1].transform.position = new Vector3(xf, 0, zf);
                cube[2].transform.position = new Vector3(x, 0, z);


            }
            else if (c1.transform.position.z > 0)
            {
                float xf = c1.transform.position.x;
                float zf = Player.transform.position.z + 6;
                float x = Player.transform.position.x;
                float z = Player.transform.position.z + 6;
                cube[1].transform.position = new Vector3(xf, 0, zf);
                cube[2].transform.position = new Vector3(x, 0, z);
            }
            
        }
        if (isactive1)
        {
            for (int i = 0; i < cube.Length; i++)
            {
                lineRenderer.SetPosition(i, cube[i].transform.position);
            }
            if (c2.transform.position.z < 0)
            {
                float xf = c2.transform.position.x;
                float zf = Player.transform.position.z - 6;
                float x = Player.transform.position.x;
                float z = Player.transform.position.z - 6;
                cube[1].transform.position = new Vector3(xf, 0, zf);
                cube[2].transform.position = new Vector3(x, 0, z);


            }
            else if (c2.transform.position.z > 0)
            {
                float xf = c2.transform.position.x;
                float zf = Player.transform.position.z + 6;
                float x = Player.transform.position.x;
                float z = Player.transform.position.z + 6;
                cube[1].transform.position = new Vector3(xf, 0, zf);
                cube[2].transform.position = new Vector3(x, 0, z);
            }

        }
        if (isactive3)
        {
            for (int i = 0; i < cube.Length; i++)
            {
                lineRenderer.SetPosition(i, cube[i].transform.position);
            }
            if (c3.transform.position.z < 0)
            {
                float xf = c3.transform.position.x;
                float zf = Player.transform.position.z - 6;
                float x = Player.transform.position.x;
                float z = Player.transform.position.z - 6;
                cube[1].transform.position = new Vector3(xf, 0, zf);
                cube[2].transform.position = new Vector3(x, 0, z);


            }
            else if (c3.transform.position.z > 0)
            {
                float xf = c3.transform.position.x;
                float zf = Player.transform.position.z + 6;
                float x = Player.transform.position.x;
                float z = Player.transform.position.z + 6;
                cube[1].transform.position = new Vector3(xf, 0, zf);
                cube[2].transform.position = new Vector3(x, 0, z);
            }

        }
        if (isactive4)
        {
            for (int i = 0; i < cube.Length; i++)
            {
                lineRenderer.SetPosition(i, cube[i].transform.position);
            }
            if (c4.transform.position.z < 0)
            {
                float xf = c4.transform.position.x;
                float zf = Player.transform.position.z - 6;
                float x = Player.transform.position.x;
                float z = Player.transform.position.z - 6;
                cube[1].transform.position = new Vector3(xf, 0, zf);
                cube[2].transform.position = new Vector3(x, 0, z);


            }
            else if (c4.transform.position.z > 0)
            {
                float xf = c4.transform.position.x;
                float zf = Player.transform.position.z + 6;
                float x = Player.transform.position.x;
                float z = Player.transform.position.z + 6;
                cube[1].transform.position = new Vector3(xf, 0, zf);
                cube[2].transform.position = new Vector3(x, 0, z);
            }

        }



    }
    private void OnMouseDown()
    {
        if (gameObject.CompareTag("playerx"))
        {
            isplayer = true;
        }
        Debug.Log(isplayer);
        if (gameObject.CompareTag("t1") && isplayer)
        {
            cube[0] = c1;
            if (c1.transform.position.z > 0)
            {
                
                float xf = c1.transform.position.x;
                float zf = Player.transform.position.z + 6;
                float x = Player.transform.position.x;
                float z = Player.transform.position.z + 6;
                cube[1] = GameObject.Find("Fir");
                cube[2] = GameObject.Find("Sec");
                cube[1].transform.position = new Vector3(xf, 0, zf);
                cube[2].transform.position = new Vector3(x, 0, z);
                isactive = true;

            }
            else
            {
                float xf = c1.transform.position.x;
                float zf = Player.transform.position.z - 6;
                float x = Player.transform.position.x;
                float z = Player.transform.position.z - 6;
                cube[1] = GameObject.Find("Fir");
                cube[2] = GameObject.Find("Sec");
                cube[1].transform.position = new Vector3(xf, 0, zf);
                cube[2].transform.position = new Vector3(x, 0, z);
                isactive = true;
            }
            isplayer = false;
            
        }
        if (gameObject.CompareTag("t2")&&isplayer)
        {
            cube[0] = c2;
            if (c2.transform.position.z > 0)
            {
                float xf = c2.transform.position.x;
                float zf = Player.transform.position.z + 6;
                float x = Player.transform.position.x;
                float z = Player.transform.position.z + 6;

                cube[1] = GameObject.Find("Fir2");
                cube[2] = GameObject.Find("Sec2");
                cube[1].transform.position = new Vector3(xf, 0, zf);
                cube[2].transform.position = new Vector3(x, 0, z);
                isactive1 = true;

            }
            else
            {
                float xf = c2.transform.position.x;
                float zf = Player.transform.position.z - 6;
                float x = Player.transform.position.x;
                float z = Player.transform.position.z - 6;

                cube[1] = GameObject.Find("Fir2");
                cube[2] = GameObject.Find("Sec2");
                cube[1].transform.position = new Vector3(xf, 0, zf);
                cube[2].transform.position = new Vector3(x, 0, z);
                isactive1 = true;
            }
            isplayer = false;
        }
        if (gameObject.CompareTag("t3") && isplayer)
        {
            cube[0] = c3;
            if (c3.transform.position.z > 0)
            {

                float xf = c3.transform.position.x;
                float zf = Player.transform.position.z + 6;
                float x = Player.transform.position.x;
                float z = Player.transform.position.z + 6;
                cube[1] = GameObject.Find("Fir3");
                cube[2] = GameObject.Find("Sec3");
                cube[1].transform.position = new Vector3(xf, 0, zf);
                cube[2].transform.position = new Vector3(x, 0, z);
                isactive3 = true;

            }
            else
            {
                float xf = c3.transform.position.x;
                float zf = Player.transform.position.z - 6;
                float x = Player.transform.position.x;
                float z = Player.transform.position.z - 6;
                cube[1] = GameObject.Find("Fir3");
                cube[2] = GameObject.Find("Sec3");
                cube[1].transform.position = new Vector3(xf, 0, zf);
                cube[2].transform.position = new Vector3(x, 0, z);
                isactive3 = true;
            }
            isplayer = false;

        }
        if (gameObject.CompareTag("t4") && isplayer)
        {
            cube[0] = c4;
            if (c4.transform.position.z > 0)
            {

                float xf = c4.transform.position.x;
                float zf = Player.transform.position.z + 6;
                float x = Player.transform.position.x;
                float z = Player.transform.position.z + 6;
                cube[1] = GameObject.Find("Fir4");
                cube[2] = GameObject.Find("Sec4");
                cube[1].transform.position = new Vector3(xf, 0, zf);
                cube[2].transform.position = new Vector3(x, 0, z);
                isactive4 = true;

            }
            else
            {
                float xf = c4.transform.position.x;
                float zf = Player.transform.position.z - 6;
                float x = Player.transform.position.x;
                float z = Player.transform.position.z - 6;
                cube[1] = GameObject.Find("Fir4");
                cube[2] = GameObject.Find("Sec4");
                cube[1].transform.position = new Vector3(xf, 0, zf);
                cube[2].transform.position = new Vector3(x, 0, z);
                isactive4 = true;
            }
            isplayer = false;

        }













    }

}
