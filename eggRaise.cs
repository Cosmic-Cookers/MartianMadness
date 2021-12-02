using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggRaise : MonoBehaviour
{
    public Vector3 currentpos;
    public Vector3 newpos;
    public Vector3 oldpos;
    public Vector3 posholder;
    void Start()
    {
       
        newpos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1.2f, gameObject.transform.position.z);
        oldpos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + .4f, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        currentpos = gameObject.transform.position;
      

        GameObject StepManaging = GameObject.Find("StepManager");
        StepManager stepmanage = StepManaging.GetComponent<StepManager>();

        if (stepmanage.cooking)
        {
            

            if (currentpos != newpos)
            {
                currentpos = Vector3.MoveTowards(currentpos, newpos, 1f* Time.deltaTime);
                gameObject.transform.position = currentpos;
            }

            if (currentpos == newpos)
            {
                posholder = newpos;
                newpos = oldpos;
                oldpos = posholder;
                stepmanage.cooked = true;
                
            }


        }
    }
}
