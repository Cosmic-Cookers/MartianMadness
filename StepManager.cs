using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StepManager : MonoBehaviour
{

    /// <summary>
    /// This code is used for the pressure cooking scenes in order of steps
    /// </summary>
    public bool lidStep = false;
    public bool eggStep = false;
    public bool lidStep2 = false;
    public bool animsound = false;

    public int eggCount = 0;
    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow3;
    public GameObject arrow5;
    public GameObject cookanim;
    public bool cooking=false;
    public bool cooked = false;
    public GameObject Button;
    public bool water = false;

   //Visual novel texts and expressions
    public Text text;
    public GameObject Quincy_laughing;
    public GameObject Margo_thinking;
    public GameObject Quincy_expressionless;
    public GameObject Margo_sarcastic;

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "RamenStep2") //if it is the ramen step, allow for water
        {
            water = true;
        }
    }

    // Update is called once per frame
    void Update()

    {
        if (water && lidStep && eggCount==0) //if water is necessary, it's lid step, and no eggs have been added
        {
            arrow5.SetActive(true); //set this arrow to true

        }
        if ((water==false)&& lidStep && eggCount == 0) //if water has been poured, or not needed and lid has been removed and no eggs are placed in
        {
            text.text = "So what really happened?"; //set visual novel section
            Quincy_laughing.SetActive(false);
            Margo_thinking.SetActive(true);
            arrow2.SetActive(true); //show arrows
            arrow5.SetActive(false);

        }
        if (eggCount == 1)
        {
            text.text = "I’ll tell you as long as you keep working while we talk. If Chef hears this history lesson, he’ll throw a tantrum.";
            Margo_thinking.SetActive(false);
            Quincy_expressionless.SetActive(true);
            arrow2.SetActive(false);
        }
        if (eggStep && lidStep2 == false)
        {
           
            GameObject lid = GameObject.Find("lid");
            lid.GetComponent<liftLid>().enabled = true; //allow for lid to be dragged
        }
        if (lidStep && eggStep && lidStep2 == false)
        {
            text.text = "I can multitask.";
            Quincy_expressionless.SetActive(false);
            Margo_sarcastic.SetActive(true);
            arrow3.SetActive(true);
        }

        if (lidStep2 && animsound==false)
        {
            cookanim.SetActive(true); //set object with animation true
            this.gameObject.GetComponent<AudioSource>().Play(); //play the sound
           
            animsound = true;
            cooking = true;
        }

        if (cooking)
        {
            text.text = "There was a full out war. Martians didn’t want human technology. Frankly, you guys were way behind.";
            Margo_sarcastic.SetActive(false);
            Quincy_expressionless.SetActive(true);
            arrow3.SetActive(false);
        }

        if (cooked)
        {
            
            Button.SetActive(true); //once its cooked, set button to true
        }
    }
}
