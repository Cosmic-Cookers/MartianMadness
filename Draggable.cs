using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
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

        GameObject UiHandling = GameObject.Find("UIHandler");
        UIHandler Uihandle = UiHandling.GetComponent<UIHandler>();

        if (this.gameObject.name == "water")
        {


            if (Uihandle.fire)
            {
                water.SetActive(false);
                isDragging = true;
                this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 5;
            }
        }
        else if (this.gameObject.name == "stock")
        {


            if (Uihandle.stock)
            {
                stock.SetActive(false);
                this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 4;
                isDragging = true;
            }
        }
        else if (this.gameObject.name == "hotsauce")
        {
            if (Uihandle.hotsauce)
            {
                hotsauce.SetActive(false);
                this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
                isDragging = true;
            }
           
        }
        else if (this.gameObject.name == "seasoning")
        {
            if (Uihandle.seasoning)
            {
                seasoning.SetActive(false);
                this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 5;
                isDragging = true;
            }
            
        }
        else if (this.gameObject.name == "soysauce")
        {
            if (Uihandle.soy)
            {
                isDragging = true;
                soysauce.SetActive(false);
                this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 3;
            }
           
        }
        else if (this.gameObject.name == "pepper")
        {
            if (Uihandle.pepper)
            {
                pepper.SetActive(false);
                isDragging = true;
                this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
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
                isDragging = true;
                this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
            }
           
        }
        else if (this.gameObject.name == "laser")
        {
            if (Uihandle.eel)
            {
                laser.SetActive(false);
                this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 5;
                isDragging = true;
                Uihandle.eel2 = true;
            }
          
        }
        else if (this.gameObject.name == "red")
        {
            isDragging = true;
            hotsauce.GetComponent<SpriteRenderer>().sortingOrder = 5;
            water.GetComponent<SpriteRenderer>().sortingOrder = 6;
            seasoning.GetComponent<SpriteRenderer>().sortingOrder = 3;
            stock.GetComponent<SpriteRenderer>().sortingOrder = 4;
        }
        else if (this.gameObject.name == "yellow")
        {
            isDragging = true;
            seasoning.GetComponent<SpriteRenderer>().sortingOrder = 5;
            stock.GetComponent<SpriteRenderer>().sortingOrder = 6;
            hotsauce.GetComponent<SpriteRenderer>().sortingOrder = 3;
            water.GetComponent<SpriteRenderer>().sortingOrder = 4;
        }


    }


    public void OnMouseUp()
    {

        isDragging = false;
    }


    void Update()
    {
        if (isDragging)
        {

            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }

    }

    private void OnMouseEnter()
    {
        if (Input.GetMouseButton(0)==false)
        {

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
        Debug.Log(collision.name);
        GameObject UiHandling = GameObject.Find("UIHandler");
        UIHandler Uihandle = UiHandling.GetComponent<UIHandler>();

        if (collision.gameObject.name == "pot")
        {
            if (this.gameObject.name != "laser")
            {


                this.gameObject.SetActive(false);
                if (this.gameObject.name == "water")
                {
                    Uihandle.stock = true;
                    UiHandling.GetComponent<AudioSource>().Play();
                    waterpot.SetActive(true);
                }
                if (this.gameObject.name == "stock")
                {
                    Uihandle.soy = true;
                    UiHandling.GetComponent<AudioSource>().Play();
                    waterpot.SetActive(false);
                    waterpot1.SetActive(true);
                }
                if (this.gameObject.name == "soysauce")
                {
                    Uihandle.hotsauce = true;
                    UiHandling.GetComponent<AudioSource>().Play();
                    waterpot.SetActive(false);
                    waterpot1.SetActive(true);
                }
                if (this.gameObject.name == "hotsauce")
                {
                    UiHandling.GetComponent<AudioSource>().Play();
                    Uihandle.seasoning = true;
                }
                if (this.gameObject.name == "seasoning")
                {
                    Uihandle.pepper = true;
                    waterpot.SetActive(true);
                }
                if (this.gameObject.name == "pepper")
                {
                    Uihandle.onion = true;
                    waterpot.SetActive(true);
                }
                if (this.gameObject.name == "onion")
                {
                    Uihandle.eel = true;
                    waterpot.SetActive(true);
                }
            }





        }
        if (collision.gameObject.name == "eel")
        {
            if (this.gameObject.name == "laser")
            {
                this.gameObject.SetActive(false);
                waterpot.SetActive(true);
                waterpot1.SetActive(false);
                Uihandle.eel3 = true;
            }
        }

       


    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject UiHandling = GameObject.Find("UIHandler");
        UIHandler Uihandle = UiHandling.GetComponent<UIHandler>();
        if (collision.gameObject.name == "bowl")
        {
            gameObject.SetActive(false);
            if (gameObject.name == "red")
            {
                soysauce.SetActive(true);
                collision.gameObject.GetComponent<AudioSource>().Play();
                Uihandle.red = true;
            }
            else if (gameObject.name == "yellow"){
                pepper.SetActive(true);
                collision.gameObject.GetComponent<AudioSource>().Play();
                Uihandle.yellow = true;
            }
            if (Uihandle.yellow && Uihandle.red)
            {
                eel.SetActive(false);
                onion.SetActive(true);
            }

        }
    }
}

