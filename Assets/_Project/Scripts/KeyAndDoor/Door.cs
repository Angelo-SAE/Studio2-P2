using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    [SerializeField] private Sprite doorClosed, doorOpen;
    private bool doorIsOpen;

    private void OnTriggerEnter2D(Collider2D col)
    {
      if(Key.hasKey)
      {
        GetComponent<SpriteRenderer>().sprite = doorOpen;
        doorIsOpen = true;
      }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
      if(Input.GetButtonDown("Interact") && doorIsOpen)
      {
        Debug.Log("Complete");
      }
    }
}
