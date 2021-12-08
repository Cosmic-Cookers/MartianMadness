using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WokHandler : MonoBehaviour
{
    public bool onion = true;
    public bool mushroom = false;
    public bool meat = false;
    public bool eel = false;

    public GameObject onionpic;
    public GameObject meatpic;
    public GameObject mushroompic;
    public GameObject eelpic;
    public int onioncooked;
    public int mushcooked;
    public int meatcooked;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (onion && onioncooked!=3)
        {
            onionpic.GetComponent<SpriteRenderer>().sortingOrder = 3;

        }

        if (onioncooked == 3)
        {
            onionpic.GetComponent<SpriteRenderer>().sortingOrder = 1;
            mushroom = true;

        }

        if (mushcooked == 3)
        {
            mushroompic.GetComponent<SpriteRenderer>().sortingOrder = 1;
            meat = true;
        }

        if (mushroom && mushcooked!=3)
        {
            mushroompic.GetComponent<SpriteRenderer>().sortingOrder = 3;
        }

        if (eel)
        {
            eelpic.GetComponent<SpriteRenderer>().sortingOrder = 3;
        }

        if (meat)
        {
            meatpic.GetComponent<SpriteRenderer>().sortingOrder = 3;
        }
        if (meatcooked == 3)
        {
            meatpic.GetComponent<SpriteRenderer>().sortingOrder = 1;
            eel = true;
        }
    }
}
