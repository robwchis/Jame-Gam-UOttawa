using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomManager : MonoBehaviour
{
    public GameObject dImage;
    public GameObject pharma;
    public GameObject coffee;
    public GameObject river;
    public GameObject oil;
    public GameObject sewage;
    public GameObject map;
    public Sprite fSprite;
    public Sprite mSprite;
    public Sprite dSprite;

    // Start is called before the first frame update
    void Start()
    {
        pharma.SetActive(false);
        coffee.SetActive(false);
        river.SetActive(false);
        oil.SetActive(false);
        sewage.SetActive(false);
        dImage.GetComponent<SpriteRenderer>().sprite = mSprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (map.activeSelf) Application.Quit();
            pharma.SetActive(false);
            coffee.SetActive(false);
            river.SetActive(false);
            oil.SetActive(false);
            sewage.SetActive(false);
            map.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) && map.activeSelf)
        {
            pharma.SetActive(true);
            coffee.SetActive(false);
            river.SetActive(false);
            oil.SetActive(false);
            sewage.SetActive(false);
            map.SetActive(false);
            dImage.GetComponent<SpriteRenderer>().sprite = fSprite;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && map.activeSelf)
        {
            pharma.SetActive(false);
            coffee.SetActive(false);
            river.SetActive(false);
            oil.SetActive(true);
            sewage.SetActive(false);
            map.SetActive(false);
            dImage.GetComponent<SpriteRenderer>().sprite = mSprite;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && map.activeSelf)
        {
            pharma.SetActive(false);
            coffee.SetActive(false);
            river.SetActive(false);
            oil.SetActive(false);
            sewage.SetActive(true);
            map.SetActive(false);
            dImage.GetComponent<SpriteRenderer>().sprite = mSprite;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && map.activeSelf)
        {
            pharma.SetActive(false);
            coffee.SetActive(true);
            river.SetActive(false);
            oil.SetActive(false);
            sewage.SetActive(false);
            map.SetActive(false);
            dImage.GetComponent<SpriteRenderer>().sprite = mSprite;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && map.activeSelf)
        {
            pharma.SetActive(false);
            coffee.SetActive(false);
            river.SetActive(true);
            oil.SetActive(false);
            sewage.SetActive(false);
            map.SetActive(false);
            dImage.GetComponent<SpriteRenderer>().sprite = dSprite;
        }
    }
}
