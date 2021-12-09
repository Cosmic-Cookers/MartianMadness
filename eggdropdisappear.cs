using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This is for the egg drop scene for exomorph. If the egg yolk enters the bowl, set it gone
/// </summary>
public class eggdropdisappear : MonoBehaviour
{

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name=="Inside Bowl")
        {
            this.gameObject.SetActive(false); //turn it off


            this.gameObject.transform.parent.gameObject.SetActive(false); //turn off its parent
        }
     

    }
}
