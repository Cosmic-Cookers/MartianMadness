using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Thi sis for the end screenw here you reveal the ramen recipe and after a few seconds, the UI needs to change
/// </summary>
public class Timing : MonoBehaviour
{

    public GameObject Margo_happy;
    public GameObject Quincy_happy;
    public GameObject Button;
    public Text text;
    void Start()
    {

        StartCoroutine(WaitCoroutine());
    }

    IEnumerator WaitCoroutine()
    {


        yield return new WaitForSeconds(4);   //after waiting 4 seconds then set the current expressions and text
        Margo_happy.SetActive(false);
        Quincy_happy.SetActive(true);
        text.text = "I’ve got your back, always. And look at how delicious that is! Great job!";
        Button.SetActive(true); //set next step button as true
    }
}
