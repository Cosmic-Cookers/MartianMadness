using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
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

    public Text instructions;
    public GameObject arrow1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "StirFryStep1")
        {
            if (red == false || yellow == false)
            {
                instructions.text = "Add Lava Hot Sauces";
            }
            if (red && yellow)
            {
                instructions.text = "Mix Sauces";
            }

        }

        if (SceneManager.GetActiveScene().name == "RamenStep4")
        {
            if (fire == false)
            {
                instructions.text = "Stoke the fire";
                arrow1.SetActive(true);
            }
            if (fire)
            {
                instructions.text = "Add Neptune water";
                arrow1.SetActive(false);
                water = true;
            }
            if (stock)
            {
                instructions.text = "Add Kamary Stock";
            }

            if (soy)
            {
                instructions.text = "Add Soy Sauce";
            }

            if (hotsauce)
            {
                instructions.text = "Add Hot Sauce";
            }

            if (seasoning)
            {
                instructions.text = "Add Seasoning";
            }

            if (pepper)
            {
                instructions.text = "Soak Peppers";
            }

            if (onion)
            {
                instructions.text = "Add Cut Onions";
            }
            if (eel)
            {
                instructions.text = "Grab Laser";
            }
            if (eel2)
            {
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
       

    }



    
}
