using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject egg1;
    public GameObject egg2;
    public GameObject egg3;



    // Update is called once per frame
    void Update()
    {
         
        
        GameObject egg = GameObject.Find("Egg Counter");
        EggCounter eggcounting = egg.GetComponent<EggCounter>();

        if (eggcounting.eggCount == 1)
        {
            egg1.SetActive(false);

        }
        if (eggcounting.eggCount == 2)
        {
            egg2.SetActive(false);

        }
        if (eggcounting.eggCount == 3)
        {
            egg3.SetActive(false);

        }

    }
}
