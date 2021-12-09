using UnityEngine;
using System.Collections;

public class ClickManager : MonoBehaviour
{
    /// <summary>
    /// This script is for the cut script that is fromt he sliceable asset pack. This makes sure that theplayer only cuts along the lines
    /// </summary>
    public bool click1 = false;
    public bool click2 = false;
    void Update()
    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //reference to the mouse position of th eplayer
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        if (Input.GetMouseButtonDown(0)) //if player clicks
        {
            if (hit.collider != null) //if the object that is hit has a colider
            {
                if (hit.collider.gameObject.tag == "lines") //if the collider's tag is "lines"
                {
                    //Debug.Log("first click true");
                    click1 = true; //the player clicks inside the lnie's collider for the first click
                }
                else
                {
                    click1 = false; //the  player doesn't click inside
                }
            }
        }
        if (Input.GetMouseButtonUp(0)) //once you lift thec click
        {
            if (hit.collider != null)
            {
                if (hit.collider.gameObject.tag == "lines") //if when you click it you are within the line, set click to true
                {
                    //Debug.Log("second click true");
                    click2 = true;

                }
                else
                {
                    click2 = false;
                }
            }
        }

        //if (click1 && click2)
        //{
        //    Debug.Log("CUT");
        //}


    }

}
