using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is to work with the UI to add the wok ingredients if the player clicks on the object
/// </summary>
public class addWok : MonoBehaviour
{

    private int clicks = 0; //clicks refers to to the player clicks on the certain object

    /// <summary>
    /// Game Objects are added within the inspector of 3 of each meat, mushroom, and onion. This also includes an arrow fo rthe initial click and the eel animation
    /// </summary>
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
 
    private void OnMouseDown()
    {
        GameObject WokHandler = GameObject.Find("WokHandler"); //find reference to the wokhandler which is an game object within the game
        WokHandler Wokhandle = WokHandler.GetComponent<WokHandler>();

        if (gameObject.name == "rawonioncut") //refers to the name of the object when clicked upon
        {
            if (Wokhandle.onion) //Wok handler boolean which orders the steps of the ingredients
            {
                clicks++; //once a player clicks, increase teh click count
                if (clicks == 1) // if clicked set the respective onion active
                {
                    onion1.SetActive(true);

                    if (wok.GetComponent<AudioSource>().isPlaying == false) //Start playing sizzling noise that is attached to the wok object if it already not playing
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
                    clicks = 0; //after gettign 3 clicks reset clicks for the rest of the ingredients
                }
            }
        }
        else if (gameObject.name == "mushroomcut") //refers to the name of the object when clicked upon
        {
                if (Wokhandle.mushroom) //Wok handler boolean which orders the steps of the ingredients
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

        else if (gameObject.name == "spacemeatcut")//refers to the name of the object when clicked upon
        {
            if (Wokhandle.meat) //Wok handler boolean which orders the steps of the ingredients
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

        else if (gameObject.name == "eelpic") //refers to the name of the object when clicked upon
        {
            if (Wokhandle.eel) //Wok handler boolean which orders the steps of the ingredients
            {
                eelanim.SetActive(true); //set the animation true
                gameObject.GetComponent<AudioSource>().Play();  //play the respective audio for boiling
            }
         
        }
    }

}
