using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This script is to lift the lid on the pressure cooker
/// </summary>
public class liftLid : MonoBehaviour
{
   
    private bool isDragging;
    public GameObject arrow2;
    public GameObject arrow3;
    public GameObject dial;
    public void OnMouseDown()
    {
        isDragging = true;
        GameObject StepManaging = GameObject.Find("StepManager"); //reference step manager
        StepManager stepmanage = StepManaging.GetComponent<StepManager>();
        if (stepmanage.lidStep == false) 
        {
            if (arrow2.GetComponent<SpriteRenderer>().enabled == true) 
            {
                gameObject.GetComponent<AudioSource>().Play(); //play sound if the arrow is still active
            }
            arrow2.GetComponent<SpriteRenderer>().enabled = false; //turn off its renderer
            arrow3.SetActive(true); //set up next arrow
            
        
        }
        
    }


    public void OnMouseUp()
    {
        isDragging = false;
    }


    void Update()
    {


        GameObject liddrop = this.gameObject; //set as the lid
        

       
        if (isDragging)
            {

                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(mousePosition);
            }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject StepManaging = GameObject.Find("StepManager"); //reference to step manager
        StepManager stepmanage = StepManaging.GetComponent<StepManager>();

        if (collision.gameObject.name == "arrow3") //if lid is placed within the arrow's collider (which is on the table)
        {
            arrow3.SetActive(false); //turn off the arrow
           
            Debug.Log("entered");
            gameObject.transform.localPosition = new Vector3(4.21000004f, 1.41999996f, 0f); //place the object in this position
            gameObject.GetComponent<liftLid>().enabled = false; //turn off the ability to pick up the lid
            stepmanage.lidStep = true; //next step
            dial.GetComponent<AudioSource>().Play(); //play teh sound for placing the lid 

     

        }

        if (collision.gameObject.name == "arrow4"){ //if they enter teh arrow area, which will be on the top of the pressure cooker
            Debug.Log("entered2");
            stepmanage.lidStep2 = true; //set next step
            gameObject.GetComponent<liftLid>().enabled = false; //make it so you can't pick it up again
            gameObject.transform.localPosition = new Vector3(0.340000004f, 6.21000004f, 0f); //place back in a position
            gameObject.GetComponent<AudioSource>().Play(); //play sound 

        }
    }
}
