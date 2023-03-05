using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public static int MAX_NUMBER_OF_CHARS = 324; //Max number of characters used in the Dialog box before text leaves the area

    public TextMeshProUGUI dialogText;
    int x = 200;
    int i = 0;
    public string[] list;
    public GameObject duckPort;
    public GameObject convPartner;
    public GameObject theBox;
    private bool imageIsDuck;



    // Start is called before the first frame update
    void Start()
    {
        hidDialog();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (theBox.activeSelf)
            {
                i++;
                if (i >= list.Length) hidDialog();
                else
                {
                    showDialog();
                }
            }
        }

    }

    void hidDialog()
    {
        duckPort.SetActive(false);
        convPartner.SetActive(false);
        theBox.SetActive(false);
        i = 0;
        dialogText.text = "";
    }

    void showDialog()
    {
        dialogText.text = list[i];
        if (imageIsDuck == true)
        {
            duckPort.SetActive(true);
            convPartner.SetActive(false);
            theBox.SetActive(true);
            imageIsDuck = false;
        }
        else
        {
            duckPort.SetActive(false);
            convPartner.SetActive(true);
            theBox.SetActive(true);
            imageIsDuck = true;
        }
    }

    public void makeDialog(string[] l, bool dFirst)
    {
        list = l;
        imageIsDuck = dFirst;
        i = 0;
        showDialog();
    }
}
