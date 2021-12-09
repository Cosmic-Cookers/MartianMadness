using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This is for the pressure cooker scenes for the kamary recipe and ramen
/// </summary>
public class eggGrab : MonoBehaviour
{
    private bool isDragging;
    public int eggCount;
    public GameObject egg1;
    public GameObject egg2;
    public GameObject egg3;
    public GameObject egg4;
    public GameObject egg5;
    public GameObject egg6;
    public int eggRequired=0;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name== "KamaryStep1Pressure") //eggs required changed based on which scene
        {
            eggRequired = 6;
        }
        else if (SceneManager.GetActiveScene().name == "RamenStep2")
        {
            eggRequired = 3;
        }
    }
    public void OnMouseDown()
    {
        GameObject StepManaging = GameObject.Find("StepManager"); //reference to step manager
        StepManager stepmanage = StepManaging.GetComponent<StepManager>();
        if (stepmanage.lidStep && stepmanage.water==false) //if the lid step has been completed (lid taken off) and if water is no longer needed
        {
            isDragging = true;//allow for the eggs to be dragged
        }
        
    }


    public void OnMouseUp()
    {
        isDragging = false; //set it to false if mouse button lifted
    }


    void Update()
    {


        GameObject egg = this.gameObject; //set the egg to the one you're holding



        if (isDragging) //dragging section follow mouse position
        {
           
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "toparea") //top area of the pressure cooker
        {
            GameObject StepManaging = GameObject.Find("StepManager"); //reference to step manager
            StepManager stepmanage = StepManaging.GetComponent<StepManager>();
            gameObject.SetActive(false); //set egg to false
            stepmanage.eggCount++;
     
            if (stepmanage.eggCount == 1) //count how many eggs and set respective egg inside and play drop sound
            {
                egg1.SetActive(true);
                egg1.GetComponent<AudioSource>().Play();
            }
            if (stepmanage.eggCount == 2)
            {
                egg2.SetActive(true);
                egg2.GetComponent<AudioSource>().Play();
            }
            if (stepmanage.eggCount == 3)
            {
                egg3.SetActive(true);
                egg3.GetComponent<AudioSource>().Play();
            }
            if (stepmanage.eggCount == 4)
            {
                egg4.SetActive(true);
                egg4.GetComponent<AudioSource>().Play();

            }
            if (stepmanage.eggCount == 5)
            {
                egg5.SetActive(true);
                egg5.GetComponent<AudioSource>().Play();
            }
            if (stepmanage.eggCount == 6)
            {
                egg6.SetActive(true);
                egg6.GetComponent<AudioSource>().Play();
            }
            if (stepmanage.eggCount == eggRequired) //if number of eggs put in is equal to how many the scene requires
            {
                stepmanage.eggStep = true; //set the next step of egg to true
            }
        }
    }
}
