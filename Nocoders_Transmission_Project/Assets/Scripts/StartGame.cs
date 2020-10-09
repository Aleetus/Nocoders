using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public float timeLeft = 3.0f;
    public Text startText;
    public Text playerCount;
    

    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            
        }
        if (GameObject.FindGameObjectsWithTag("uninfected").Length > 1)  
        {
            playerCount.text = GameObject.FindGameObjectsWithTag("uninfected").Length.ToString();

        }
    }
}
