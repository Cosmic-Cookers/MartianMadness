using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{

    /// <summary>
    /// handles the UI for ramen and
    /// </summary>
    public bool fire = false;
    public bool water = false;
    public bool stock = false;
    public bool soy = false;
    public bool hotsauce = false;
    public bool seasoning = false;
    public bool onion= false;
    public bool eel = false;
    public bool eel2 = false;
    public bool eel3 = false;
    public bool pepper;
    public bool fireOff = false;
    public bool red = false;
    public bool yellow = false;
    public bool meat1 = false;

    public GameObject arrow1;
    public Text instructions;

    public GameObject Quincy_expressionless;
    public GameObject Margo_thinking;
    public GameObject Quincy_sarcastic;
    public GameObject Margo_disappointed;
    public GameObject Quincy_happy;

    public Text text;
/// <summary>
/// EVERY SECTION IS JUST IF THE BOOLEAN IS SET TO TRUE, CHANGE THE UI
/// </summary>
    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "StirFryStep1")
        {
            if (red == false || yellow == false) //if you haven't added both sauces keep this text
            {
                instructions.text = "Add Lava Hot Sauces";
            }
            if (red && yellow) //if you have both sauces then set UI to mix
            {
                instructions.text = "Mix Sauces";
            }

        }

        if (SceneManager.GetActiveScene().name == "RamenStep4")
        {
            if (fire == false) //if fire hasn't been set
            {
                instructions.text = "Stoke the fire"; 
                arrow1.SetActive(true); //show arrow to fire
            }
            if (fire) //if fire has been set, add info for neptune water
            {
                instructions.text = "Add Neptune water";
                text.text = "Add in your Neptune water and Kamary stock.";

                arrow1.SetActive(false);
                water = true;
            }
            if (stock) //if stock needs to be added
            {
                instructions.text = "Add Kamary Stock";
            }

            if (soy) //if soy sauce add visual novel text
            {
                text.text = "No wonder he distrusts humans. They took everything from him. I’ll add the soy sauce and hot sauce next.";
                Quincy_expressionless.SetActive(false);
                Margo_thinking.SetActive(true);
                instructions.text = "Add Soy Sauce";
            }

            if (hotsauce)
            {
                instructions.text = "Add Hot Sauce";
            }

            if (seasoning)
            {
                text.text = "Don’t be afraid to add a little seasoning too. Spice always makes a dish better.";
                Margo_thinking.SetActive(false);
                Quincy_expressionless.SetActive(true);
                instructions.text = "Add Seasoning";
            }

            if (pepper)
            {
                text.text= "You’re right about the seasoning. These peppers are sure to give the ramen some kick, too.";
                Quincy_expressionless.SetActive(false);
                Margo_thinking.SetActive(true);
                instructions.text = "Soak Peppers";
            }

            if (onion)
            {
                text.text = "You should know by now that I’m usually right about everything! Add the onions and then grab your laser.";
                Margo_thinking.SetActive(false);
                Quincy_sarcastic.SetActive(true);
                instructions.text = "Add Cut Onions";
            }
            if (eel)
            {
                text.text = "I always took Xenon’s treatment of me personally. Maybe all he needs is for a human to show him that we can be good, too.";
                Quincy_sarcastic.SetActive(false);
                Margo_disappointed.SetActive(true);
                instructions.text = "Grab Laser";
            }
            if (eel2)
            {
                text.text = "No one would be better for that job than you, Margo. Now net the eels and let’s finish up by putting out the fire.";
                Margo_disappointed.SetActive(false);
                Quincy_happy.SetActive(true);
                instructions.text = "Net the Eels";
            }
            if (eel3)
            {
                instructions.text = "Add Eels";
            }
            if (fireOff)
            {
                instructions.text = "Put Out Fire";
            }
        }

        if (SceneManager.GetActiveScene().name == "StirFryStep4")
        {
            GameObject MeatHandling = GameObject.Find("MeatHandler");
            MeatHandler Meathandle = MeatHandling.GetComponent<MeatHandler>();
            if (meat1==false)
            {
                instructions.text = "Add Meat to Sauce";
            }
            if (meat1)
            {
                instructions.text = "Stir and Coat Meat";
            }

            if (Meathandle.meatfinalcounter==0 && Meathandle.mixed)
            {
                instructions.text = "Place Meat on Tray";
            }

            if (Meathandle.meatfinalcounter >= 1)
            {
                instructions.text = "Coat the Meat";
            }
       
        }
        if (SceneManager.GetActiveScene().name == "StirFryStep5")
        {
            GameObject WokHandler = GameObject.Find("WokHandler");
            WokHandler Wokhandle = WokHandler.GetComponent<WokHandler>();

            if (Wokhandle.onion)
            {
                instructions.text = "Add 3 Onions";

            }
            if (Wokhandle.mushroom)
            {
                instructions.text = "Add 3 Mushrooms";
            }
            if (Wokhandle.meat)
            {
                instructions.text = "Add 3 Lemb Slices";
            }
            if (Wokhandle.eel)
            {
                instructions.text = "Add Eels in Sauce";
            }


        }


    }



    
}
