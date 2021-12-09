using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Thi sis for the moving egg script for the ramen recipe when you have to crack the egg
/// </summary>
public class movingegg : MonoBehaviour
{
    public Vector3 currentpos;
    public Vector3 newpos;
    public Vector3 oldpos;
    public Vector3 posholder;
    public GameObject Button;
    void Start()
    {

        newpos = new Vector3(gameObject.transform.position.x-7f, gameObject.transform.position.y, gameObject.transform.position.z); //set desired positions to go back and forth from
        oldpos = new Vector3(gameObject.transform.position.x+7f, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        currentpos = gameObject.transform.position;
        if (!Button.activeInHierarchy) //if it is not time for the next step because the button isn't active
        {
            if (currentpos != newpos) //move towards the new position as long as the egg's position is not there yet
            {
                currentpos = Vector3.MoveTowards(currentpos, newpos, 8f * Time.deltaTime);
                gameObject.transform.position = currentpos;
            }

            if (currentpos == newpos) //once it reaches that position, then flip it so that it goes back the other way
            {
                posholder = newpos;
                newpos = oldpos;
                oldpos = posholder;


            }
        }

     }
    
}
