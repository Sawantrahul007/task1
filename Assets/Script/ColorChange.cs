using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Renderer rendererr;
    public GameObject cube;
    public Color[] newcolor;
    
    // Start is called before the first frame update
    void Start()
    {
        rendererr = GetComponent<Renderer>();
        rendererr.material.color = newcolor[0];
        rendererr.material.color = newcolor[1];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
