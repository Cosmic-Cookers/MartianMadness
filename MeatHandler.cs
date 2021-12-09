using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is to count how many meats have been placed into the bowl, mixed, then placed ont he pan
/// </summary>
public class MeatHandler : MonoBehaviour
{
    public int meatcounter = 0; //initial counter at mixing
    public int meatfinalcounter = 0; //counter for when placed on pan after being mixed

    public bool mixing = false; //mixing state
 
    public bool mixed= false; //has already been mixed

    public GameObject Button;

    /// <summary>
    /// Section for arrows and initial meats
    /// </summary>
    public GameObject arrow;
    public GameObject arrow1;
    public GameObject bowl;
    public GameObject bowl2;
    public GameObject meatcoat1;
    public GameObject meatcoat2;
    public GameObject meatcoat3;
    public GameObject meatcoat4;

    /// <summary>
    /// Coated meats
    /// </summary>
    public GameObject meatcoat5;
    public GameObject meatcoat6;
    public GameObject meatcoat7;
    public GameObject meatcoat8;


    // Update is called once per frame
    void Update() { 
        //Debug.Log(meatcounter);
        //Debug.Log(meatfinalcounter);

        if (meatcounter == 1 &&meatfinalcounter==0) //if it is the first meat taken out of the pan
        {
            meatcoat1.SetActive(true);
            arrow.SetActive(false); //set the arrow as false
            if (mixed) //if it is mixed
            {
                arrow1.SetActive(true); //show arrow to put in the pan
                meatcoat1.GetComponent<Draggable>().enabled = true; //allow for it to be dragged
                bowl.GetComponent<CircleCollider2D>().enabled = false; //turn off the colliders of the bowls so it doesnt interfere
                bowl2.GetComponent<CircleCollider2D>().enabled = false;

            }
            
          

        }
        if (mixed) //if its mixed
        {
            bowl.GetComponent<CircleCollider2D>().enabled = false; //turn off colliders
            bowl2.GetComponent<CircleCollider2D>().enabled = false;

            if (meatcounter == 2 ) //set each meat respectively and make them draggable when they are done being mixed.
            {
                meatcoat2.GetComponent<Draggable>().enabled = true;
            }
            if (meatcounter == 3)
            {
                meatcoat3.GetComponent<Draggable>().enabled = true;
            }
            if (meatcounter == 4)
            {
                meatcoat4.GetComponent<Draggable>().enabled = true;
            }
     
        }
        if (mixed == false)
        {
            bowl.GetComponent<CircleCollider2D>().enabled = true; //reset their colliders
            bowl2.GetComponent<CircleCollider2D>().enabled = true;
        }
        if (meatcounter == 2 && meatfinalcounter == 1)
        {
            meatcoat2.SetActive(true);
        }
        else if (meatcounter == 3 && meatfinalcounter == 2)
        {
            meatcoat3.SetActive(true);
        }
        else if (meatcounter == 4 && meatfinalcounter == 3)
        {
            meatcoat4.SetActive(true);
        }

        if (meatfinalcounter == 1) //set actives on the pan for each respective meats.
        {
            meatcoat5.SetActive(true);
            arrow1.SetActive(false);

        }
        if (meatfinalcounter == 2)
        {
            meatcoat6.SetActive(true);
        }
        if (meatfinalcounter == 3)
        {
            meatcoat7.SetActive(true);
        }
        if (meatfinalcounter == 4)
        {
            meatcoat8.SetActive(true);
            Button.SetActive(true); //next step button is set to active
        }



    }
}
