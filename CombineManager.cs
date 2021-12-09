using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombineManager : MonoBehaviour
{
    /// <summary>
    /// This is for the randomize gameplay section for the combine ingredients
    /// </summary>
    public Text countdowns;//count down text
    public int timerText;

    /// <summary>
    /// Each ingreident has their own number order, their own text
    /// </summary>
    public int shaker=0;
    public int step1=0;
    public int step2=0;
    public int step3=0;
    public int step4=0;
    public Text shakerui;
    public Text spice1;
    public Text spice2;
    public Text spice3;
    public Text spice4;

    public GameObject Button; //button
    void Start()
    {
        StartCoroutine(Wait()); //start wait timer
        StartCoroutine(Countdown(3)); //countdown for 3 seconds
        randomize5(); //calls randomize 
    }
    void Update()
    {

        countdowns.text = timerText.ToString(); //sets the timer text to a string for the countdown

        if (timerText == 0) //once time hits 0
        {
            countdowns.gameObject.SetActive(false); //turn off count down
            order(); //set all the ordered numbers to their respective texts

            Button.SetActive(true); //set ingredient book start button active
        }

    }
    IEnumerator Countdown(int seconds) 
    {

        while (timerText > 0) //while the countdown is greater than 0
        {
            gameObject.GetComponent<AudioSource>().Play(); //play the tick tock sound
            countdowns.text = timerText.ToString(); //change the text
            yield return new WaitForSeconds(1); //wait a second
            timerText--; //decrease time


        }
        gameObject.GetComponent<AudioSource>().Play();

    }
    IEnumerator Wait()
    {

        yield return new WaitForSeconds(3); //wait for 3 seconds
        

    }

    void randomize5() //randomizes the steps
    {
   
        shaker= Random.Range(1, 6); //shaker is set from a random range
        step1= Random.Range(1, 6); //then the next ingredient is also set from a random range
        while (shaker == step1) //everytime it is randomize and they are the same. redo the randomize
        {
            step1 = Random.Range(1, 6);
        }
        step2= Random.Range(1, 6); //ranodmize step 2
        while (step2==shaker||step2==step1) //while any of them are the same number, randomize again
        {
            step2 = Random.Range(1, 6);
        }
        step3 = Random.Range(1, 6); //randomize step 3
        while (step3 == shaker || step3 == step1 || step3==step2)//while any of them are the same number, randomize again
        {
            step3 = Random.Range(1, 5);
        }
        step4 = Random.Range(1, 6); //randomize step 4
        while (step4 == shaker || step4 == step1 || step4 == step2|| step4==step3)//while any of them are the same number, randomize again
        {
            step4 = Random.Range(1, 6);
        }

        //Debug.Log(shaker + " " + step1 + " " + step2 + " " + step3 + " " + step4);

        

    }

    void order() //once order is established, set all UI text to the number
    {

        shakerui.text = shaker.ToString();
        spice1.text = step1.ToString();
        spice2.text = step2.ToString();
        spice3.text = step3.ToString();
        spice4.text = step4.ToString();
 
    }




}
