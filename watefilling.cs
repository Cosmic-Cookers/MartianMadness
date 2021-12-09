using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// WATER FILLING IN THE PRESSURE COOKER SCENE
/// </summary>
public class watefilling : MonoBehaviour
{
    public Vector3 currentpos;
    public Vector3 waterPos;
    // Start is called before the first frame update
    void Start()
    {
        currentpos = new Vector3(transform.position.x,transform.position.y, transform.position.z);
        waterPos = new Vector3(2.68f, -1.65f, -1.2f); 
        gameObject.GetComponent<AudioSource>().Play(); //play the audio when the object is active
    }

    // Update is called once per frame
    void Update()
    {

        GameObject StepManaging = GameObject.Find("StepManager");
        StepManager stepmanage = StepManaging.GetComponent<StepManager>();

            if (currentpos != waterPos) //if the water isn't at the position, move the object towards it os that the water fills the pressure cooker
            {
                currentpos = Vector3.MoveTowards(currentpos, waterPos, 1.5f * Time.deltaTime);
                gameObject.transform.position = currentpos;

            }
        
    }
}
