using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startDialog : MonoBehaviour
{
    public DialogManager d;
    public string[] l;
    public bool s;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        d.GetComponent<DialogManager>().makeDialog(l, s);
        Object.Destroy(gameObject);
    }
}
