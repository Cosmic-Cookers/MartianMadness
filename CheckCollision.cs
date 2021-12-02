using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    public Sprite Cracked;
    private bool isCracked = false;
    public bool isDrop = false;
    private int crackCount = 0;
    private GameObject yolk;
    public GameObject Egg2;
    public GameObject Egg3;
    


    public void Start()
    {

    }

    public void playSound()
    {

            AudioSource egghit = gameObject.GetComponent<AudioSource>();
            egghit.Play();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject egg = GameObject.Find("Egg Counter");
        EggCounter eggcounting = egg.GetComponent<EggCounter>();
        Debug.Log(other.gameObject);

        if (other.gameObject.name == "Bowl")
        {
            Debug.Log("Did Collide Bowl");
            crackCount++;
            playSound();

            if (crackCount == 3)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Cracked;
                isCracked = true;
            }

        }
        if (isCracked)
        {
            if (other.gameObject.name == "eggdrop")
            {
                Debug.Log("Did Collide Fall");
                isDrop = true;
                this.gameObject.transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z - 27.629f);
                yolk = this.gameObject.transform.GetChild(0).gameObject;
                yolk.SetActive(true);
                StartCoroutine(EggCoroutine());

                eggcounting.eggCount++;
            }

        }
        
        
;

    }

    IEnumerator EggCoroutine()
    {
       
        yield return new WaitForSeconds(2);

        gameObject.SetActive(false);
        eggDisplay();
    }



    void Update()
    {
        Animator egg_crack = this.GetComponent<Animator>();
        if (isCracked)
        {
            egg_crack.SetBool("collideBowl", true);

            /*if (transform.position.y > 1)
            {
                if (transform.position.x < -2.5)
                {
                    Debug.Log("Yes");
                    SceneManager.LoadScene("Stir");
                }
            }
            */
            if (isDrop)
            {
                egg_crack.SetBool("eggDrop", true);
                
            }
        }

        

    }


    public void eggDisplay()
    {
        GameObject egg = GameObject.Find("Egg Counter");
        EggCounter eggcounting = egg.GetComponent<EggCounter>();
        if (eggcounting.eggCount == 1)
        {
            
            Egg2.SetActive(true);
        }
        if (eggcounting.eggCount == 2)
        {
            Egg3.SetActive(true);
        }
    }

}
