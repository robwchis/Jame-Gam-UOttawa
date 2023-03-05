using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragPuzzleChain : MonoBehaviour
{

    public bool startOff = false;
    public string requiredId = "";
    public bool destroySelfOnSolve = false;
    public bool destroyKeyOnSolve = false;
    public GameObject dragToEnable;
    public bool giveObjectOnSolve = false;
    public string giveId = "";
    public GameObject magGlass = null;
    public GameObject gm = null;
    public string[] textOnSolve;
    public GameObject dialog = null;
    public Sprite sToBe = null;

    private ItemActor objIn;

    // Start is called before the first frame update
    void Start()
    {
        if (startOff) { gameObject.SetActive(false); }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Unlock()
    {
        if (destroySelfOnSolve) Destroy(this.gameObject);
        try { dragToEnable.SetActive(true); } catch { }
        if (giveObjectOnSolve)
        {
            GameObject newy = GameObject.Instantiate(magGlass);
            gm.GetComponent<GameManager>().inventory.Add(newy);
            newy.GetComponent<ItemActor>().pos = gm.GetComponent<GameManager>().inventory.Count;
            newy.GetComponent<ItemActor>().id = giveId;
            newy.GetComponent<SpriteRenderer>().sprite = sToBe;
            newy.transform.position = new Vector3(newy.GetComponent<ItemActor>().pos * 1.2f - 8.2f, 4.5f);
        }
        if (textOnSolve.Length > 0)
        {
            dialog.gameObject.GetComponent<DialogManager>().makeDialog(textOnSolve,true);
        }

    }
}
