using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombineManager : MonoBehaviour
{
    public Text countdowns;
    public int timerText;
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
    public GameObject Button;
    void Start()
    {
        StartCoroutine(Wait());
        StartCoroutine(Countdown(3));
        randomize5();
    }
    void Update()
    {

        countdowns.text = timerText.ToString();

        if (timerText == 0)
        {
            countdowns.gameObject.SetActive(false);
            order();
            Button.SetActive(true);
        }

    }
    IEnumerator Countdown(int seconds)
    {

        while (timerText > 0)
        {
            gameObject.GetComponent<AudioSource>().Play();
            countdowns.text = timerText.ToString();
            yield return new WaitForSeconds(1);
            timerText--;


        }
        gameObject.GetComponent<AudioSource>().Play();

    }
    IEnumerator Wait()
    {

        yield return new WaitForSeconds(3);
        

    }

    void randomize5()
    {
   
        shaker= Random.Range(1, 6);
        step1= Random.Range(1, 6);
        while (shaker == step1)
        {
            step1 = Random.Range(1, 6);
        }
        step2= Random.Range(1, 6);
        while (step2==shaker||step2==step1)
        {
            step2 = Random.Range(1, 6);
        }
        step3 = Random.Range(1, 6);
        while (step3 == shaker || step3 == step1 || step3==step2)
        {
            step3 = Random.Range(1, 5);
        }
        step4 = Random.Range(1, 6);
        while (step4 == shaker || step4 == step1 || step4 == step2|| step4==step3)
        {
            step4 = Random.Range(1, 6);
        }

        Debug.Log(shaker + " " + step1 + " " + step2 + " " + step3 + " " + step4);

        

    }

    void order()
    {

        shakerui.text = shaker.ToString();
        spice1.text = step1.ToString();
        spice2.text = step2.ToString();
        spice3.text = step3.ToString();
        spice4.text = step4.ToString();
 
    }




}
