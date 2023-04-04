using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject c1;
    public GameObject c2;
    public float[] ran;
   
    public GameObject c3;
    public GameObject c4;
   
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < ran.Length; i++)
        {
            ran[i] = Random.Range(-3, 3);
        }
       
        c1.transform.position = new Vector3(ran[0], transform.position.y, ran[1]);
        c2.transform.position = new Vector3(ran[2], transform.position.y, ran[3]);
        Instantiate(c3, new Vector3(ran[4], transform.position.y, ran[5]), c3.transform.rotation);
        Instantiate(c4, new Vector3(ran[6], transform.position.y, ran[7]), c3.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
