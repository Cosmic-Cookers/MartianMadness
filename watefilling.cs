using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watefilling : MonoBehaviour
{
    public Vector3 currentpos;
    public Vector3 waterPos;
    // Start is called before the first frame update
    void Start()
    {
        currentpos = new Vector3(transform.position.x,transform.position.y, transform.position.z);
        waterPos = new Vector3(2.67f, -3.25f, -1.2f);
        gameObject.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {

        GameObject StepManaging = GameObject.Find("StepManager");
        StepManager stepmanage = StepManaging.GetComponent<StepManager>();

            if (currentpos != waterPos)
            {
                currentpos = Vector3.MoveTowards(currentpos, waterPos, 1f * Time.deltaTime);
                gameObject.transform.position = currentpos;

            }
        
    }
}
