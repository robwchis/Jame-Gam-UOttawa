using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragPuzzle : MonoBehaviour
{

    public string requiredId = "";
    public bool destroySelfOnSolve = false;
    public bool destroyKeyOnSolve = false;
    public GameObject pickupToEnable;

    private ItemActor objIn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Unlock()
    {
        if (destroySelfOnSolve) Destroy(this.gameObject);
        try { pickupToEnable.SetActive(true); } catch { }
    }
}
