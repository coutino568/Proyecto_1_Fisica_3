using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject simulationUI;
    public bool isGamePaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            UnityEngine.Debug.Log(" Menu");
            if (isGamePaused ==false)
            {
                Pause();
            }
            else
            {
                Resume();
            }
            
            //rb.gravityScale *= -1;
        }
    }


    void Pause()
    {
        simulationUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        isGamePaused = true;
        Time.timeScale = 0f;
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        simulationUI.SetActive(true);
        isGamePaused = false;
        Time.timeScale = 1f;
        
    }
}
