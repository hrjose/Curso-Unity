using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laberinto : MonoBehaviour
{
    private Transform tr;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float z = Input.GetAxis("Horizontal")*velocidad*Time.deltaTime;

        float x = Input.GetAxis("Vertical")*velocidad*-1*Time.deltaTime;

        tr.Rotate(new Vector3(x,0,z));


        
    }
}
