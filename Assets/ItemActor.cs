using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemActor : MonoBehaviour
{
    public int pos = 0;
    public string id = "";
    public GameObject gm;

    public Camera mCamera;
    bool dragged = false;
    GameManager gMan;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(pos * 1.2f - 8.2f, 4.5f);
    }

    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameManager gMan = gm.GetComponent<GameManager>();


        if (dragged)
        {
            Vector3 mousePos = mCamera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePos.x,mousePos.y,0);
        }
        if (Input.GetMouseButtonDown(0) && !gMan.dragging)
        {
            Vector3 mPos = mCamera.ScreenToWorldPoint(Input.mousePosition);

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
                try
                {
                    DragPuzzleChain dp2 = g.GetComponent<DragPuzzleChain>();
                    if (id == dp2.requiredId)
                    {
                        if (Mathf.Abs(transform.position.x - g.transform.position.x) < 1 &&
                            Mathf.Abs(transform.position.y - g.transform.position.y) < 1)
                        {
                            dp2.Unlock();
                            if (dp2.destroyKeyOnSolve)
                            {
                                destroySelf();
                            }
                        }
                    }

                }
                catch { }
            }
            transform.position = new Vector3(pos*1.2f - 8.2f, 4.5f);
        }

    }

    public void destroySelf()
    {
    }
}
