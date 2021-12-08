using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addWok : MonoBehaviour
{

    private int clicks = 0;

    public GameObject wok;
    public GameObject onion1;
    public GameObject onion2;
    public GameObject onion3;
    public GameObject mush1;
    public GameObject mush2;
    public GameObject mush3;
    public GameObject meat1;
    public GameObject meat2;
    public GameObject meat3;
    public GameObject arrow;
    public GameObject eelanim;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        GameObject WokHandler = GameObject.Find("WokHandler");
        WokHandler Wokhandle = WokHandler.GetComponent<WokHandler>();
        if (gameObject.name == "rawonioncut")
        {
            if (Wokhandle.onion)
            {
                clicks++;
                if (clicks == 1)
                {
                    onion1.SetActive(true);

                    if (wok.GetComponent<AudioSource>().isPlaying == false)
                    {
                        wok.GetComponent<AudioSource>().Play();
                    }
                    arrow.SetActive(false);
                }
                else if (clicks == 2)
                {
                    onion2.SetActive(true);
                }
                else if (clicks == 3)
                {
                    onion3.SetActive(true);
                    clicks = 0;
                }
            }
        }
        else if (gameObject.name == "mushroomcut")
            {
                if (Wokhandle.mushroom)
                {
                    clicks++;
                    if (clicks == 1)
                    {
                    mush1.SetActive(true);
                     
                    }
                    else if (clicks == 2)
                    {
                        mush2.SetActive(true);
                    }
                    else if (clicks == 3)
                    {
                        mush3.SetActive(true);
                        clicks = 0;
                    }
                }
            }

        else if (gameObject.name == "spacemeatcut")
        {
            if (Wokhandle.meat)
            {
                clicks++;
                if (clicks == 1)
                {
                    meat1.SetActive(true);

                }
                else if (clicks == 2)
                {
                    meat2.SetActive(true);
                }
                else if (clicks == 3)
                {
                    meat3.SetActive(true);
                    clicks = 0;
                }
            }
        }

        else if (gameObject.name == "eelpic")
        {
            if (Wokhandle.eel)
            {
                eelanim.SetActive(true);
                gameObject.GetComponent<AudioSource>().Play();  
            }
         
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
