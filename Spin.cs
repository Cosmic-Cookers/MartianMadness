using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spin : MonoBehaviour
{
    private bool isDragging;
    public GameObject mix1;
    public GameObject mix2;
    public GameObject mix3;
    public GameObject mix4;
    public GameObject mix5;
    private int rotations = 0;
  
    private bool passninety = false;
    private bool passneg = false;
    Vector3 oldEulerAngles;
    public AudioSource mixing;
    
    

    public void OnMouseDown()
    {
        if (rotations != 12)
        {
            isDragging = true;
            mixing.Play(0);
        }

    }
        
        
   


    // Start is called before the first frame update
    void Start()
    {
        oldEulerAngles = transform.rotation.eulerAngles;
    }
    
    // Update is called once per frame
    void Update()
    {
       
        if (isDragging)
        {
            // AudioSource mix = gameObject.GetComponent<AudioSource>();
     
            //Cursor.visible = false;
            Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
            transform.rotation = rotation;
            if (oldEulerAngles == transform.rotation.eulerAngles)
            {
                Debug.Log("not");
                mixing.Pause();
            }
            else
            {
                oldEulerAngles = transform.rotation.eulerAngles;
                Debug.Log("rotating");
                if (!mixing.isPlaying)
                {
                    mixing.Play();
                }
            }


            //mixing.Play(2);
            //Debug.Log(angle);

            
           

            if (angle > 70 && angle < 110)
            {
                passninety = true;
            }
            if (angle > -110 && angle < -70)
            {
                passneg = true;
            }

            if (passninety && passneg)
            {
                rotations++;
                passninety = false;
                passneg = false;
                //mix.Play();
            }

            if (rotations == 3)
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
                isDragging = false;
                mixing.Stop();

                GameObject UIhandle = GameObject.Find("Canvas");
                UIegghandler Uihandler = UIhandle.GetComponent<UIegghandler>();
                Uihandler.nextUI = true;
            }
           
            

        }

        Debug.Log(passninety);
        Debug.Log(passneg);
        Debug.Log(rotations);
        /*if(angle > 160 || angle < -160)
        {
            SceneManager.LoadScene("New Cut");
        }*/
    }
    
    
    
}
