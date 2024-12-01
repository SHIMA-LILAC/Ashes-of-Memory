using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Locker : MonoBehaviour
{
   
    public bool PauseGame;
    public GameObject pauseGameMenu;
    bool openedMenu;

   

    
    void Update()
    {

        
       if (openedMenu)
        {
            openedMenu = false;
            pauseGameMenu.SetActive(false);
            Time.timeScale = 1f;
            PauseGame = false;
            Resume();
        }
    }

    public void Resume()
    {
        openedMenu = false;
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }

    public void Pause()
    {
        openedMenu = true;
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }

   

}