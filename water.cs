using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    private bool isDragging;
    public GameObject glass;
    public GameObject shadow;
    public Vector3 currentpos;
    public Vector3 waterPos;

    /// <summary>
    /// This script is to grab the water to fill the pressure cooker
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {


        SpriteRenderer sprite = glass.GetComponent<SpriteRenderer>();
    }
    public void OnMouseDown()
    {
        GameObject StepManaging = GameObject.Find("StepManager");
        StepManager stepmanage = StepManaging.GetComponent<StepManager>();
        if (stepmanage.lidStep)
        {
            isDragging = true;
        }

    }


    public void OnMouseUp()
    {
        isDragging = false;
    }


    void Update()
    {


        if (isDragging) //if you are dragging it, follow the position and set the shadow to false
        {

            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
            shadow.SetActive(false);
        }
       



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpriteRenderer sprite = glass.GetComponent<SpriteRenderer>();
        if (collision.gameObject.name == "toparea") //if it enters the top area of the pressure cooker
        {
            GameObject StepManaging = GameObject.Find("StepManager");
            StepManager stepmanage = StepManaging.GetComponent<StepManager>();
            glass.SetActive(true); //set the object with the animation true
            gameObject.SetActive(false); //turn off the water bowl
         
            

            stepmanage.water = false; //finish the step of adding water
          
      
           



        }
    
    }
}