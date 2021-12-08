using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatHandler : MonoBehaviour
{
    public int meatcounter = 0;
    public int meatfinalcounter = 0;

    public bool mixing = false;
 
    public bool mixed= false;

    public GameObject Button;

    public GameObject arrow;
    public GameObject arrow1;
    public GameObject bowl;
    public GameObject bowl2;
    public GameObject meatcoat1;
    public GameObject meatcoat2;
    public GameObject meatcoat3;
    public GameObject meatcoat4;


    public GameObject meatcoat5;
    public GameObject meatcoat6;
    public GameObject meatcoat7;
    public GameObject meatcoat8;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() { 
        Debug.Log(meatcounter);
        Debug.Log(meatfinalcounter);
        if (meatcounter == 1 &&meatfinalcounter==0)
        {
            meatcoat1.SetActive(true);
            arrow.SetActive(false);
            if (mixed)
            {
                arrow1.SetActive(true);
                meatcoat1.GetComponent<Draggable>().enabled = true;
                bowl.GetComponent<CircleCollider2D>().enabled = false;
                bowl2.GetComponent<CircleCollider2D>().enabled = false;

            }
            
          

        }
        if (mixed)
        {
            bowl.GetComponent<CircleCollider2D>().enabled = false;
            bowl2.GetComponent<CircleCollider2D>().enabled = false;
            if (meatcounter == 2 )
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
            bowl.GetComponent<CircleCollider2D>().enabled = true;
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

        if (meatfinalcounter == 1)
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
            Button.SetActive(true);
        }



    }
}
