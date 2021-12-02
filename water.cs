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


        if (isDragging)
        {

            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
            shadow.SetActive(false);
        }
       



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpriteRenderer sprite = glass.GetComponent<SpriteRenderer>();
        if (collision.gameObject.name == "toparea")
        {
            GameObject StepManaging = GameObject.Find("StepManager");
            StepManager stepmanage = StepManaging.GetComponent<StepManager>();
            glass.SetActive(true);
            gameObject.SetActive(false);
         
            

            stepmanage.water = false;
          
      
           



        }
    
    }
}