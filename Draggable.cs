using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Draggable : MonoBehaviour
{

    /// <summary>
    /// This is to make an object draggable during the certain section of the recipe. 
    /// </summary>
    private bool isDragging;
    public GameObject water;
    public GameObject stock;
    public GameObject hotsauce;
    public GameObject seasoning;
    public GameObject soysauce;
    public GameObject pepper;
    public GameObject eel;
    public GameObject onion;
    public GameObject laser;
    public GameObject waterpot;
    public GameObject waterpot1;



    public void OnMouseDown()
    {
 
        GameObject UiHandling = GameObject.Find("UIHandler"); //find UI handler object
        UIHandler Uihandle = UiHandling.GetComponent<UIHandler>();

        if (this.gameObject.name == "water") 
        {


            if (Uihandle.fire) //if UI handler boolean is fire is turned on
            {
                water.SetActive(false);
                isDragging = true; //allow for object to be dragged
                this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 5; //place object infront of everything when you're holding
            }
        }
        else if (this.gameObject.name == "stock")
        {


            if (Uihandle.stock) //if the current step is for stock
            {
                stock.SetActive(false);
                this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 4; //place object infront of everything
                isDragging = true; //allowed to be dragged
            }
        }
        else if (this.gameObject.name == "hotsauce")
        {
            if (Uihandle.hotsauce) //if current step is for hot sauce
            {
                hotsauce.SetActive(false);
                this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2; //place object above everything
                isDragging = true; //allowed to be dragged
            }
           
        }
        else if (this.gameObject.name == "seasoning")
        {
            if (Uihandle.seasoning) //if step is for seasoning
            {
                seasoning.SetActive(false);
                this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 5; //place object infront of everything
                isDragging = true; //allowed to be dragged
            }
            
        }
        else if (this.gameObject.name == "soysauce")
        {
            if (Uihandle.soy) //if step is for soy
            {
                isDragging = true; //allowed to be dragged
                soysauce.SetActive(false);
                this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 3; //place object infront
            }
           
        }
        else if (this.gameObject.name == "pepper")
        {
            if (Uihandle.pepper) //if step for pepper
            {
                pepper.SetActive(false);
                isDragging = true; //allowed to be dragged
                this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2; //place object infront
            }
            
        }
        else if (this.gameObject.name == "eel")
        {
            eel.SetActive(false);
        }
        else if (this.gameObject.name == "onion")
        {
            if (Uihandle.onion)
            {
                onion.SetActive(false);
                isDragging = true; //allowed to be dragged
                this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2; //infront
            }
           
        }
        else if (this.gameObject.name == "laser")
        {
            if (Uihandle.eel)
            {
                laser.SetActive(false);
                this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 5;
                isDragging = true;
                Uihandle.eel2 = true; //set the second step for eel to be true
            }
          
        }
        else if (this.gameObject.name == "red")
        {
            isDragging = true;
            
            hotsauce.GetComponent<SpriteRenderer>().sortingOrder = 5; //this section just sets the bowls and sauces to previously named game objects. Make it so that they are placed infront of everything when dragged.
            water.GetComponent<SpriteRenderer>().sortingOrder = 6;
            seasoning.GetComponent<SpriteRenderer>().sortingOrder = 3;
            stock.GetComponent<SpriteRenderer>().sortingOrder = 4;
        }
        else if (this.gameObject.name == "yellow")
        {
            isDragging = true;
            seasoning.GetComponent<SpriteRenderer>().sortingOrder = 5;//this section just sets the bowls and sauces to previously named game objects. Make it so that they are placed infront of everything when dragged.
            stock.GetComponent<SpriteRenderer>().sortingOrder = 6;
            hotsauce.GetComponent<SpriteRenderer>().sortingOrder = 3;
            water.GetComponent<SpriteRenderer>().sortingOrder = 4;
        }
        else if (this.gameObject.name == "spacemeatcut")
        {
            isDragging = true;
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = 4; 
        }
        else if (this.gameObject.name == "spacemeatcut1")
        {
            gameObject.transform.parent = null;
            isDragging = true;
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = 4;
        }




    }


    public void OnMouseUp()
    {

        isDragging = false; //no longer drag if mouse button lifted
    }


    void Update()
    {
        if (isDragging) //if is dragging is set to true, then set the mouseposition and translate any object to follow the position
        {

            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }

    }

    private void OnMouseEnter()
    {
        //This section is for the labels of the objects within the ramen scene
        if (Input.GetMouseButton(0)==false)
        {

            //If you enter an object, their label will be set to true
            if (this.gameObject.name == "water")
            {
                water.SetActive(true);
            }
            else if (this.gameObject.name == "stock")
            {
                stock.SetActive(true);
            }
            else if (this.gameObject.name == "hotsauce")
            {
                hotsauce.SetActive(true);
            }
            else if (this.gameObject.name == "seasoning")
            {
                seasoning.SetActive(true);
            }
            else if (this.gameObject.name == "soysauce")
            {
                soysauce.SetActive(true);
            }
            else if (this.gameObject.name == "pepper")
            {
                pepper.SetActive(true);
            }
            else if (this.gameObject.name == "eel")
            {
                eel.SetActive(true);
            }
            else if (this.gameObject.name == "onion")
            {
                onion.SetActive(true);
            }
            else if (this.gameObject.name == "laser")
            {
                laser.SetActive(true);
            }
        }
    }

    

    private void OnMouseExit()
    {
        //If you leave the object, their label will set to false so you no longer can see it.
        if (this.gameObject.name == "water")
        {
            water.SetActive(false);
        }
        else if (this.gameObject.name == "stock")
        {
            stock.SetActive(false);
        }
        else if (this.gameObject.name == "hotsauce")
        {
            hotsauce.SetActive(false);
        }
        else if (this.gameObject.name == "seasoning")
        {
            seasoning.SetActive(false);
        }
        else if (this.gameObject.name == "soysauce")
        {
            soysauce.SetActive(false);
        }
        else if (this.gameObject.name == "pepper")
        {
            pepper.SetActive(false);
        }
        else if (this.gameObject.name == "eel")
        {
            eel.SetActive(false);
        }
        else if (this.gameObject.name == "onion")
        {
            onion.SetActive(false);
        }
        else if (this.gameObject.name == "laser")
        {
            laser.SetActive(false);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

      

        GameObject UiHandling = GameObject.Find("UIHandler"); //find reference to Ui handler
        UIHandler Uihandle = UiHandling.GetComponent<UIHandler>();
        if (collision.gameObject.name == "bowl") //if object collides with bowl
        {
            if (gameObject.name == "spacemeatcut") //this is for the mixing stir fry scene
            {

                GameObject MeatHandling = GameObject.Find("MeatHandler"); //find reference to meat handler
                MeatHandler Meathandle = MeatHandling.GetComponent<MeatHandler>();


                gameObject.SetActive(false); //set it to false when colliding into bowl

                if (Meathandle.meatcounter == 0) //based on meat handler counter
                {
                    Uihandle.meat1 = true; //for the first meat, set the UI to true
                    collision.gameObject.GetComponent<AudioSource>().Play(); //play the sound of being put into a bowl
                    Meathandle.meatcounter = 1;
                    Meathandle.mixing = true; //allow for the meat to be mixed.
                }
                else if (Meathandle.meatcounter==1)
                {
                    Meathandle.meatcounter++; //increased meat counter
                    collision.gameObject.GetComponent<AudioSource>().Play();
                    Meathandle.mixing = true;
                }
                else if (Meathandle.meatcounter == 2)
                {
                    Meathandle.meatcounter++;
                    collision.gameObject.GetComponent<AudioSource>().Play();
                    Meathandle.mixing = true;
                }
                else if (Meathandle.meatcounter == 3)
                {
                    Meathandle.meatcounter++;
                    collision.gameObject.GetComponent<AudioSource>().Play();
                    Meathandle.mixing = true;
                }

            }
        }
        else if (collision.gameObject.name == "pan")
        {

            GameObject MeatHandling = GameObject.Find("MeatHandler");
            MeatHandler Meathandle = MeatHandling.GetComponent<MeatHandler>();
            if (gameObject.name == "spacemeatcut1" && Meathandle.mixed) // if the meat has been mixed and coating
            {
      

                gameObject.SetActive(false); //turn off the object
                Meathandle.meatfinalcounter++; //increas the FINAL meat counter for being mixed
                Meathandle.mixed = false; //set mixed to false to allow the next meat to be mixed

            }


        }
        //This section is for the ramen scene
        if (collision.gameObject.name == "pot") //if the object collides with a pot
        {
            if (this.gameObject.name != "laser") //if it is not the laser
            {


                this.gameObject.SetActive(false); //turn off the object
                if (this.gameObject.name == "water")
                {
                    Uihandle.stock = true; //set the UI for stock being the next step
                    UiHandling.GetComponent<AudioSource>().Play(); //play splash sound
                    waterpot.SetActive(true); //set the animation water pot active
                }
                if (this.gameObject.name == "stock")
                {
                    Uihandle.soy = true; //next step for UI for soy sauce
                    UiHandling.GetComponent<AudioSource>().Play(); //play splash
                    waterpot.SetActive(false); //turn off current waterpot animation 
                    waterpot1.SetActive(true); //changes the color to new animation
                }
                if (this.gameObject.name == "soysauce")
                {
                    Uihandle.hotsauce = true; //set step for hot sauce
                    UiHandling.GetComponent<AudioSource>().Play(); //place sound
                    waterpot.SetActive(false); //set old waterpot to false
                    waterpot1.SetActive(true); //new colored water
                }
                if (this.gameObject.name == "hotsauce")
                {
                    UiHandling.GetComponent<AudioSource>().Play(); //play suond
                    Uihandle.seasoning = true; //next step for seasoning to be true
                }
                if (this.gameObject.name == "seasoning")
                {
                    Uihandle.pepper = true; //next ui step for pepper
                    waterpot.SetActive(true);
                }
                if (this.gameObject.name == "pepper")
                {
                    Uihandle.onion = true; //next ui step for onion
                    waterpot.SetActive(true);
                }
                if (this.gameObject.name == "onion")
                {
                    Uihandle.eel = true; //next ui step for eel
                    waterpot.SetActive(true);
                }
            }





        }
        if (collision.gameObject.name == "eel") //if object collides with eel
        {
            if (this.gameObject.name == "laser") //and this object is the laser
            {
                this.gameObject.SetActive(false); //turn of the laser
                waterpot.SetActive(true);  //take the eels out of the bowl
                waterpot1.SetActive(false);
                Uihandle.eel3 = true; //set for the 3rd step of eel
            }
        }

       


    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (SceneManager.GetActiveScene().name == "StirFryStep1") //specifically for stirfry step 1
        {
            GameObject UiHandling = GameObject.Find("UIHandler"); //UI handler reference
            UIHandler Uihandle = UiHandling.GetComponent<UIHandler>();
            if (collision.gameObject.name == "bowl") //if the sauces enter the bowl
            {
                gameObject.SetActive(false); //turn off object
                if (gameObject.name == "red") //if it is the red sauce
                {
                    soysauce.SetActive(true); //set the red sauce to true (ignore the name of the gameobject just set it as itself in the inspector)
                    collision.gameObject.GetComponent<AudioSource>().Play(); //play splash sound
                    Uihandle.red = true; //set the Ui for red
                }
                else if (gameObject.name == "yellow") //if it is yellow sauce
                {
                    pepper.SetActive(true); //set yellow sauce in inspector and its set to true
                    collision.gameObject.GetComponent<AudioSource>().Play(); //splash sound
                    Uihandle.yellow = true;
                }


                if (Uihandle.yellow && Uihandle.red)
                {

                    eel.SetActive(false); //set the initial mix as false
                    onion.SetActive(true); //the alrady preset mix without separate objects as true ignore the name and set in spector.
                }


            }
        }
        
    }


}

