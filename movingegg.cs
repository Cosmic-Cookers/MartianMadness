using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingegg : MonoBehaviour
{
    public Vector3 currentpos;
    public Vector3 newpos;
    public Vector3 oldpos;
    public Vector3 posholder;
    public GameObject Button;
    void Start()
    {

        newpos = new Vector3(gameObject.transform.position.x-7f, gameObject.transform.position.y, gameObject.transform.position.z);
        oldpos = new Vector3(gameObject.transform.position.x+7f, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        currentpos = gameObject.transform.position;
        if (!Button.activeInHierarchy)
        {
            if (currentpos != newpos)
            {
                currentpos = Vector3.MoveTowards(currentpos, newpos, 8f * Time.deltaTime);
                gameObject.transform.position = currentpos;
            }

            if (currentpos == newpos)
            {
                posholder = newpos;
                newpos = oldpos;
                oldpos = posholder;


            }
        }
           
   

           


        }
    
}
