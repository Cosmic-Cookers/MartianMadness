using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCounter : MonoBehaviour
{
    public int eggCount = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (eggCount == 3)
        {
            GameObject UIhandle = GameObject.Find("Canvas");
            UIegghandler Uihandler = UIhandle.GetComponent<UIegghandler>();
            Uihandler.nextUI = true;
        }
    }
}
