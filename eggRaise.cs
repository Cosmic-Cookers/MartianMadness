using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This section is allowing for the eggs to bob up and down after eggs are put inside the pressure cooker
/// </summary>
public class eggRaise : MonoBehaviour
{
    /// <summary>
    /// position variables
    /// </summary>
    public Vector3 currentpos;
    public Vector3 newpos;
    public Vector3 oldpos;
    public Vector3 posholder;
    void Start()
    {
       
        newpos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1.2f, gameObject.transform.position.z); //set new position to ideal section for y position
        oldpos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + .4f, gameObject.transform.position.z); //set old position
    }

    // Update is called once per frame
    void Update()
    {
        currentpos = gameObject.transform.position; //get the currentposition of the eggs
      

        GameObject StepManaging = GameObject.Find("StepManager"); //find reference to step
        StepManager stepmanage = StepManaging.GetComponent<StepManager>();

        if (stepmanage.cooking) //if the eggs step cooking is set to true
        {
            

            if (currentpos != newpos) //if the current position does not equal the new position, move the egg towards the new position
            {
                currentpos = Vector3.MoveTowards(currentpos, newpos, 1f* Time.deltaTime);
                gameObject.transform.position = currentpos; //continously set current position to the transform position
            }

            if (currentpos == newpos) //once it gets to new position, set the new position as the old position and the old poisiton as new position
            {
                posholder = newpos;
                newpos = oldpos;
                oldpos = posholder;
                stepmanage.cooked = true; //step eggs as cooked as true
                
            }


        }
    }
}
