using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liftLid : MonoBehaviour
{
    private bool isDragging;
    public GameObject arrow2;
    public GameObject arrow3;
    public GameObject dial;
    public void OnMouseDown()
    {
        isDragging = true;
        GameObject StepManaging = GameObject.Find("StepManager");
        StepManager stepmanage = StepManaging.GetComponent<StepManager>();
        if (stepmanage.lidStep == false)
        {
            if (arrow2.GetComponent<SpriteRenderer>().enabled == true)
            {
                gameObject.GetComponent<AudioSource>().Play();
            }
            arrow2.GetComponent<SpriteRenderer>().enabled = false;
            arrow3.SetActive(true);
            
        
        }
        
    }


    public void OnMouseUp()
    {
        isDragging = false;
    }


    void Update()
    {


        GameObject liddrop = this.gameObject;
        

       
        if (isDragging)
            {

                Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                transform.Translate(mousePosition);
            }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject StepManaging = GameObject.Find("StepManager");
        StepManager stepmanage = StepManaging.GetComponent<StepManager>();

        if (collision.gameObject.name == "arrow3")
        {
            arrow3.SetActive(false);
           
            Debug.Log("entered");
            gameObject.transform.localPosition = new Vector3(4.21000004f, 1.41999996f, 0f);
            gameObject.GetComponent<liftLid>().enabled = false;
            stepmanage.lidStep = true;
            dial.GetComponent<AudioSource>().Play();

     

        }

        if (collision.gameObject.name == "arrow4"){
            Debug.Log("entered2");
            stepmanage.lidStep2 = true;
            gameObject.GetComponent<liftLid>().enabled = false;
            gameObject.transform.localPosition = new Vector3(0.340000004f, 6.21000004f, 0f);
            gameObject.GetComponent<AudioSource>().Play();

        }
    }
}
