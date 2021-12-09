using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class crackedPieceManager : MonoBehaviour
{
    /// <summary>
    /// This is for the ramen recipe where you crack off the shells of the egg. Within this one, there is a visual novel aspect of it, so there is also
    /// text included for this section.
    /// Thi sis also for smashed eggs for kamary salad.
    /// </summary>
    public int eggpiecescount=0; //how many pieces have been cracked
    public int smashedeggs = 0; //how many eggs have been smashed
    public GameObject Button; //next step button
    
    /// <summary>
    /// These are the character expressions for this step and the text for the visual novel
    /// </summary>
    public GameObject Quincy_disappointed;
    public GameObject Margo_surprised;
    public GameObject Quincy_expressionless;
    public GameObject Margo_disappointed;
    public Text text;

 

    // Update is called once per frame
    void Update()
    {
        if (eggpiecescount == 14) //once all egg pieces are cracked
        {
            Button.SetActive(true); //next button set to true
            eggpiecescount = 0; //set egg pieces to 0
            text.text = "I always thought colonization was a good thing... Until now."; //text for this step
            Quincy_disappointed.SetActive(false); //turn off previous expression
            Margo_disappointed.SetActive(true); //turn on current expression
        }
        if (eggpiecescount == 4) 
        {
            text.text = "That’s why he’s so protective of his recipes and customs."; 
            Quincy_expressionless.SetActive(false);
            Margo_surprised.SetActive(true);
        }
        if (eggpiecescount == 8)
        {
            text.text = "Yup. Humans decimated our planet and rebuilt it with their own cultures and ideas. They colonized Mars by force. That egg looks just about ready.";
            Margo_surprised.SetActive(false);
            Quincy_disappointed.SetActive(true);
        }

        if (smashedeggs == 6) //once all eggs are smashed, set button active
        {
            Button.SetActive(true);
        }
    }
}
