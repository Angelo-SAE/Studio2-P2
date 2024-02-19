using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{

    private GameObject pauseMenu;
    private bool gamePaused;

    void Start()
    {
      pauseMenu = transform.GetChild(0).gameObject;
    }

    void Update()
    {
      PauseGameButton();
    }

    private void PauseGameButton()
    {
      if(Input.GetButtonDown("Pause") && !gamePaused)
      {
        PauseGamee();
      } else if(Input.GetButtonDown("Pause") && gamePaused)
      {
        UnPauseGame();
      }
    }

    public void PauseGamee()
    {
      pauseMenu.SetActive(true);
      gamePaused = true;
      Time.timeScale = 0;
    }

    public void UnPauseGame()
    {
      pauseMenu.SetActive(false);
      gamePaused = false;
      Time.timeScale = 1;
    }

}
