using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StepManager : MonoBehaviour
{
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

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "RamenStep2")
        {
            water = true;
        }
    }

    // Update is called once per frame
    void Update()

    {
        if (water && lidStep && eggCount==0)
        {
            arrow5.SetActive(true);

        }
        if ((water==false)&& lidStep && eggCount == 0)
        {
            arrow2.SetActive(true);
            arrow5.SetActive(false);

        }
        if (eggCount == 1)
        {
            arrow2.SetActive(false);
        }
        if (eggStep && lidStep2 == false)
        {
            GameObject lid = GameObject.Find("lid");
            lid.GetComponent<liftLid>().enabled = true;
        }
        if (lidStep && eggStep && lidStep2 == false)
        {
            arrow3.SetActive(true);
        }

        if (lidStep2 && animsound==false)
        {
            cookanim.SetActive(true);
            this.gameObject.GetComponent<AudioSource>().Play();
            animsound = true;
            cooking = true;
        }

        if (cooking)
        {
            arrow3.SetActive(false);
        }

        if (cooked)
        {
            
            Button.SetActive(true);
        }
    }
}
