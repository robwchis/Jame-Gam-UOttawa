using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemActor : MonoBehaviour
{
    public int pos = 0;
    public string id = "";
    public GameObject gm;

    Camera mCamera;
    bool dragged = false;
    GameManager gMan;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(pos * 1.2f - 8.2f, 4.5f);
    }

    void Awake()
    {
        mCamera = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
        GameManager gMan = gm.GetComponent<GameManager>();


        if (dragged)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x,transform.position.y,0);
        }
        if (Input.GetMouseButtonDown(0) && !gMan.dragging)
        {
            Vector3 mPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Mathf.Abs(mPos.x - gameObject.transform.position.x) < 1 &&
                Mathf.Abs(mPos.y - gameObject.transform.position.y) < 1)
            {
                dragged = true;
                gMan.dragging = true;
            }

        }

        if (Input.GetMouseButtonUp(0))
        {
            dragged = false;
            gMan.dragging = false;
            foreach (GameObject g in Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[])
            {
                try
                { 
                    DragPuzzle dp = g.GetComponent<DragPuzzle>(); 
                    if (id == dp.requiredId)
                    {
                        if (Mathf.Abs(transform.position.x - g.transform.position.x) < 1 &&
                            Mathf.Abs(transform.position.y - g.transform.position.y) < 1)
                        {
                            dp.Unlock();
                            if (dp.destroyKeyOnSolve) {
                                destroySelf();
                            }
                        }
                    }
                
                } catch { }
            }
            transform.position = new Vector3(pos*1.2f - 8.2f, 4.5f);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("AAAAAA");
        try
        {
            DragPuzzle objIn = collision.gameObject.GetComponent<DragPuzzle>();
            Debug.Log("AAAAAA");
        }
        catch
        { return; }
    }

    public void destroySelf()
    {
        GameManager gMan = gm.GetComponent<GameManager>();

        gMan.inventory.Remove(gameObject);
        foreach (GameObject item in gMan.inventory)
        {
            if (item.GetComponent<ItemActor>().pos > pos) item.GetComponent<ItemActor>().pos -= 1;
        }
        if (this.dragged) gMan.dragging = false;
    }
}
