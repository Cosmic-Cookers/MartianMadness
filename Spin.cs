using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// ORIGINAL BASE CODE BY NICK
/// Large modifications by Julia
/// This code is specificlaly for the mixing and spinning sections for you to mix the liquid ingredients together
/// </summary>
public class Spin : MonoBehaviour
{
    private bool isDragging;

    /// <summary>
    /// Mixing objects thtat are added slowly
    /// </summary>
    public GameObject mix1;
    public GameObject mix2;
    public GameObject mix3;
    public GameObject mix4;
    public GameObject mix5;
    public GameObject UIcanvas;
    private int rotations = 0; //how many rotations has
  
    private bool passninety = false; //if it passes a certain degree
    private bool passneg = false; // if it passes a certain degree
    Vector3 oldEulerAngles;
    public AudioSource mixing; //mixing sound
    
    

    public void OnMouseDown()
    {
      
        if (SceneManager.GetActiveScene().name == "StirFryStep4")
        {
            GameObject MeatHandling = GameObject.Find("MeatHandler");
            MeatHandler Meathandle = MeatHandling.GetComponent<MeatHandler>();
            if (Meathandle.mixing == true) //coat mixing 
            {
                isDragging = true;
                mixing.Play();
            }

         
        }
        else
        {
            if (rotations != 12) //if you haven't finished rotating the mixture 12 times, then allos it to be mixed still
            {
                isDragging = true;
                mixing.Play(0);
            }
        }


    }
        
        
   


    // Start is called before the first frame update
    void Start()
    {
        oldEulerAngles = transform.rotation.eulerAngles; //start with the euler angles
    }
    
    // Update is called once per frame
    void Update()
    {

       
        if (isDragging)
        {
            //AudioSource mix = gameObject.GetComponent<AudioSource>();
     
            //Cursor.visible = false;
            Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
            transform.rotation = rotation;

            if (oldEulerAngles == transform.rotation.eulerAngles)
            {
                //Debug.Log("not");
                mixing.Pause(); //stop the sound if you havent moved
            }
            else
            {
                oldEulerAngles = transform.rotation.eulerAngles;
   
                if (!mixing.isPlaying)
                {
                    mixing.Play(); //if the sound has stopped, start playing it again
                }
            }


            //mixing.Play(2);
            //Debug.Log(angle);

            
           

            if (angle > 70 && angle < 110) //if it passes these angles, set it to true
            {
                passninety = true;
            }
            if (angle > -110 && angle < -70) //if it passes these negative angles, set it to true
            {
                passneg = true;
            }

            if (passninety && passneg) //if it passes both, that is one rotation and then set them to false again
            {
                rotations++;
                passninety = false;
                passneg = false;
                //mix.Play();
            }

            if (SceneManager.GetActiveScene().name == "StirFryStep4"){ //if it is the stir fry

                GameObject MeatHandling = GameObject.Find("MeatHandler");
                MeatHandler Meathandle = MeatHandling.GetComponent<MeatHandler>();

                if (rotations >= 6) //once you get to 6 rotations
                {
                    isDragging = false; //you can't drag it anymore
                    mixing.Stop(); //turn off the sound
                    Meathandle.mixing = false; //no longer the mix step, and set it to being mixed
                    Meathandle.mixed = true;
                    rotations = 0;
                }

            }
            else
            {
                if (rotations == 3) //after each set of rotations, set the new mixed sections on top to active
                {
                    mix1.SetActive(false);
                    mix2.SetActive(true);
                }
                if (rotations == 6)
                {
                    mix2.SetActive(false);
                    mix3.SetActive(true);
                }
                if (rotations == 9)
                {
                    mix3.SetActive(false);
                    mix4.SetActive(true);
                }
                if (rotations == 12)
                {
                    mix4.SetActive(false);
                    mix5.SetActive(true);
                    Cursor.visible = true;
                    isDragging = false; //once we hit 12 rotations, stop and make mixing sound stop ass well
                    mixing.Stop();


                    UIegghandler Uihandler = UIcanvas.GetComponent<UIegghandler>();
                    Uihandler.nextUI = true; //next step
                }



            }

        }

           

        //Debug.Log(passninety);
        //Debug.Log(passneg);
        //Debug.Log(rotations);
        /*if(angle > 160 || angle < -160)
        {
            SceneManager.LoadScene("New Cut");
        }*/
    }
    
    
    
}
