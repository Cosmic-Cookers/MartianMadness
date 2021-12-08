using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timing : MonoBehaviour
{

    public GameObject Margo_happy;
    public GameObject Quincy_happy;
    public GameObject Button;
    public Text text;
    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(4);
        Margo_happy.SetActive(false);
        Quincy_happy.SetActive(true);
        text.text = "I’ve got your back, always. And look at how delicious that is! Great job!";
        Button.SetActive(true);
    }
}
