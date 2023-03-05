using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5;

    public Sprite d0, d1, d2, d3, d4, d5, d6, d7;
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

        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();

        Sprite spr = sr.sprite;

        if (vert == 1)
        {
            switch (hori)
            {
                case 1:
                    spr = d1;
                    break;
                case 0: spr = d0;
                    break;
                case -1:
                    spr = d7;
                    break;
            }
        } else if (vert == 0)
        {
            switch (hori)
            {
                case 1:
                    spr = d2;
                    break;
                case -1:
                    spr = d6;
                    break;
            }
        } else if (vert == -1)
        {
            switch (hori)
            {
                case 1:
                    spr = d3;
                    break;
                case 0:
                    spr = d4;
                    break;
                case -1:
                    spr = d5;
                    break;
            }
        }

        sr.sprite = spr;



    }
    // Update is called once per frame
    void Update()
    {
    }


}
