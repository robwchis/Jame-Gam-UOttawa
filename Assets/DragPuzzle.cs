using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragPuzzle : MonoBehaviour
{

    public string requiredId = "";
    public bool destroySelfOnSolve = false;
    public bool destroyKeyOnSolve = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

        ItemActor i;
        try
        {
            i = collision.gameObject.GetComponent<ItemActor>();
            Debug.Log("AAAAAA");
        }
        catch
        { return; }
        if (i.id == requiredId)
        {
            if (destroySelfOnSolve) Destroy(this.gameObject);
            if (destroySelfOnSolve) Destroy(collision.gameObject);
        }
    }
}
