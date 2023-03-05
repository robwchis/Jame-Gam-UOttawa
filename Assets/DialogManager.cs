using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public static int MAX_NUMBER_OF_CHARS = 324; //Max number of characters used in the Dialog box before text leaves the area

    public TextMeshProUGUI dialogText;
    int x = 200;


    // Start is called before the first frame update
    void Start()
    {
        //dialogText.text = "";
        //transform.position = new Vector3(100000, 100000, 100000);
        dialogText.text = "XA";
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Return))
        {
            if ((dialogText.text == "") && (x >= 200))
            {
                showDialog();
                x = 0;
            }
            else if ((dialogText.text != "") && (x >= 200))
            {
                hidDialog();
                x = 0;
            }
        }

        x = x + 1;
    }

    void hidDialog()
    {
        transform.position = new Vector3(100000, 100000, 100000);

        dialogText.text = "";
    }

    void showDialog()
    {
        transform.position = new Vector3(0.3692896f, -1.339681f, 0.02488603f);
        dialogText.text = "Good";
    }
}