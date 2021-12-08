using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookingAnim : MonoBehaviour
{
    public GameObject Button;
    void Start()
    {
        StartCoroutine(CookingCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CookingCoroutine()
    {
        GameObject WokHandler = GameObject.Find("WokHandler");
        WokHandler Wokhandle = WokHandler.GetComponent<WokHandler>();

        yield return new WaitForSeconds(5);

        if (gameObject.name == "rawonioncut")
        {
            gameObject.GetComponent<Animator>().SetBool("cooked", true);
            Wokhandle.onioncooked++;
        }
        else if (gameObject.name == "mushroomcut")
        {
   
            gameObject.GetComponent<Animator>().SetBool("cooked", true);
            Wokhandle.mushcooked++;
        }
        else if (gameObject.name == "spacemeatcut")
        {
            gameObject.GetComponent<Animator>().SetBool("cooked", true);
            Wokhandle.meatcooked++;
        }

        else if (gameObject.name == "eel")
        {
            Button.SetActive(true);
        }

        }
}
