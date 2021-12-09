using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is the script to handle the wok scene. It follows how many have been cooked
/// </summary>
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
        if (onion && onioncooked!=3) //if the onion doesn't equal 3 in the pan keep the soritn order above the panel
        {
            onionpic.GetComponent<SpriteRenderer>().sortingOrder = 3;

        }

        if (onioncooked == 3) //once it is 3 set the sorting order behind the panel
        {
            onionpic.GetComponent<SpriteRenderer>().sortingOrder = 1;
            mushroom = true; //next step for mushrooms

        }

        if (mushcooked == 3)
        {
            mushroompic.GetComponent<SpriteRenderer>().sortingOrder = 1; //below panel
            meat = true; //next step
        }

        if (mushroom && mushcooked!=3) //if mushroom isn't 3
        {
            mushroompic.GetComponent<SpriteRenderer>().sortingOrder = 3; //above panel
        }

        if (eel)
        {
            eelpic.GetComponent<SpriteRenderer>().sortingOrder = 3; //set eel above panel
        }

        if (meat)
        {
            meatpic.GetComponent<SpriteRenderer>().sortingOrder = 3; //set meat above panel
        }
        if (meatcooked == 3) //if meat is 3, set it below
        {
            meatpic.GetComponent<SpriteRenderer>().sortingOrder = 1;
            eel = true; //set for eels to be next step
        }
    }
}
