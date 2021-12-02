using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crackedPieceManager : MonoBehaviour
{
    public int eggpiecescount=0;
    public int smashedeggs = 0;
    public GameObject Button;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (eggpiecescount == 14)
        {
            Button.SetActive(true);
            eggpiecescount = 0;
        }
        if (smashedeggs == 6)
        {
            Button.SetActive(true);
        }
    }
}
