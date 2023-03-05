using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEditor.PlayerSettings;

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
                gm.GetComponent<GameManager>().inventory.Add(newy);
                newy.GetComponent<ItemActor>().pos = gm.GetComponent<GameManager>().inventory.Count;
                newy.GetComponent<ItemActor>().id = this.id;
                newy.transform.position = new Vector3(newy.GetComponent<ItemActor>().pos * 1.2f - 8.2f, 4.5f);
                Destroy(this.gameObject);
            }

        }
    }
}
