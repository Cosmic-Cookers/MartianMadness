using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookingAnim : MonoBehaviour
{
    /// <summary>
    /// Set cooking animation to true once it has been 5 seconds for each of the ingredients
    /// </summary>
    public GameObject Button; //next step
    void Start()
    {
        StartCoroutine(CookingCoroutine()); //start the waiting section coroutine
    }

    IEnumerator CookingCoroutine()
    {
        GameObject WokHandler = GameObject.Find("WokHandler"); //find reference to wok handler
        WokHandler Wokhandle = WokHandler.GetComponent<WokHandler>();

        yield return new WaitForSeconds(5); //once object is set to active, it will wait for 5 seconds

        if (gameObject.name == "rawonioncut") // if its onion, after the 5 seconds switch the animation
        {
            gameObject.GetComponent<Animator>().SetBool("cooked", true); //set the paramter to true and have the animation to play;
            Wokhandle.onioncooked++; //set wok handler's counter for onions to increase by one
        }
        else if (gameObject.name == "mushroomcut") //if its mushroom
        {
   
            gameObject.GetComponent<Animator>().SetBool("cooked", true); //set cooked animation
            Wokhandle.mushcooked++; //increase mushroom by one
        }
        else if (gameObject.name == "spacemeatcut") //if its meat
        {
            gameObject.GetComponent<Animator>().SetBool("cooked", true); //set cooked animation
            Wokhandle.meatcooked++; //increase meat by one
        }

        else if (gameObject.name == "eel") //if its meat
        {
            Button.SetActive(true); //set next button active
        }

        }
}
