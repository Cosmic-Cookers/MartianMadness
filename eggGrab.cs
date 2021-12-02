using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (SceneManager.GetActiveScene().name== "KamaryStep1Pressure")
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
        GameObject StepManaging = GameObject.Find("StepManager");
        StepManager stepmanage = StepManaging.GetComponent<StepManager>();
        if (stepmanage.lidStep && stepmanage.water==false)
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


        GameObject egg = this.gameObject;



        if (isDragging)
        {
           
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "toparea")
        {
            GameObject StepManaging = GameObject.Find("StepManager");
            StepManager stepmanage = StepManaging.GetComponent<StepManager>();
            gameObject.SetActive(false);
            stepmanage.eggCount++;
     
            if (stepmanage.eggCount == 1)
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
            if (stepmanage.eggCount == eggRequired)
            {
                stepmanage.eggStep = true;
            }
        }
    }
}
