using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoneStir : MonoBehaviour
{

    public GameObject gameobject1;
    private void update()
    {
        if (gameobject1.transform.rotation.z > 150)
        {
            SceneManager.LoadScene("cut");
        }
    }
}

