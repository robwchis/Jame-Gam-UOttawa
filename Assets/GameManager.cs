using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public List<GameObject> inventory;
    public bool dragging = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool addItemToInventory(GameObject i)
    {
        if (inventory.Count < 18)
        {
            inventory.Add(i);
            return true;
        }
        return false;
    }
}
