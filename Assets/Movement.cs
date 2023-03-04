using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void FixedUpdate()
    {
        int w = Convert.ToInt32(Input.GetKey(KeyCode.W));
        int a = Convert.ToInt32(Input.GetKey(KeyCode.A));
        int s = Convert.ToInt32(Input.GetKey(KeyCode.S));
        int d = Convert.ToInt32(Input.GetKey(KeyCode.D));

        float vert = w - s;
        float hori = d - a;

        transform.Translate(hori * Time.deltaTime * moveSpeed, vert * Time.deltaTime * moveSpeed, 0);
    }
    // Update is called once per frame
    void Update()
    {



    }


}
