using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PickupActor : MonoBehaviour
{

    public string id;
    public GameObject magnifyingGlass;
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Mathf.Abs(mPos.x - gameObject.transform.position.x) < 1 &&
                Mathf.Abs(mPos.y - gameObject.transform.position.y) < 1)
            { 
                GameObject newy = GameObject.Instantiate(magnifyingGlass);
                newy.GetComponent<ItemActor>().pos = gm.GetComponent<GameManager>().inventory.Count;
                newy.GetComponent<ItemActor>().id = this.id;
            }

        }
    }
}
