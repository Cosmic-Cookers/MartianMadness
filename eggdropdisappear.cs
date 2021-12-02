using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggdropdisappear : MonoBehaviour
{

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name=="Inside Bowl")
        {
            this.gameObject.SetActive(false);


            this.gameObject.transform.parent.gameObject.SetActive(false);
        }
     

    }
}
