using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{

    [SerializeField] private Sprite doorClosed, doorOpen;
    [SerializeField] private string nextLevelName;
    private bool doorIsOpen, canExit;

    void Update()
    {
      ExitLevel();

    }

    private void ExitLevel()
    {
      if(Input.GetButtonDown("Interact") && canExit)
      {
        LoadNextLevel();
      }
    }

    private void LoadNextLevel()
    {
      SceneManager.LoadScene(nextLevelName);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
      if(Key.hasKey)
      {
        GetComponent<SpriteRenderer>().sprite = doorOpen;
        doorIsOpen = true;
        canExit = true;
      } else if(doorIsOpen)
      {
        canExit = true;
      }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
      canExit = false;
    }
}
